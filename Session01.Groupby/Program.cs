using System;
using System.Collections.Generic;
using System.Linq;

namespace Session01.Groupby
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons =new List<Person>(){
                new Person {
                    FirstName="mohammd",
                    LastName="lotfi",
                    Email="lotfi@gmaiul.com"
                },new Person
                {
                    FirstName = "ali",
                    LastName = "lotfi",
                    Email = "ali@gmail.com"
                },new Person
                {
                    FirstName = "ali",
                    LastName = "karimi",
                    Email = "ali2@gmail.com"
                },new Person
                {
                    FirstName = "amir",
                    LastName = "karimi",
                    Email = "amir.karimi@gmail.com"
                }
            };


            var result = persons.GroupBy(c=>c.LastName);

            foreach (var item in result)
            {
                foreach (var i in item)
                {
                    Console.WriteLine($"item {item.Key} -> {i.FirstName} ->{i.LastName}");

                }
                Console.WriteLine($"item {item.Key} -> {item.Count()}" );
                    
            }
            Console.ReadKey();
        }
    }
}
