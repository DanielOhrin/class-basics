using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company Microsoft = new Company("Microsoft", new DateTime(22, 11, 21));
            // Create three employees
            List<Employee> MicrosoftEmployees = new List<Employee> {
                new Employee() {
                    First = "Jane",
                    Last = "Doe",
                    Title = "Senior Developer",
                    StartDate = new DateTime(2022, 11, 19)
                    },
                new Employee() {
                    First = "Daniel",
                    Last = "Ohrin",
                    Title = "Junior Developer",
                    StartDate = new DateTime(2022, 11, 21)
                },
                new Employee() {
                    First = "John",
                    Last = "Doe",
                    Title = "Network Manager",
                    StartDate = new DateTime(2022, 11, 20)
                }
            };
            // Assign the employees to the company
            Microsoft.Employees = MicrosoftEmployees;
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            Microsoft.ListEmployees();
        }
    }
}
