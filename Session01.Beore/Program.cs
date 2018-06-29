using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Session01.Beore
{
    public static class MyLinq
    {
        public static int  MyCount<T>(this IEnumerable<T> input)
        {
            return input.Count();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> s = new List<string>();
            //s.Add("");
            //Dictionary<string, string> d = new Dictionary<string, string>();
            //d.MyCount();
            //Console.WriteLine(s.MyCount());
            ////ShowDirectoryWhgithoutLinq(@"c:\windows");
            //ShowDirectoryWhitLinq(@"c:\windows");


            List<Person> people = new List<Person>() {
                new Person{FirstName="mohammad",LastName="lotfi" },
                new Person{ FirstName="ali",LastName="mirani" },
                new Person{ FirstName="mahan",LastName="lotfi" },
            };

            #region Use Linq with named method function
            var res = people.Where(SelectPerson); 
            foreach (var item in res)
            {
                Console.WriteLine(item.FirstName +" -> "+item.LastName);
            }
            #endregion

            #region Use Linq with anonymouce methods
            var res2 = people.Where(delegate (Person person)
            {
                return person.LastName.Contains("o");
            });
            #endregion

            #region Use linq with Loambda Expression 
            var res3 = people.Where(input => input.LastName.Contains("o")); 
            #endregion



            Console.ReadKey();
        }

        private static bool SelectPerson(Person person)
        {
            return person.LastName.Contains("o");
        }

        private static void ShowDirectoryWhitLinq(string v)
        {
            DirectoryInfo df = new DirectoryInfo(v);

            var result = df.GetFiles().OrderBy(c=>c.Length);
            foreach (var item in result)
            {
                Console.WriteLine($"Name : {item.Name} -> {item.Length}");
            }

        }

        private static void ShowDirectoryWhgithoutLinq(string v)
        {
            DirectoryInfo df = new DirectoryInfo(v);
            var file = df.GetFiles();
            Array.Sort(file,new FileInfoComparer());
            foreach (var item in file)
            {
                Console.WriteLine($"{item.Name} , {item.Length}");
            }
        }
    }
}
