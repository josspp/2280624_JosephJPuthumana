using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1TestJP
{
    internal class Person
    {
        public int Age { get; set; }

        public void Greet()
        {
            Console.WriteLine("Greetings..Hello");
        }
        public int SetAge(int age)
        {
            Age = age;
            return Age;

        }
    }

    internal class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I'm studying.");
        }

        public void ShowAge(int age) 
        {
            Console.WriteLine($"My Age is :{age} years old.");
        }
    }

    internal class Teacher : Person
    {
        public void Explain() 
        {
            Console.WriteLine("I'm explaining on the screen.");
        }
    }

    
    internal class StudentProfessorTest
    {
        public static void Main18(string[] args)
        {
            Person person = new Person();
            Console.Write("Person says:");
            person.Greet();

            Student student=new Student();
            student.Age = 15;
            Console.Write("Student says:");
            student.Greet();
            student.ShowAge(student.Age);

            Teacher teacher = new Teacher();
            teacher.SetAge(40);
            Console.Write("Teacher says:");
            teacher.Greet();
            teacher.Explain();

        }
    }


}
