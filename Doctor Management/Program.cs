using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DoctorManagementSystem
{
    class Doctor
    {
        public string RegistrationNo { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Specialization { get; set; }
        public string ClinicAddress { get; set; }
        public string ClinicTimings { get; set; }
        public string ContactNo { get; set; }

        public Doctor(string regNo, string name, string city, string specialization, string clinicAddress, string clinicTimings, string contactNo)
        {
            RegistrationNo = regNo;
            Name = name;
            City = city;
            Specialization = specialization;
            ClinicAddress = clinicAddress;
            ClinicTimings = clinicTimings;
            ContactNo = contactNo;
        }

        public override string ToString()
        {
            return $"Registration No: {RegistrationNo}\n" +
                   $"Doctor Name: {Name}\n" +
                   $"City: {City}\n" +
                   $"Specialization: {Specialization}\n" +
                   $"Clinic Address: {ClinicAddress}\n" +
                   $"Clinic Timings: {ClinicTimings}\n" +
                   $"Contact No: {ContactNo}\n";
        }
    }

    class DoctorManagementSystem
    {
        private List<Doctor> doctors = new List<Doctor>();

        public void AddDoctor()
        {
            try
            {
                Console.Write("Enter Registration No (7 digits): ");
                string regNo = Console.ReadLine();
                if (!Regex.IsMatch(regNo, @"^\d{7}$"))
                {
                    throw new ArgumentException("Registration No should be exactly 7 digits long.");
                }

                Console.Write("Enter Doctor Name: ");
                string name = Console.ReadLine();
                if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
                {
                    throw new ArgumentException("Doctor Name should contain only alphabets.");
                }

                Console.Write("Enter City: ");
                string city = Console.ReadLine();
                if (!Regex.IsMatch(city, @"^[a-zA-Z]+$"))
                {
                    throw new ArgumentException("City should contain only alphabets.");
                }

                Console.Write("Enter Area of Specialization: ");
                string specialization = Console.ReadLine();
                if (!Regex.IsMatch(specialization, @"^[a-zA-Z]+$"))
                {
                    throw new ArgumentException("Area of Specialization should contain only alphabets.");
                }

                Console.Write("Enter Clinic Address: ");
                string clinicAddress = Console.ReadLine();

                Console.Write("Enter Clinic Timings: ");
                string clinicTimings = Console.ReadLine();

                Console.Write("Enter Contact No (10 digits): ");
                string contactNo = Console.ReadLine();
                if (!Regex.IsMatch(contactNo, @"^\d{10}$"))
                {
                    throw new ArgumentException("Contact No should be exactly 10 digits long.");
                }

                Doctor doctor = new Doctor(regNo, name, city, specialization, clinicAddress, clinicTimings, contactNo);
                doctors.Add(doctor);
                Console.WriteLine("Doctor added successfully!");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

        public void DisplayDoctors()
        {
            if (doctors.Count == 0)
            {
                Console.WriteLine("No doctors available.");
            }
            else
            {
                foreach (var doctor in doctors)
                {
                    Console.WriteLine(doctor);
                    Console.WriteLine(new string('-', 40));
                }
            }
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\nDoctor Management System");
                Console.WriteLine("1. Add Doctor");
                Console.WriteLine("2. Display Doctors");
                Console.WriteLine("3. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddDoctor();
                        break;
                    case "2":
                        DisplayDoctors();
                        break;
                    case "3":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            DoctorManagementSystem system = new DoctorManagementSystem();
            system.Run();
        }
    }
}