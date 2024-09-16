using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


        

namespace Bai1
    {
        internal class Student
        {
            public int studentID;
            public string fullName;
            public int age;

            public int StudentID { get => studentID; set => studentID = value; }
            public string FullName { get => fullName; set => fullName = value; }
            public int Age
            {
                get => age; set => age = value;
            }

            public Student(int v) { }


            public Student(int studentID, string fullName, int age)
            {
                this.studentID = studentID;
                this.fullName = fullName;
                this.Age = age;
            }

        }
    }

    namespace Bai1
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                List<Student> students = new List<Student>
            {
                new Student(1, "Ngo Gia A  ", 15),
                new Student(2, "Nguyen Manh B", 19),
                new Student(3, "Phan Dang C  ", 16),
                new Student(4, "Le Anh D", 14),
                new Student(5, "Tran Trung Viet H  ", 20)
            };
                Console.WriteLine("-----------------------------------");
                bool exit = false;

                while (!exit)
                {
                    // Hiển thị menu cho người dùng
                    Console.WriteLine("Menu:");
                    Console.WriteLine("1. In danh sach toan bo hoc sinh");
                    Console.WriteLine("2. Tim hoc sinh co tuoi tu 15 đen 18");
                    Console.WriteLine("3. Tim hoc sinh co ten bat đau bang chu 'A'");
                    Console.WriteLine("4. Tinh tong tuoi cua tat ca hoc sinh");
                    Console.WriteLine("5. Tinh hoc sinh co tuoi lon nhat");
                    Console.WriteLine("6. Sap xep danh sach hoc sinh theo tuoi tang dan");
                    Console.WriteLine("0. Thoat");
                    Console.Write("Chon mot tuy chon (0-6): ");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("DS Hoc Vien ");
                            foreach (var student in students)
                            {
                                Console.WriteLine($"ID: {student.studentID}, Ten: {student.fullName}, Tuoi: {student.age}");
                            }
                            break;

                        case 2:
                            Console.WriteLine("\nDS hoc sinh có tuoi tu 15 den 18:");
                            var studentsAge15To18 = students.Where(s => s.Age >= 15 && s.Age <= 18);
                            foreach (var student in studentsAge15To18)
                            {
                                Console.WriteLine($"ID: {student.studentID}, Ten: {student.fullName}, Tuoi: {student.age}");
                            }
                            break;

                        case 3:
                            Console.WriteLine("\nHoc sinh co ten bat dau bang chu \"A\":");
                            var studentsStartWithA = students.Where(s => s.fullName.StartsWith("A"));
                            foreach (var student in studentsStartWithA)
                            {
                                Console.WriteLine($"ID: {student.studentID}, Ten: {student.fullName}, Tuoi: {student.age}");
                            }
                            break;

                        case 4:
                            int totalAge = students.Sum(s => s.age);
                            Console.WriteLine($"\nTong tuoi cua tat ca hoc sinh: {totalAge}");
                            break;

                        case 5:
                            var oldestStudent = students.OrderByDescending(s => s.Age).FirstOrDefault();
                            Console.WriteLine($"\nHoc sinh co tuoi lon nhat: ID: {oldestStudent.studentID}, Ten: {oldestStudent.fullName}, Tuoi: {oldestStudent.age}");
                            break;

                        case 6:
                            Console.WriteLine("\nDS hoc sinh sau khi sap xep theo tuoi tang dan:");
                            var sortedStudents = students.OrderBy(s => s.age);
                            foreach (var student in sortedStudents)
                            {
                                Console.WriteLine($"ID: {student.studentID}, Ten: {student.fullName}, Tuoi: {student.age}");
                            }
                            break;

                        case 0:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Lua chon khong hop le!");
                            break;
                    }
                    Console.WriteLine();
                }







            }
        }
    }