namespace Day_5a
{

    class Employee
    {
        public int Id;
        public string EmpName;
        public string EmpEmail;

        public Employee(int id, string Name)
        {
            Id = id;
            EmpName = Name;
        }
        public void PrintEmpData()
        {
            Console.Write(EmpName);
            Console.Write(Id);
        }
    }
    internal class Program
    {
        static void Main11(string[] args)
        {
            Employee employee = new Employee(23, "Anirudh");
            employee.PrintEmpData();
        }
    }
}