using System;

namespace Dz9._5
{
    public class Student
    {
        public string Name;
        public double bal;
        public Student(string name, double bal)
        {
            Name = name;
            this.bal = bal;
        }
        public string getName()
        {
            return Name;
        }
        public double getBal()
        {
            return bal;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Avg: {bal}" ;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Student[] students = 
            {
                new Student("James",57),
                new Student("Olivia",63),
                new Student("Alex",84),
                new Student("Sophia",76),
                new Student("Liam",92),
            };
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }

            Console.WriteLine();
            Predicate<Student> student = n => n.getBal() > 75;
            for (int i = 0; i < students.Length; i++)
            {
                if (student(students[i]))
                {
                    Console.WriteLine(students[i]);
                }
            }

            Console.WriteLine();
            student = n => n.getName()[0] == 'A';
            for (int i = 0; i < students.Length; i++)
            {
                if (student(students[i]))
                {
                    Console.WriteLine(students[i]);
                }
            }
        }
    }
}
