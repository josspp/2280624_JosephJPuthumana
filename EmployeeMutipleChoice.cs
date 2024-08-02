using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EmployeeManagement
{
    static int[] employeeIds = new int[100];
    static string[] employeeNames = new string[100];
    static int employeeCount = 0;

    static void Main12(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Update Employee");
            Console.WriteLine("3.Delete Employee");
            Console.WriteLine("4.List Employees");
            Console.WriteLine("5.Exit");
            Console.WriteLine("Enter your choice:");

            int choice=int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    AddEmployee();
                    break;
                case 2:
                    UpdateEmployee();
                    break;
                case 3:
                    //DeleteEmployee();
                    break;
                case 4:
                    ListEmployees();
                    break;
                case 5:
                    return;
                default: 
                    Console.WriteLine("Invalid choice");
                    break;

            }
        }
    }

    static void AddEmployee()
    {
        if(employeeCount>= employeeIds.Length)
        {
            Console.WriteLine("Employee list is full.");
            return;
        }

        Console.WriteLine("Enter employee ID:");
        int id=int.Parse(Console.ReadLine());
        string name=Console.ReadLine();

        employeeIds[employeeCount] = id;
        employeeNames[employeeCount] = name;
        employeeCount++;

        Console.WriteLine("Employee added successfully");
    }

    static void UpdateEmployee()
    {
        Console.WriteLine("Enter employee ID to update:");
        int id = int.Parse(Console.ReadLine());

        for (int i = 0;i < employeeCount; i++)
        {
            if (employeeIds[i]==id)
            {
                Console.WriteLine("Enter new employee name:");
                string name = Console.ReadLine();
                employeeNames[i] = name;
                Console.WriteLine("Employee updated successfully");
                return;
            }
        }
        Console.WriteLine("Employee not found");
    }
    

    static void ListEmployees()
    {
        if(employeeCount==0)
        {
            Console.WriteLine("No employees found");
            return;
        }
        Console.WriteLine("Employee list:");
        for (int i = 0; i < employeeCount; i++)
        {
            Console.WriteLine($"ID: {employeeIds[i]}, Name: {employeeNames[i]}");
        }
    }

}