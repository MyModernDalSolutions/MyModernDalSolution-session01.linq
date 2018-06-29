using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Session01.Begining
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>() {
                new Person{FirstName="mohammad",LastName="lotfi" },
                new Person{ FirstName="ali",LastName="mirani" },
                new Person{ FirstName="mahan",LastName="moradi" },
            };
            //Where
            //Defferd(people);

            //Select
            //Projection(people);

            List<Person> result= ReadFromCsvFile(@"c:\import.csv");
            foreach (var item in result)
            {
                Console.WriteLine(item.FirstName+" -> "+item.LastName);
            }

            Console.ReadKey();
        }

        private static List<Person> ReadFromCsvFile(string path)
        {
            List<Person> list = new List<Person>();
            StreamReader streamReader = new StreamReader(path);
            while (!streamReader.EndOfStream)
            {
                var line = streamReader.ReadLine();
                list.Add(new Person
                {
                    FirstName = line.Split(',')[1],
                    LastName = line.Split(',')[2]
                });
            }
            return list;

        }

        private static void Projection(List<Person> people)
        {
            var result = people.Select(c =>
                 new
                 {
                     firs = c.FirstName
                 }
            );
            foreach (var item in result)
            {
                Console.WriteLine($"{item.firs}");
            }
        }


        private static void Defferd(List<Person> people)
        {
            Console.WriteLine("Where2----------------------------------------");
            var res = people.Where2(c => c.LastName.Contains("o"));
            foreach (var item in res)
            {
                Console.WriteLine($"wow ... {item.FirstName} . {item.LastName}");
            }
            Console.WriteLine("MyWhere2----------------------------------------");
            var res2 = people.MyWhere2(c => c.LastName.Contains("o"));
            foreach (var item in res2)
            {
                Console.WriteLine($"wow ... {item.FirstName} . {item.LastName}");
            }
            Console.WriteLine("linq where----------------------------------------");
            var res3 = people.Where(c => c.LastName.Contains("o"));
            foreach (var item in res2)
            {
                Console.WriteLine($"wow ... {item.FirstName} . {item.LastName}");
            }
        }
    }
}
