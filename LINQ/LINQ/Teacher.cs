using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Teacher : Person, IDepartment
    {
        public List<Class> Classes { get; } = new List<Class>();
        public float Salary { get; set; }
        public Department Department { get; set; }

        public Teacher(String firstName, String lastName, int age, float salary, Department department)
            : base(firstName, lastName, age)
        {
            Salary = salary;
            Department = department;
        }
    }
}
