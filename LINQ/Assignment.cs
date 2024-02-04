/*
* Name: [YOUR NAME HERE]
* South Hills Username: [YOUR SOUTH HILLS USERNAME HERE]
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public class Assignment
    {
        private static readonly List<Student> students = DummyData.GenerateStudents();
        private static readonly List<Teacher> teachers = DummyData.GenerateTeachers();
        private static readonly List<Class> classes = DummyData.GenerateClasses(teachers, students);

        public static void Run()
        {
            //(1 pt)
            Console.WriteLine($"Teacher paid the most: {GetTeacherPaidTheMost()}");

            //(1 pt)
            Console.WriteLine($"Oldest student: {GetOldestStudent()}");

            //(2 pts)
            const float gpaTarget = 3.4f;
            Console.WriteLine($"Oldest student: {GetStudentsWithGPAOver(gpaTarget)}");

            //(2 pts)
            Class targetClass = classes.Where(x => x.Department == Department.ComputerScience).First();
            Console.WriteLine($"Highest GPA student in class {targetClass.ClassName}: {GetHighestGPAStudentInClass(targetClass)}");

            //(3 pts)
            const Department deptTarget = Department.ComputerScience;
            const int numOfStudentsTarget = 11;
            Console.WriteLine($"Classes with over {numOfStudentsTarget} students in {deptTarget}: " +
                $"{Program.StringifyList(GetClassesInDepartmentWithOverXStudents(deptTarget, numOfStudentsTarget))}");

            //(3 pts)
            const Department deptTarget2 = Department.English;
            Console.WriteLine($"Highest GPA student in department {deptTarget2}: {GetHighestGPAStudentInDepartment(deptTarget2)}");
        }

        //Return the teacher that is being paid the most
        private static Teacher GetTeacherPaidTheMost()
        {
            //TODO
            return null;
        }

        //Return the oldest student
        private static Student GetOldestStudent()
        {
            //TODO
            return null;
        }

        //Return a list of students with a GPA over the target
        private static List<Student> GetStudentsWithGPAOver(float gpa)
        {
            //TODO
            return null;
        }

        //Return the student with the highest GPA in the target class
        private static Student GetHighestGPAStudentInClass(Class targetClass)
        {
            //TODO
            return null;
        }

        //Return a list of classes in the target department with at least (>=) the target number of students
        private static List<Class> GetClassesInDepartmentWithOverXStudents(Department dept, int minNumOfStudents)
        {
            //TODO
            return null;
        }

        //Returns the student with the highest GPA considering all classes in a department
        private static Student GetHighestGPAStudentInDepartment(Department targetDept)
        {
            //TODO
            return null;
        }
    }
}
