using System;

namespace classes_employees
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company BlackStar = new Company("BlackStar", DateTime.Now);
            // Create three employees

            Employee Sion = new Employee();
            Sion.firstName = "Sion";
            Sion.lastName = "Halfman";
            Sion.Title = "Meidon Leader";
            Sion.StartDate = new DateTime(2012, 07, 02);

            Employee Terrod = new Employee();
            Terrod.firstName = "Terrod";
            Terrod.lastName = "Jackar";
            Terrod.Title = "Captain of the Guard";
            Terrod.StartDate = new DateTime(2013, 04, 02);

            Employee Krom = new Employee();
            Krom.firstName = "Krom";
            Krom.lastName = "StrongHammer";
            Krom.Title = "Smith";
            Krom.StartDate = new DateTime(2013, 07, 02);
            // Assign the employees to the company

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */

            BlackStar.addEmployee(Sion);
            BlackStar.addEmployee(Terrod);
            BlackStar.addEmployee(Krom);

            foreach(Employee person in BlackStar.employeePeople){
                 Console.WriteLine($"{person.firstName} {person.lastName} works for {BlackStar.Name} as {person.Title} and started on {person.StartDate}");
            }
        }
    }
}

