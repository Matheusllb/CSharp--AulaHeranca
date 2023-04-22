using System;
using System.Collections.Generic;
using ClassHerence.Entities;

namespace ClassHerence.Entities
{
    public class Register
    {
        public List<Person> People { get; private set; }
        public List<Student> Students { get; private set; }
        public List<Teacher> Teachers { get; private set; }

        public Register() 
        {
            People = new List<Person>();
            Students = new List<Student>();
            Teachers = new List<Teacher>();
        }

        public void AddPeople()
        {
            Console.Clear();
            Console.Write("People\n\nName: ");
            string name = Console.ReadLine();
            Console.Write("Cpf Number: ");
            string cpf = Console.ReadLine();
            Console.Write("Birth Date: ");
            DateTime birth = DateTime.Parse(Console.ReadLine());
            Person p = new(name, cpf, birth);
            People.Add(p);
        }
        
        public void AddStudent()
        {
            Console.Clear();
            Console.Write("Student\n\nName: ");
            string name = Console.ReadLine();
            Console.Write("RA: ");
            string ra = Console.ReadLine();
            Console.Write("Monthy Payment: $ ");
            double pay = double.Parse(Console.ReadLine());
            Console.Write("Cpf Number: ");
            string cpf = Console.ReadLine();
            Console.Write("Birth Date: ");
            DateTime birth = DateTime.Parse(Console.ReadLine());
            Student s = new(name, cpf, birth, ra, pay);
            Students.Add(s);
        }
        
        public void AddTeacher()
        {
            Console.Clear();
            Console.Write("Teacher\n\nName: ");
            string name = Console.ReadLine();
            Console.Write("Functional: ");
            string func = Console.ReadLine();
            Console.Write("Salary: $ ");
            double sal = double.Parse(Console.ReadLine());
            Console.Write("Cpf Number: ");
            string cpf = Console.ReadLine();
            Console.Write("Birth Date: ");
            DateTime birth = DateTime.Parse(Console.ReadLine());
            Teacher t = new(name, cpf, birth, func, sal);
            Teachers.Add(t);
        }

        public void RunListPeople()
        {
            Console.Clear();
            Console.WriteLine("----------People List----------");
            foreach (Person obj in People) 
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("All Registered: " + People.Count());
        }

        public void RunListStudent()
        {
            Console.Clear();
            Console.WriteLine("----------Students List----------");
            foreach (Student obj in Students) 
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("All Registered: " + Students.Count());
        }

        public void RunListTeacher()
        {
            Console.Clear();
            Console.WriteLine("----------Teachers List----------");
            foreach (Teacher obj in Teachers) 
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("All Registered: " + Teachers.Count());
        }

    }
}
