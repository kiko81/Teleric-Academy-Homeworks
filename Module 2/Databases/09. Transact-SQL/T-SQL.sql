-- 1.	Create a database with two tables: `Persons(Id(PK), FirstName, LastName, SSN)` and `Accounts(Id(PK), PersonId(FK), Balance)`.
-- 	*	Insert few records for testing.
---------------------------------------
USE master
GO

-- Create a db named 'AccountsManagement'
CREATE DATABASE AccountManagement
GO

-- Checkout db 'AccountsManagement'
USE AccountManagement
GO

-- Create a new table named 'Persons'
CREATE TABLE Persons (
	Id int IDENTITY NOT NULL PRIMARY KEY,
	FirstName nvarchar(50) NOT NULL,
	LastName nvarchar(50) NOT NULL,
	SSN nvarchar(50) NOT NULL
)
GO

-- Create a new table named 'Accounts'
CREATE TABLE Accounts (
	Id int IDENTITY NOT NULL PRIMARY KEY,
	PersonId int NOT NULL FOREIGN KEY REFERENCES Persons(Id),
	Balance money NOT NULL
)
GO

-- Insert few records for testing purposes
DECLARE @counter tinyint
SET @counter = 20
WHILE @counter > 0
	BEGIN
		INSERT INTO Persons(FirstName, LastName, SSN)
		VALUES ('Pesho ' + CAST(@counter AS varchar),
				'Goshov ' + CAST(@counter AS varchar),
				@counter + 1000000)
		SET @counter = @counter - 1
	END
GO
	
-- Insert few accounts for testing purposes
DECLARE @counter tinyint
SET @counter = 20
WHILE @counter > 0
	BEGIN
		-- Generate a random number
		DECLARE @randomNumber int
		SELECT @randomNumber = @counter + 100000
		
		INSERT INTO Accounts(PersonId, Balance)
		VALUES (@counter, @randomNumber)
		SET @counter -= 1
	END
GO
----------------------------------------------------------------------------
-- 	*	Write a stored procedure that selects the full names of all persons.
---------------------------------------
CREATE PROCEDURE usp_SelectFullNames
AS 
	SELECT CONCAT(FirstName, ' ', LastName) AS [FullName]
	FROM Persons
GO
----------------------------------------------------------------------------
-- 2.	Create a stored procedure that accepts a number as a parameter and returns all persons who have more money in their accounts -t- han the supplied number.
---------------------------------------
CREATE PROCEDURE usp_SelectPersonsWithGreatherBalance (
	@minBalance money = 1000)
AS 
	SELECT *
	FROM Persons p
	JOIN Accounts a
		ON p.Id = a.PersonId
	WHERE a.Balance > @minBalance
	ORDER BY a.Balance
GO
---------------------------------------------------------------------------
-- 3.	Create a function that accepts as parameters – sum, yearly interest rate and number of months.
-- 	*	It should calculate and return the new sum.
---------------------------------------
CREATE FUNCTION dbo.ufn_CalculateInterest (
	@sum money, @yearlyInterestRate float, @months tinyint)
	RETURNS money
AS
	BEGIN
		RETURN @sum * @yearlyInterestRate / 12 * @months
	END
GO
---------------------------------------------------------------------------
-- 	*	Write a `SELECT` to test whether the function works as expected.
---------------------------------------
SELECT Balance, dbo.ufn_CalculateInterest(Balance, 0.05, 10) as [Bonus]
FROM Accounts
---------------------------------------------------------------------------
-- 4.	Create a stored procedure that uses the function from the previous example to give an interest to a person's account for one -m- onth.
-- 	*	It should take the `AccountId` and the interest rate as parameters.
---------------------------------------
CREATE PROCEDURE dbo.usp_CalculateInterestForOneMonth (
	@accountId int, @yearlyInterestRate float)
AS
	DECLARE @balance money
	SELECT @balance = Balance FROM Accounts WHERE Id = @accountId
	
	DECLARE @newBalance money
	SELECT @newBalance = dbo.ufn_CalculateInterest(@balance, @yearlyInterestRate, 1)
	
	SELECT p.FirstName, p.LastName, a.Balance, @newBalance AS [New Balance]
	FROM Persons p
	JOIN Accounts a
		ON p.Id = a.PersonId
	WHERE a.Id = @accountId
GO
---------------------------------------------------------------------------
-- 5.	Add two more stored procedures `WithdrawMoney(AccountId, money)` and `DepositMoney(AccountId, money)` that operate in transactions.
---------------------------------------
CREATE PROCEDURE dbo.usp_WithdrawMoney(@accountId int, @money money)
AS
    BEGIN TRAN
        UPDATE Accounts
        SET Balance -= @money
        WHERE AccountId = @accountId
    COMMIT TRAN
GO

CREATE PROCEDURE dbo.usp_DepositMoney(@accountId int, @money money)
AS
    BEGIN TRAN
        UPDATE Accounts
        SET Balance += @money
        WHERE AccountId = @accountId
    COMMIT TRAN
GO
---------------------------------------------------------------------------
-- 6.	Create another table – `Logs(LogID, AccountID, OldSum, NewSum)`.
---------------------------------------
CREATE TABLE Logs (
    LogId int IDENTITY PRIMARY KEY,
    AccountId int NOT NULL FOREIGN KEY REFERENCES Accounts(Id),
    OldSum money NOT NULL,
    NewSum money NOT NULL
)
---------------------------------------------------------------------------
-- 	*	Add a trigger to the `Accounts` table that enters a new entry into the `Logs` table every time the sum on an account -c-ha nges.
---------------------------------------
CREATE TRIGGER tr_UpdateAccountBalance ON Accounts FOR UPDATE
AS
    DECLARE @oldSum money;
    SELECT @oldSum = Balance FROM deleted;

    INSERT INTO Logs(AccountId, OldSum, NewSum)
        SELECT Id, @oldSum, Balance
        FROM inserted
GO
---------------------------------------------------------------------------
-- 7.	Define a function in the database `TelerikAcademy` that returns all Employee's names (first or middle or last name) and all town's names that are comprised of given set of letters.
---------------------------------------
USE TelerikAcademy
GO

CREATE FUNCTION ufn_CheckName(
@nameToCheck NVARCHAR(50), 
@letters NVARCHAR(50))
RETURNS INT
AS
BEGIN
        DECLARE @i INT = 1
		DECLARE @currentChar NVARCHAR(1)
        WHILE (@i <= LEN(@nameToCheck))
			BEGIN
				SET @currentChar = SUBSTRING(@nameToCheck,@i, 1)
					IF (CHARINDEX(LOWER(@currentChar),LOWER(@letters)) <= 0) 
						BEGIN  
							RETURN 0
						END
				SET @i = @i + 1
			END
        RETURN 1
END
GO
---------------------------------------------------------------------------
-- 8.	Using database cursor write a T-SQL script that scans all employees and their addresses and prints all pairs of employees that live in the same town.
---------------------------------------
USE TelerikAcademy
GO

DECLARE empCursor CURSOR READ_ONLY FOR
    SELECT emp1.FirstName, emp1.LastName, t1.Name, emp2.FirstName, emp2.LastName
    FROM Employees emp1
    JOIN Addresses a1
        ON emp1.AddressID = a1.AddressID
    JOIN Towns t1
        ON a1.TownID = t1.TownID,
        Employees emp2
    JOIN Addresses a2
        ON emp2.AddressID = a2.AddressID
    JOIN Towns t2
        ON a2.TownID = t2.TownID
    WHERE t1.TownID = t2.TownID AND emp1.EmployeeID != emp2.EmployeeID
    ORDER BY emp1.FirstName, emp2.FirstName

OPEN empCursor

DECLARE @firstName1 nvarchar(50), 
        @lastName1 nvarchar(50),
        @townName nvarchar(50),
        @firstName2 nvarchar(50),
        @lastName2 nvarchar(50)
FETCH NEXT FROM empCursor INTO @firstName1, @lastName1, @townName, @firstName2, @lastName2

DECLARE @counter int;
SET @counter = 0;

WHILE @@FETCH_STATUS = 0
	BEGIN
		SET @counter = @counter + 1;

		PRINT @firstName1 + ' ' + @lastName1 + 
			  '     ' + @townName + '       ' +
			  @firstName2 + ' ' + @lastName2;

		FETCH NEXT FROM empCursor 
		INTO @firstName1, @lastName1, @townName, @firstName2, @lastName2
	END

print 'Total records: ' + CAST(@counter AS nvarchar(10));

CLOSE empCursor
DEALLOCATE empCursor
---------------------------------------------------------------------------
-- 9.	*Write a T-SQL script that shows for each town a list of all employees that live in it.
---------------------------------------
---------------------------------------------------------------------------
-- 10.	Define a .NET aggregate function StrConcat that takes as input a sequence of strings and return a single string that consists of the input strings separated by ','.
---------------------------------------
---------------------------------------------------------------------------