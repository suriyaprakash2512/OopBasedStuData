using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppOopBasedStudentData
{
    internal class Program
    {
        static List<Student> students = new List<Student>();
        static List<Teacher> teachers = new List<Teacher>();
        static List<Subject> subjects = new List<Subject>();
        public static void AddData()
        {
            students.Add(new Student("arjun", "8th"));
            students.Add(new Student("suresh", "9th"));
            students.Add(new Student("Smith", "12th"));
            students.Add(new Student("Rajkumar", "11th"));
            students.Add(new Student("karthick", "8th"));
            students.Add(new Student("Kumar", "11th"));
            students.Add(new Student("Gill", "10th"));
            students.Add(new Student("vasanth", "12th"));
            students.Add(new Student("Deepa", "9th"));
            students.Add(new Student("Anand", "8th"));
            students.Add(new Student("Harini", "12th"));
            students.Add(new Student("Sundari", "6th"));
            students.Add(new Student("Vijay", "9th"));
            students.Add(new Student("Priya", "11th"));
            students.Add(new Student("AJith", "8th"));
            students.Add(new Student("Saranya", "11th"));
            students.Add(new Student("Krishna", "10th"));
            students.Add(new Student("Manikandan", "12th"));
            students.Add(new Student("Sureshkrishna", "9th"));
            students.Add(new Student("Amutha", "8th"));
            teachers.Add(new Teacher("Mr. Arun", "10th"));
            teachers.Add(new Teacher("Mrs. Selvi", "11th"));
            teachers.Add(new Teacher("Mr. Tharun", "12th"));
            teachers.Add(new Teacher("Ms. Priya", "10th"));
            teachers.Add(new Teacher("Mr. Rajesh", "8th"));
            subjects.Add(new Subject("Biology", 101, "Mr. Arun"));
            subjects.Add(new Subject("Physics", 102, "Mrs. Selvi"));
            subjects.Add(new Subject("Tamil", 103, "Mr. Tharun"));
            subjects.Add(new Subject("English", 104, "Ms. Priya"));
            subjects.Add(new Subject("Biology", 105, "Mr. Rajesh"));
            subjects.Add(new Subject("Computer Science", 106, "Mr. Arun"));
            subjects.Add(new Subject("Economics", 107, "Mrs. Selvi"));
            subjects.Add(new Subject("Social", 108, "Mr. Tharun"));
            subjects.Add(new Subject("Geography", 109, "Ms. Priya"));
            subjects.Add(new Subject("Environmental Science", 110, "Mr. Rajesh"));
        }
        public static void DisplayStudents()
        {
            foreach (var student in students)
            {
                Console.WriteLine($"Student Name : {student.Name}, Class : {student.Section} ");
            }
        }
        public static void DisplayTeachers()
        {
            foreach (var teacher in teachers)
            {
                Console.WriteLine($"Teacher Name : {teacher.Name}, Class : {teacher.Section}");
            }
        }
        public static void DisplaySubjects()
        {
            foreach (var subject in subjects)
            {
                Console.WriteLine($"Subject Name : {subject.SubName}, Subject Code : {subject.SubCode}, Teacher Name : {subject.Teacher} ");
            }
        }
        public static void StudentsInClass(string cl)
        {
            int count = 0;
            foreach (var student in students)
            {
                if (student.Section.Equals(cl))
                {
                    count++;
                    Console.WriteLine($"Student Name : {student.Name}, Class : {student.Section} ");
                }
            }
            if (count == 0)
                Console.WriteLine("There is no such class or You mush have entered the wrong class");
        }
        public static void SubjectsTaughtByTeacher(string name)
        {
            int count = 0;
            Console.WriteLine($"\nSubject taught by {name}\n");
            foreach (var subject in subjects)
            {
                if (subject.Teacher.Equals(name))
                {
                    count++;
                    Console.WriteLine($"Subject Name : {subject.SubName}, Subject Code: {subject.SubCode}");
                }
            }
            if (count == 0)
                Console.WriteLine("There is no such teacher or You must have entered the wrong name");
        }
        static void Main(string[] args)
        {
            try
            {
                AddData();
                Console.WriteLine("Choose one option to Perform\n\n1. Display All Data\n2.Display Students in Specific Class\n3.Display Subject taught by Specific Teacher\n\nEnter the Function number");

            Again:
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        {
                            Console.WriteLine("The List of Students\n");
                            DisplayStudents();
                            Console.WriteLine("\nThe List of Teachers\n");
                            DisplayTeachers();
                            Console.WriteLine("\nThe List of Subjects\n");
                            DisplaySubjects();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("\nEnter the Class");
                            string input = Console.ReadLine();
                            Console.WriteLine($"\nThe List of Students in Class {input}\n");
                            StudentsInClass(input);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter Teacher Name");
                            string input = Console.ReadLine();
                            SubjectsTaughtByTeacher(input);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Oops!!!\n Wrong Option\nSelect Again");
                            goto Again;
                        }
                       
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }

    }
}
