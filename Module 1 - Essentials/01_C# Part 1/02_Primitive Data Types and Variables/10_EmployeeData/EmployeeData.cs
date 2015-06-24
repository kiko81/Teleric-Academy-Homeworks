/*
Problem 10. Employee Data

A marketing company wants to keep record of its employees. Each record would have the following characteristics:

First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.
*/

using System;

class EmployeeData
{
    static void Main()
    {

        
        string stringFname = "First name: ";
        string stringLname = "Last name: ";
        string stringAge = "Age: ";
        string stringGender = "Gender: ";
        string stringID = "Personal ID: ";
        string stringEN = "Unique emplyee number: ";
        Console.Write(stringEN);
        uint uniqueEmployeeNum= uint.Parse(Console.ReadLine());
        Console.Write(stringFname);
        string firstName = Console.ReadLine();
        Console.Write(stringLname);
        string lastName = Console.ReadLine();
        Console.Write(stringAge);
        byte age = byte.Parse(Console.ReadLine());
        Console.Write(stringGender);
        string gender = Console.ReadLine();
        Console.Write(stringID);
        ulong personalID = ulong.Parse(Console.ReadLine());

        Console.WriteLine(" {6, -25} {0} \n {7, -25} {1} \n {8, -25} {2} \n {9, -25} {3} \n {10, -25} {4} \n {11, -25} {5}", firstName, lastName, age, gender, personalID, uniqueEmployeeNum, stringFname, stringLname, stringAge, stringGender, stringID, stringEN);



    }
}