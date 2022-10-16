using System;
using System.Collections.Generic;

namespace P03.DetailPrinter
{
    class Program
    {
        static void Main()
        {
            var employee = new Employee("Handsome Squidward");

            var manager = new Manager("Mr. Krabs", new List<string> {"Krabsburger recipe"});
            
            var detailsPrinter = new DetailsPrinter(new List<Employee> {employee, manager});
            detailsPrinter.PrintDetails();
        }
    }
}