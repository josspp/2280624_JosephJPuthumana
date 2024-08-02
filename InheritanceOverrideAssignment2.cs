using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1TestJP1
{
    internal class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Name is:{Name}";
        }
    }

    internal class Student : Person
    {
        public Student(string name) : base(name)
        {

        }
        public void Study()
        {
            Console.WriteLine($"{Name} is Study");
        }

    }

    internal class Teacher : Person
    {
        public Teacher(string name) : base(name) 
        {
        }
        public void Explain()
        {
            Console.WriteLine($"{Name} is explaining");
        }


    }

    internal class Program
    {
        public static void Main18(string[] args)
        {
            Person[] people = new Person[3];

            for (int i = 0; i < people.Length; i++) 
            {
                Console.WriteLine($"Enter the name of person {i+1}");
                string name1 =Console.ReadLine();

                if (i == 2)
                {
                    people[i] = new Teacher(name1);
                }
                else
                {
                    people[i]=new Student(name1);
                }

            }

            Console.WriteLine("Output:");
            foreach (Person person in people) 
            {
                if (person is Teacher)
                {
                    Console.WriteLine("Explaining");
                }
                else
                { Console.WriteLine("Studying"); }


            }
           

           
        }
    }

    
}
