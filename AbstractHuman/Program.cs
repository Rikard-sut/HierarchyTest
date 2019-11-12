using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHuman
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
            new Student("Rirre", "Skog", "F"),
            new Student("Dan", "Henrikson", "C"),
            new Student("Andy", "Ward", "D"),
            new Student("Anna", "Bok", "A"),
            new Student("Siv", "Laston", "B"),
            new Student("Larry", "Larrysson", "F"),
            new Student("Man", "Manny", "A"),
            new Student("Mark", "Cross", "B"),
            new Student("Anders", "Svensson", "C"),
            new Student("Manny", "Manson", "F")
            };

            List<Worker> workers = new List<Worker>
            {
                new Worker("Jan", "Bengtsson", 4000, 8),
                new Worker("Ande", "Sande", 10000, 10),
                new Worker("Lalle", "Lallesson", 2000, 4, 4),
                new Worker("Bange", "Bangtsson", 5000, 5),
                new Worker("Lars", "Larsson", 6000, 12),
                new Worker("Falle", "Falson", 1000, 1),
                new Worker("Banne", "Banneson", 900, 2, 3),
                new Worker("Fanny", "Fan", 12000, 10),
                new Worker("Fenge", "Fengesson", 4323, 7),
                new Worker("Vd", "Riksomfansson", 16700, 12)
            };

            students.OrderBy(student => student.Grade).Print();

            workers.OrderByDescending(worker => worker.MoneyPerHour()).Print();
            Console.ReadKey();
            Console.WriteLine("Tryck enter för att merga listorna");
            Console.ReadKey();
            Console.Clear();

            List<Human> humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);

            humans.OrderBy(human => human.FirstName).ThenBy(human => human.LastName).Print();
            Console.ReadKey();
        }
    }
}
