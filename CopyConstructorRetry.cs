
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }
    ~Person()
    {
        Name = string.Empty;
    }
    public override string ToString()
    {
        return $"Name:{Name}";  
    }
}

class Program
{
    static void Main14(string[] args)
    {
        Person[] people = new Person[3];

        for (int i = 0; i < 3; i++) 
        {
            Console.WriteLine($"Enter the name of person {i + 1}:");
            string name = Console.ReadLine();
            people[i] = new Person(name);   
        }
        Console.WriteLine("\n People in the array:");
        foreach(var person in people)
        {
            Console.WriteLine(person.ToString());
        }
    }
}
