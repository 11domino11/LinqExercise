using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            Console.WriteLine("---Sum---\n");
            int sum = numbers.Sum();
            Console.WriteLine(sum);
            //TODO: Print the Average of numbers
            Console.WriteLine("---Average---\n");
            double average = numbers.Average();
            Console.WriteLine(average);
            //TODO: Order numbers in ascending order and print to the console
            Console.WriteLine("---Ascending---\n");
            var ascending = numbers.OrderBy(num => num).ToList();
            foreach (var item in ascending)
            {
                Console.WriteLine(item);
            }
            //TODO: Order numbers in decsending order adn print to the console
            Console.WriteLine("---Descending---\n");
            var descending = numbers.OrderByDescending(num => num).ToList();
            foreach(var item in descending)
            {
                Console.WriteLine(item);
            }
            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("---Greater Than 6---\n");
            var greaterThan6 = (numbers.Where(num => num > 6));
            foreach (var item in greaterThan6)
            {
                Console.WriteLine(item);
            }

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("---Only 4---\n");
            foreach (var item in ascending.Take(4))
            {
                Console.WriteLine(item);
            }

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order
            Console.WriteLine("---with age---\n");
            numbers[4] = 22;
            foreach (var item in numbers.OrderByDescending(x => x))
            {
                Console.WriteLine(item);
            }

            // List of employees ****Do not remove this****
            Console.WriteLine("---Employees---\n");
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in acesnding order by FirstName.
            var employeeNames = employees.Where(x => x.FirstName.StartsWith('C') || x.FirstName.StartsWith('S')).OrderBy(x => x.FirstName);
            foreach(var employee in employeeNames)
            {
                Console.WriteLine(employee.FullName);
            }
            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            Console.WriteLine("---Employees Age--- \n");
            var employeeAge = employees.Where(x => x.Age > 26).OrderBy(x => x.Age).OrderBy(x =>x.FirstName);
            foreach (var item in employeeAge)
            {
                Console.WriteLine(item.FullName + " "+ item.Age);
            }


            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35
            Console.WriteLine("---Employees Experience---\n");
            var employeeExperience = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);
            var employeeSum = employeeExperience.Sum(x => x.YearsOfExperience);
            Console.WriteLine("Sum is: " + employeeSum);
            var employeeAvg = employeeExperience.Average(x => x.YearsOfExperience);
            Console.WriteLine("Average is: " + employeeAvg);

            //TODO: Add an employee to the end of the list without using employees.Add()
            employees = employees.Append(new Employee("Damion", "Russell", 23, 1)).ToList();
            foreach (var item in employees)
            {
                Console.WriteLine(item.FullName);
            }

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
