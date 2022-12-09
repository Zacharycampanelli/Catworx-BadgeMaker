using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        
        async static Task Main(string[] args)
        {
            ConsoleKey res;
            // Code to get employees
            Console.WriteLine("Welcome to CatWorx!");
            Console.WriteLine("Do you want the API to randomly generate employees (y for yes, any other key to manually enter employees)");
            res = Console.ReadKey(false).Key;
            if (res != ConsoleKey.Y)
            {
                List<Employee> employees = await PeopleFetcher.GetEmployees();
                Util.PrintEmployees(employees);
                Util.MakeCSV(employees);
                await Util.MakeBadges(employees);
            }
            else 
            {
                List<Employee> employees = await PeopleFetcher.GetFromApi();
                Util.PrintEmployees(employees);
                Util.MakeCSV(employees);
                await Util.MakeBadges(employees);
            }
        }
    }
}