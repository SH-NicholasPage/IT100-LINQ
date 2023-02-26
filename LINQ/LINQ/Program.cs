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
            Console.WriteLine("String array:");
            PrintList(strNumArr.ToList());

            int[] numArray = strNumArr.Select(x => Int32.Parse(x)).OrderBy(x => x).ToArray();

            Console.WriteLine("Number array (sorted):");
            PrintList(numArray.ToList());

            Console.WriteLine("Students:");
            PrintList(students);
            Console.WriteLine("\nTeachers:");
            PrintList(teachers);
            Console.WriteLine("\nClasses:");
            PrintList(classes);

            people = new List<Person>(students.Select(x => x as Person).Concat(teachers));
            Console.WriteLine($"\nTeachers in \"person\" list: {StringifyList(GetTeachersFromPeopleList())}");

            Console.WriteLine($"\nStudent with highest GPA: {GetStudentWithHighestGPA()}");
            const String name = "John";
            Console.WriteLine($"\nStudent with name {name}:\n{StringifyList(GetStudentsWithName(name))}");
            Console.WriteLine($"\nTeacher teaching the most classes: {GetTeacherTeachingTheMost()}");

            const Department deptTarget = Department.ComputerScience;
            Console.WriteLine($"Students taking class in {deptTarget}: {Program.StringifyList(GetStudentsTakingClassInDept(deptTarget))}");

            //You can delete the Break call to Debugger when working on your assignment.
            Debugger.Break();
            Console.Clear();
            Assignment.Run();
        }

        /*private static void PrintStudents() => students.ForEach(x => Console.WriteLine(x));
        private static void PrintTeachers() => teachers.ForEach(x => Console.WriteLine(x));
        private static void PrintClasses() => classes.ForEach(x => Console.WriteLine(x));*/
        public static void PrintList<T>(List<T> list) => list.ForEach(x => Console.WriteLine(x));
        public static String StringifyList<T>(List<T> list) => String.Join("\n", list);

        private static List<Teacher> GetTeachersFromPeopleList()
        {
            return people.Where(x => x.GetType() == typeof(Teacher)).Select(x => x as Teacher).ToList()!;
        }

        private static Student GetStudentWithHighestGPA()
        {
            //return students.OrderBy(x => x.GPA).First();
            //return students.OrderBy(x => x.GPA).Last();
            return students.OrderByDescending(x => x.GPA).First();
        }

        private static List<Student> GetStudentsWithName(String name)
        {
            return students.Where(x => x.FirstName.Contains(name, StringComparison.OrdinalIgnoreCase)
                || x.LastName.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        private static Teacher GetTeacherTeachingTheMost()
        {
            //Look at [4]
            var grouping = classes.GroupBy(x => x.Teacher).ToList();
            var ordered = grouping.OrderByDescending(x => x.Count());
            return classes.GroupBy(x => x.Teacher).OrderByDescending(x => x.Count()).First().Key!;
        }

        private static List<Student> GetStudentsTakingClassInDept(Department dept)
        {
            return classes.Where(x => x.Department == dept).SelectMany(x => x.Students).Distinct().ToList(); ;
        }
    }
}