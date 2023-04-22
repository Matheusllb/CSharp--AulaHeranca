using System;
using System.Collections.Generic;
using System.Globalization;
using ClassHerence.Entities;

namespace ClassHerence
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Register list = new Register();

            int opt = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("<1> Register Person");
                Console.WriteLine("<2> Register Student");
                Console.WriteLine("<3> Register Teacher");
                Console.WriteLine("<4> List of people");
                Console.WriteLine("<5> List of students");
                Console.WriteLine("<6> List of teachers");
                Console.WriteLine("<7> Close");
                Console.Write("Option: ");
                opt = int.Parse(Console.ReadLine());

                while (opt > 7 || opt <= 0)
                {
                    Console.WriteLine("Invalid option!");
                    Console.Write("Press 'Enter' to try again. ");
                    Console.ReadKey();
                    Console.WriteLine("<1> Register Person");
                    Console.WriteLine("<2> Register Student");
                    Console.WriteLine("<3> Register Teacher");
                    Console.WriteLine("<4> Close");
                    Console.Write("Option: ");
                    opt = int.Parse(Console.ReadLine());
                }

                switch (opt)
                {
                    case 1:
                        list.AddPeople();
                        break;
                    case 2:
                        list.AddStudent();
                        break;
                    case 3:
                        list.AddTeacher();
                        break;
                    case 4:
                        list.RunListPeople();
                        if (list.People.Count == 0)
                        {
                            Console.Write("\nNo one person registered...\nPress 'Enter' to return ");
                            Console.ReadKey();
                        }  
                        else Console.WriteLine("\nPress 'Enter' to return");
                        Console.ReadKey();
                        break;
                    case 5:
                        list.RunListStudent();
                        if (list.Students.Count == 0)
                        {
                            Console.Write("\nNo one student registered...\nPress 'Enter' to return ");
                            Console.ReadKey();
                        }
                        else Console.WriteLine("\nPress 'Enter' to return");
                        Console.ReadKey();
                        break;
                    case 6:
                        list.RunListTeacher();
                        if (list.Teachers.Count == 0)
                        {
                            Console.Write("\nNo one teacher registered...\nPress 'Enter' to return ");
                            Console.ReadKey();
                        }
                        else Console.WriteLine("\nPress 'Enter' to return");
                        Console.ReadKey();
                        break;
                    case 7:
                        break;
                }
            } while (opt != 7);
            
        }
    }
}
