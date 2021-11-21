using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_4___Collection_Generics___Lukas_R___SUT21
{
    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Gender { get; set; }
        public float Salary { get; set; }
        public Employee(int id, string first, string last, char gender, float salary)
        {
            this.Id = id;
            this.FirstName = first;
            this.LastName = last;
            this.Gender = gender;
            this.Salary = salary;
        }

        public override string ToString()
        {
            return ("ID: " + Id + " - Namn: " + FirstName + " " + LastName + " - Kön: " + Gender + " - Lön: " + Salary);
        }
    }
}
