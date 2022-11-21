using System;

namespace Classes
{
    public class Employee
    {
        public string First { get; set; }
        public string Last { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }

        public string FullName()
        {
            return $"{First} {Last}";
        }
    }
}