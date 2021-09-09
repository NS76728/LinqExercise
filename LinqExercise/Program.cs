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
             *
             * HINT: Use the List of Methods defined in the Lecture Material Google Doc ***********
             *
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //Print the Sum and Average of numbers
            var sum = numbers.Sum();
            var ave = numbers.Average();
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + ave);
            Console.WriteLine("------------------------------");
            //Order numbers in ascending order and decsending order. Print each to console.
            var ascend = numbers.OrderBy(x => x);
            var descend = numbers.OrderByDescending(x => x);

            Console.WriteLine("Ascending");

            foreach (var i in ascend)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("Descending");

            foreach (var i in descend)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine("------------------------------");

            //Print to the console only the numbers greater than 6
            Console.WriteLine("Greater than 6");

            var greatVI = numbers.Where(x => x > 6);
            foreach (var i in greatVI)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------------------------------");

            //Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            var acsendIV = numbers.Where(x => x > 4 && x < 9).OrderBy(x => x);
            Console.WriteLine("Acsending 4");
            foreach (var i in acsendIV)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------------------------------");

            //Change the value at index 4 to your age, then print the numbers in decsending order
            var age = numbers[4] = 22;
            Console.WriteLine("Spot 4 is age");
            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------------------------------");

            // List of employees ***Do not remove this***
            var employees = CreateEmployees();

            //Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S.
            //Order this in acesnding order by FirstName.
            
            foreach (var i in employees.Where(x => x.FirstName.StartsWith('C') || x.FirstName.StartsWith('S')).OrderBy(x => x.FirstName))
            {
                Console.WriteLine(i.FullName);
            }
            Console.WriteLine("------------------------------");

            //Print all the employees' FullName and Age who are over the age 26 to the console.
            //Order this by Age first and then by FirstName in the same result.

            foreach (var i in employees.Where(x => x.Age > 26 ).OrderBy(x => x.Age).ThenBy(x=> x.FirstName))
            {
                Console.WriteLine(i.Age +" "+ i.FirstName);
            }
            Console.WriteLine("------------------------------");

            //Print the Sum and then the Average of the employees' YearsOfExperience
            //if their YOE is less than or equal to 10 AND Age is greater than 35
            Console.WriteLine(employees.Where(x => x.Age > 35 && x.YearsOfExperience <= 10).Sum(x => x.YearsOfExperience));
            Console.WriteLine(employees.Where(x => x.Age > 35 && x.YearsOfExperience <= 10).Average(x => x.YearsOfExperience));

            Console.WriteLine("------------------------------");


            //Add an employee to the end of the list without using employees.Add()
            employees.Append(new Employee() { FirstName = "Nick", YearsOfExperience = 3, Age = 22, LastName = "Stockton" });



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
