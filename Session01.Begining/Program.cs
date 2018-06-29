using System;
using System.Collections.Generic;

namespace Session01.Begining
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>() {
                new Person{FirstName="mohammad",LastName="lotfi" },
                new Person{ FirstName="ali",LastName="mirani" },
                new Person{ FirstName="mahan",LastName="lotfi" },
            };
            var res = people.Where2(c => c.LastName.Contains("o"));
            foreach (var item in res)
            {
                Console.WriteLine($"wow ... {item.FirstName} . {item.LastName}");
            }
            Console.ReadKey();
        }
    }
}
