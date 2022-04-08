using System;
using System.Collections.Generic;

namespace ConsoleApp79
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            bool choice=true;
            while (choice)
            {
                Console.WriteLine("-------------Menu-----------");
                Console.WriteLine("Secim edin!");
                Console.WriteLine("1. Tələbə əlavə et");
                Console.WriteLine("2. Tələbəyə imtahan əlavə et");
                Console.WriteLine("3. Tələbənin bir imtahan balına bax");
                Console.WriteLine("4. Tələbənin bütün imtahanlarını göstər");
                Console.WriteLine("5. Tələbənin imtahan ortalamasını göstər");
                Console.WriteLine("6. Tələbədən imtahan sil");
                Console.WriteLine("0. Proqramı bitir");
                string command = Console.ReadLine();
                switch (command)
                {
                    case "1":
                        Console.WriteLine("Full Name Daxil edin:");
                        string fullName=Console.ReadLine();
                        Student student = new Student()
                        {
                            FullName = fullName
                        };
                        students.Add(student);
                        break;
                        case "2":
                        examName = StringInput("Exam Name :");
                        double point = DoubleInput("Point :", "Point double olsun :");
                        Student = students.Find(std => std.No == no);
                        if (Student != null)
                            Student.AddExam(examName, point);
                        break;
                        case "3":
                        if (Student != null)
                        {
                            Console.WriteLine($"{no} -nomreli telebenin {examName} -adli imtahan neticesi :");
                            Console.WriteLine(Student.GetExamResult(examName));
                        }
                        break;
                    case "0":
                        choice = false;
                        break;
                    default:
                        break;
                }
                static string StringInput(string message)
                {
                    Console.WriteLine(message);
                    string inputStr = Console.ReadLine();
                    return inputStr;
                }
               
            }
        }
    }
}
