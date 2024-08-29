using System;
using System.Globalization;
using System.Collections.Generic;
using InheritanceExercise.Entities;

namespace InheritanceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>();
            
            Console.Write("Enter the number of Employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1;i <= n; i++) {
                Console.WriteLine($"Employee #{i} Data");
                Console.Write("Outsourced? (y/n) ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Worked Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y') {
                    Console.Write("Additional Charge: ");
                    double addtionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    employeeList.Add(new OutsourcedEmployee(name, hours, valuePerHour, addtionalCharge));
                }
                else
                {
                    employeeList.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Payments: ");
            foreach (Employee emp in employeeList)
            {
                Console.Write(emp.Name + ": $" + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine();
            }
        }
    }
}