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
            //TODO
            
            Console.Clear();
            Assignment.Run();
        }

        public static void PrintList<T>(List<T> list) => list.ForEach(x => Console.WriteLine(x));
        public static String StringifyList<T>(List<T> list) => String.Join("\n", list);

        private static List<Teacher> GetTeachersFromPeopleList()
        {
            //TODO
            return null;
        }

        private static Student GetStudentWithHighestGPA()
        {
            //TODO
            return null;
        }

        private static List<Student> GetStudentsWithName(String name)
        {
            //TODO
            return null;
        }

        private static Teacher GetTeacherTeachingTheMost()
        {
            //TODO
            return null;
        }

        private static List<Student> GetStudentsTakingClassInDept(Department dept)
        {
            //TODO
            return null;
        }
    }
}