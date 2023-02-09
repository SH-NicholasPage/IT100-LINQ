using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Student : Person
    {
        public const float HONOR_GPA = 3.5f;
        public float GPA { get; set; }

        public Student(string firstName, string lastName, int age, float GPA)
            : base(firstName, lastName, age) => this.GPA = GPA;

        public bool IsHonorStudent() => GPA >= HONOR_GPA;

        public override String ToString() => base.ToString() + $" and has a GPA of {GPA:F2}";
    }
}
