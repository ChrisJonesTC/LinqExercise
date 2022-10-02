using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

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

            //DONE: Print the Sum of numbers
            var sum = numbers.Sum();
            Console.WriteLine($"Sum: {sum}");
            
            //DONE: Print the Average of numbers
            var avg = numbers.Average();
            Console.WriteLine($"Average: {avg}");
            
            //DONE: Order numbers in ascending order and print to the console
            Console.WriteLine($"Ascending Order");
            Console.WriteLine();
            numbers.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));


            //DONE: Order numbers in decsending order adn print to the console
            Console.WriteLine($"Decsending Order");
            Console.WriteLine();
            numbers.OrderByDescending(x => x)
                   .ToList()
                   .ForEach(x => Console.WriteLine(x));
            

            //DONE: Print to the console only the numbers greater than 6
            //var grt = numbers.Where(x => x);
            Console.WriteLine($"Numbers Greater Than 6");
            Console.WriteLine();
            numbers.Where(x =>x > 6).ToList().ForEach(x => Console.WriteLine(x));

            
            
            
            //DONE: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine($"Printing 4 in Any Order");
            foreach (var number in numbers.OrderBy(x => x).Take(4))
            {
                Console.WriteLine(number);
            }
            
            
            //DONE: Change the value at index 4 to your age, then print the numbers in decsending order
            Console.WriteLine($"Decsending Order");
            Console.WriteLine();
            numbers[4] = 31;
            numbers.OrderByDescending(x =>x)
                   .ToList()
                   .ForEach (x => Console.WriteLine(x));
            
            
            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //DONE: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in acesnding order by FirstName.
            employees.Where(x => x.FirstName.StartsWith('C')
                              || x.FirstName.StartsWith('S'))
                     .OrderBy(x => x.FirstName)
                     .ToList()
                     .ForEach(x => Console.WriteLine(x));

            //DONE: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            employees.Where(x => x.Age > 26)
                     .OrderBy(x => x.Age)
                     .ThenBy(x => x.FirstName)
                     .ToList()
                     .ForEach(x => Console.WriteLine(x.FullName));

            //DONE: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35
            Console.WriteLine(employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 10)
                                       .Sum(x => x.YearsOfExperience));
            
            Console.WriteLine(employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 10)
                                       .Average(x => x.YearsOfExperience));


            //DONE: Add an employee to the end of the list without using employees.Add()
            employees = employees.Append(new Employee("Chris", "Jones", 31, 0)).ToList();


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
