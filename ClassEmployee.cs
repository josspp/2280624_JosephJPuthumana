using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    class Employee
    {
        //fields
        public string EmpID="";
        public string EmpName="";
        public string EmpGender = ""    ;
        
        //Methods
        public void GetData(Employee employee)
        {
            Console.WriteLine("Enter Details below :");
            Console.WriteLine("Enter Emp ID :");
            employee.EmpID=Console.ReadLine();
            Console.WriteLine("Enter Emp Name :");
            employee.EmpName = Console.ReadLine();
            Console.WriteLine("Enter Emp Gender :");
            employee.EmpGender = Console.ReadLine();
        }
    }
    internal class Employeedemo
    {
        public static void Main9()
        {
            
            Employee employee = new Employee();
            employee.GetData(employee);
            Console.WriteLine("Employee details provided are:");
            Console.WriteLine("EmpID:"+employee.EmpID);
            Console.WriteLine("EmpName:"+employee.EmpName);
            Console.WriteLine("EmpGender:"+employee.EmpGender);
            
            //student.RollNo = 101;
            //student.Gender = "Male";
            //student.PrintData(student);


        }
    }
}