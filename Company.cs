using System;
using System.Collections.Generic;

namespace classes_employees
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }
    public List<Employee> employeePeople = new List<Employee>();
    

        // Create a public property for holding a list of current employees
        /*
        
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company(string title, DateTime Creation){
            this.Name = title;
            this.CreatedOn = Creation;
        }

        public void addEmployee(Employee person){
                employeePeople.Add(person);
    }
}
}
