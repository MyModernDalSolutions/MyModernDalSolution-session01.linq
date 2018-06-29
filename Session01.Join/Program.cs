using System;
using System.Collections.Generic;
using System.Linq;

namespace Session01.Join
{
    class Program
    {
        static List<Person> Students = new List<Person>();
        static List<Person> Masters = new List<Person>();
        static List<Course> Courses = new List<Course>();

        static void Main(string[] args)
        {
            InitialList();
            var join = Courses.Join(Masters, c => c.MasterId, m => m.id, (c, m) => 
            {
                return new { c.Name, m.FirstName ,m.LastName };
            });
            foreach (var item in join)
            {
                Console.WriteLine($"{item.Name} {item.FirstName} {item.LastName}");
            }
            Console.ReadLine();
        }

        private static void InitialList()
        {
            for (int i = 0; i < 10; i++)
            {
                Students.Add(new Person { id = i, FirstName = $"SFNAME-{i}", LastName = $"SLNAME-{i}" });
            }
            for (int i = 0; i < 3; i++)
            {
                Masters.Add(new Person { id = i, FirstName = $"MFNE-{i}", LastName = $"MLN-{i}" });
            }

            Courses.Add(new Course
            {
                Name = "C1",
                MasterId = Masters[0].id,
                StudentsId = Students.Select(c => c.id).Take(30).ToList()
            });

            Courses.Add(new Course
            {
                Name = "C2",
                MasterId = Masters[1].id,
                StudentsId = Students.Select(c => c.id).Skip(20).Take(30).ToList()
            });

            Courses.Add(new Course
            {
                Name = "C3",
                MasterId = Masters[2].id,
                StudentsId = Students.Select(c => c.id).Skip(50).Take(30).ToList()
            });
        }
    }
}
