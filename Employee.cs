using System;

// Defining a class Employee
public class Employee
{
    private int employeeID;
    protected string department;
    private decimal salary;

    // Parameterized Constructor
    public Employee(int id, string dept, decimal sal)
    {
        employeeID = id;
        department = dept;
        salary = sal;
    }

    // Method to modify salary
    public void ModifySalary(decimal newSalary)
    {
        salary = newSalary;
    }

    // Method to get salary
    public decimal GetSalary()
    {
        return salary;
    }

    // Method to get employee ID (since employeeID is private)
    public int GetEmployeeID()
    {
        return employeeID;
    }
}

public class Manager : Employee
{
    // Parameterized Constructor
    public Manager(int id, string dept, decimal sal) : base(id, dept, sal)
    {
    }

    // Method to display details
    public void DisplayDetails()
    {
        Console.WriteLine(string.Format("Manager ID: {0}", GetEmployeeID()));
        Console.WriteLine(string.Format("Department: {0}", department));
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee(1, "HR", 50000);
        emp.ModifySalary(55000);
        Console.WriteLine(string.Format("Employee Salary: {0}", emp.GetSalary()));

        Manager mgr = new Manager(2, "IT", 70000);
        mgr.DisplayDetails();
    }
}
