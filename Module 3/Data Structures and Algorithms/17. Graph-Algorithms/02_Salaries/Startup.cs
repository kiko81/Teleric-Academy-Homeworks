namespace Salaries
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        private static readonly IDictionary<int, List<int>> adjacencyList = new Dictionary<int, List<int>>();
        private static long[] employees;

        internal static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            employees = new long[n];

            for (var i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine();
                adjacencyList[i] = new List<int>();

                for (var j = 0; j < n; j++)
                {
                    if (inputLine[j] == 'Y')
                    {
                        adjacencyList[i].Add(j);
                    }
                }

                if (adjacencyList[i].Count == 0)
                {
                    employees[i] = 1;
                }
            }

            Console.WriteLine(CalculateTotalSalary());
        }

        private static long CalculateTotalSalary()
        {
            long totalSalary = 0;

            for (var i = 0; i < employees.Length; i++)
            {
                totalSalary += Calculate(i);
            }

            return totalSalary;
        }

        private static long Calculate(int employeeId)
        {
            if (employees[employeeId] != 0)
            {
                return employees[employeeId];
            }

            foreach (var employee in adjacencyList[employeeId])
            {
                employees[employeeId] += Calculate(employee);
            }

            return employees[employeeId];
        }
    }
}