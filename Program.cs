using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        

        async static  Task Main(string[] args)
        {
            // Code to get employees
            // List<Employee> employees = GetEmployees();
            
            List<Employee> employees = await PeopleFetcher.GetFromApi();
            Util.PrintEmployees(employees);
            Util.MakeCSV(employees);
            await Util.MakeBadges(employees);
            
        }
    }
}