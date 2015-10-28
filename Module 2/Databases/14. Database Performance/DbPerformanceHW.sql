--Create a table in SQL Server -> execute DbPerformanceHW.sql to create
--fill with 10 000 000 log entries (date + text). -> run the following - i coudn't - don't have enough resources
DECLARE @Counter int = 0
WHILE (SELECT COUNT(*) FROM Sample) < 10000000
BEGIN
	INSERT INTO Sample(SomeText, Date)
	VALUES ('alabala' + CONVERT(varchar, @Counter), GETDATE() - @Counter)
	SET @Counter = @Counter + 1
END
GO
--Search in the table by date range. Check the speed (without caching).
SELECT *
FROM Sample
WHERE YEAR(Date) BETWEEN 2013 and 2014

--Add an index to speed-up the search by date.
CREATE INDEX IDX_Sample_Date
ON Sample(Date)
--Test the search speed (after cleaning the cache).
SELECT *
FROM Sample
WHERE YEAR(Date) BETWEEN 2013 and 2014
--Add a full text index for the text column.
CREATE FULLTEXT CATALOG SomeTextCatalog
WITH ACCENT_SENSITIVITY = OFF
-- here are some issues enabling full text index - https://social.msdn.microsoft.com/Forums/sqlserver/en-US/c5431d34-3feb-4619-b641-7bfd15324b60/problems-creating-full-text-index?forum=sqldatabaseengine

CREATE FULLTEXT INDEX ON Sample(SomeText)
KEY INDEX ix_Sample
ON SomeTextCatalog
WITH CHANGE_TRACKING AUTO

--Try to search with and without the full-text index and compare the speed.
--without
SELECT * 
FROM Sample
WHERE SomeText LIKE 'alab%'
GO
----
--with
SELECT * 
FROM Sample
WHERE CONTAINS(SomeText, 'alab%')


--Create the same table in MySQL and partition it by date (1990, 2000, 2010).
--Fill 1 000 000 log entries.
--Compare the searching speed in all partitions (random dates) to certain partition (e.g. year 1995).

