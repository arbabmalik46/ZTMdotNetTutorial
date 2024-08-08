using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CalculationEngine;

namespace ZTMdotNetTutorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Arbab", "Malik");

            #region Commented Code
            //you can add args value in Properties of project=>Debug section and add args param value
            //Console.WriteLine(args[0]);
            //TO Take input from user
            //string? name = Console.ReadLine();
            //Student s = new Student();
            //Student.Member = "Toyota";
            //s.getCarModel();
            //s.Gender();
            //Console.WriteLine(s.getspeed());
            //A a = new A("Atbab");
            //a.fullName();
            //B b = new B("Hamza");
            //b.GetName();
            //var person = new Person("Arbab","Malik");
            //MessageProvidor message = new MessageProvidor();
            //message.WriteMessage();
            #endregion

            #region University Class
            List<University> universities = new List<University>();
            University u1 = new University
            {
                Courses = 4,
                DepartmentID = 1,
                DepartmentName = "Software Engineering",
                Fees = 1200.34f
            };
            University u2 = new University
            {
                Courses = 5,
                DepartmentID = 2,
                DepartmentName = "Mechanical Engineering",
                Fees = 1100.4f
            };
            University u3 = new University
            {
                Courses = 10,
                DepartmentID = 3,
                DepartmentName = "Civil Engineering",
                Fees = 1500.12f
            };
            University u4 = new University
            {
                Courses = 34,
                DepartmentID = 4,
                DepartmentName = "Electrical Engineering",
                Fees = 1400.23f
            };
            University u5 = new University
            {
                Courses = 24,
                DepartmentID = 5,
                DepartmentName = "Electronics Engineering",
                Fees = 1900.23f
            };
            universities.Add(u1);
            universities.Add(u2);
            universities.Add(u3);
            universities.Add(u4);
            universities.Add(u5);

            var topUniversity = universities.Where(x => x.Fees > 1500.23f).Select(x => x.DepartmentName);
            foreach (var VARIABLE in topUniversity)
            {
                Console.WriteLine(VARIABLE);
            }
            #endregion


        }
    }
    public record Person(string name, string lname);
}