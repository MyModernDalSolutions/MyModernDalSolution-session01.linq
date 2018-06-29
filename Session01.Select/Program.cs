using System;
using System.IO;
using System.Linq;

namespace Session01.Select
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = File.ReadAllLines(@"c:\import.csv").Select(c => {
                var temp = c.Split(',');
                return new Person()
                {
                    FirstName = temp[1],
                    LastName = temp[2],
                    Email = temp[0]
                };
            });
            //order list
            var temp1 = person.OrderBy(c=>c.FirstName);
            foreach (var item in temp1)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} {item.Email}");
            }
            Console.ReadKey();
        }
    }
}
