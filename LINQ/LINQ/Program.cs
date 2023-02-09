using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace LINQ
{
    public class Program
    {
        private static readonly String[] strNumArr = { "5", "1", "2", "3", "50" };
        private static readonly List<Student> students = DummyData.GenerateStudents();
        private static readonly List<Teacher> teachers = DummyData.GenerateTeachers();
        private static List<Person> people = null!;
        private static readonly List<Class> classes = DummyData.GenerateClasses(teachers, students);

        public static void Main()
        {

            //You can delete the Break call to Debugger when working on your assignment.
            Debugger.Break();
            Console.Clear();
            Assignment.Run();
        }

        /*private static void PrintStudents() => students.ForEach(x => Console.WriteLine(x));
        private static void PrintTeachers() => teachers.ForEach(x => Console.WriteLine(x));
        private static void PrintClasses() => classes.ForEach(x => Console.WriteLine(x));*/
        public static void PrintList<T>(List<T> list)
        {
            
        }

        public static String StringifyList<T>(List<T> list)
        {
            return null;
        }

        private static List<Teacher> GetTeachersFromPeopleList()
        {
            return null;
        }

        private static Student GetStudentWithHighestGPA()
        {
            return null;
        }

        private static List<Student> GetStudentsWithName(String name)
        {
            return null;
        }

        private static Teacher GetTeacherTeachingTheMost()
        {
            return null;
        }

        private static List<Student> GetStudentsTakingClassInDept(Department dept)
        {
            return null;
        }
    }
}