using System;

class Patient
{
    // Static variable shared among all patients
    private static string HospitalName = "City Hospital";
    private static int totalPatients = 0;

    // Readonly variable to uniquely identify each patient
    public readonly int PatientID;
    public string Name;
    public int Age;
    public string Ailment;

    // Constructor using 'this' keyword to initialize attributes
    public Patient(int patientID, string name, int age, string ailment)
    {
        this.PatientID = patientID; // Readonly variable assigned in constructor
        this.Name = name;
        this.Age = age;
        this.Ailment = ailment;
        totalPatients++; // Increment total patients count
    }

    // Static method to get total number of patients
    public static void GetTotalPatients()
    {
        Console.WriteLine("Total Patients Admitted: " + totalPatients);
    }

    // Method to display patient details (checks instance using 'is' operator)
    public void DisplayPatientDetails()
    {
        if (this is Patient)
        {
            Console.WriteLine("Hospital: " + HospitalName);
            Console.WriteLine("Patient Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Ailment: " + Ailment);
            Console.WriteLine("Patient ID: " + PatientID);
        }
        else
        {
            Console.WriteLine("Invalid patient object.");
        }
    }
}

class Patient_Details
{
    static void Main()
    {
        // Creating Patient objects
        Patient patient1 = new Patient(101, "Rishabh", 22, "Flu");
        Patient patient2 = new Patient(102, "Rishi", 21, "Diabetes");

        // Display patient details
        patient1.DisplayPatientDetails();
        Console.WriteLine("-------------------------");
        patient2.DisplayPatientDetails();
        Console.WriteLine("-------------------------");

        // Display total patients
        Patient.GetTotalPatients();
    }
}
