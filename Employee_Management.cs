using System;


    class Employee_Management
    {
        // Static variable shared by all employees
        private static string CompanyName = "TechCorp";
        private static int totalEmployees = 0;

        // Readonly variable (cannot be modified after initialization)
        public readonly int Id;
        public string Name;
        public string Designation;

        // Constructor using 'this' keyword to initialize attributes
        public Employee_Management(string Name, int Id, string Designation)
        {
            this.Name = Name;
            this.Id = Id; // Readonly variable can only be assigned here
            this.Designation = Designation;
            totalEmployees++; // Increment total employee count
        }

        // Static method to display total number of employees
        public static void DisplayTotalEmployees()
        {
            Console.WriteLine("Total Employees: " + totalEmployees);
        }

        // Method to display employee details (checks instance using 'is' operator)
        public void DisplayEmployeeDetails()
        {
            if (this is Employee_Management)  // Corrected check
            {
                Console.WriteLine("Company: " + CompanyName);
                Console.WriteLine("Employee Name: " + Name);
                Console.WriteLine("Employee ID: " + Id);
                Console.WriteLine("Designation: " + Designation);
            }
            else
            {
                Console.WriteLine("Invalid employee object.");
            }
        }
    }

    class Program  // Changed from Employee to Program for clarity
    {
        static void Main()
        {
            // Creating Employee objects
            Employee_Management emp1 = new Employee_Management("Alice Johnson", 101, "Software Engineer");
            Employee_Management emp2 = new Employee_Management("Bob Smith", 102, "Project Manager");

            // Display employee details
            emp1.DisplayEmployeeDetails();
            Console.WriteLine();
            emp2.DisplayEmployeeDetails();
            Console.WriteLine();

            // Display total employees
            Employee_Management.DisplayTotalEmployees();
        }
    }


