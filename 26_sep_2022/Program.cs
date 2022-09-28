using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _26_sep_2022
{
    internal class Program
    {


        public class Course
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public int Fees { get; set; }

            public Student[] Students { get; set; }
        }



        public class Student
        {
            public string Sname { get; set; }

            public string City { get; set; }

        }


        public class Course_
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public int Fees { get; set; }

            public ArrayList Students_ { get; set; }
        }

        public class Student_
        {
            public string Sname { get; set; }

            public string City { get; set; }

        }







        static void Main(string[] args)
        {
            Student[] stud1 = new Student[]
            {
                new Student{Sname  = "Rahul", City = "Pune" },
                new Student{Sname = "Rohan", City = "Mumbai"}

            };

            Student[] stud2 = new Student[]
            {
                new Student{Sname  = "Abhay", City = "Kullu" },
                new Student{Sname = "Rakesh", City = "Mumbai"}

            };

            Student[] stud3 = new Student[]
            {
                new Student{Sname  = "Aniket", City = "Pune" },
                new Student{Sname = "Rishav", City = "Mysore"}


            };


            Course[] courses = new Course[]
            {
                new Course{Id = 1, Name = "C#", Fees=20000,Students=stud1 },
                new Course{Id=2,Name="Angular",Fees=20000,Students=stud2 },
                new Course{Id=3,Name="MVC",Fees=20000,Students=stud3 }

            };

            foreach (Course c in courses)
            {
                Console.WriteLine($"{c.Id} {c.Name}  {c.Fees}");

                foreach (Student s in c.Students)
                {
                    Console.WriteLine($"\t {s.Sname} -> {s.City}");

                }
            }



            ArrayList std_1 = new ArrayList();
            std_1.Add(new Student_ { Sname = "Abhay", City = "Gurgaon" });
            std_1.Add(new Student_ { Sname = "Akarsh", City = "Rameshwaram" });

            ArrayList std_2 = new ArrayList();
            std_2.Add(new Student_ { Sname = "Hitesh", City = "Noida" });
            std_2.Add(new Student_ { Sname = "Suresh", City = "Sawalpur" });

            ArrayList std_3 = new ArrayList();
            std_3.Add(new Student_ { Sname = "Faisal", City = "Chandigarh" });
            std_3.Add(new Student_ { Sname = "Aman", City = "Kharar" });

            ArrayList courses_ = new ArrayList();
            courses_.Add(new Course_ { Id = 01, Name = "MVC", Fees  = 10000, Students_ = std_1 });
            courses_.Add(new Course_ { Id = 02, Name = "JAVA", Fees = 14000, Students_ = std_2 });
            courses_.Add(new Course_ { Id = 03, Name = "C#", Fees = 15000, Students_ = std_3 });


            foreach (Course_ c in courses_)
            {
                Console.WriteLine($" {c.Id}   {c.Name}");
                foreach (Student_ s in c.Students_)
                {
                    Console.WriteLine($"\t {s.Sname} {s.City}");
                }
            }








                Employee[] emp1 = new Employee[]
            {
                new Employee{Empid = 20, Empname = "Rajesh" },
                new Employee{Empid = 21, Empname = "Ramesh" }
            };

            Employee[] emp2 = new Employee[]
            {
                new Employee{Empid = 22, Empname = "Rishav" },
                new Employee{Empid = 23, Empname = "Jitesh" }
            };

            Employee[] emp3 = new Employee[]
            {
                new Employee{Empid = 24, Empname = "Rahul" },
                new Employee{Empid = 25, Empname = "Riya" }
            };



            //Department[] depts = new Department[]
            //{
            //    new Department{Deptcode = 01, Deptname = "Marketing", emps = emp1},
            //    new Department{Deptcode = 02, Deptname = "Development", emps = emp2},
            //    new Department{Deptcode = 03, Deptname = "Recruitment", emps = emp3},

            //};


            /// Department Programs
            //Console.WriteLine("----------------");

            //foreach (Department d in depts)
            //{
            //    Console.WriteLine($" {d.Deptcode}   {d.Deptname}");
            //    foreach (Employee e in d.emps)
            //    {
            //        Console.WriteLine($"\t {e.Empid} {e.Empname}");
            //    }

            //}







            ArrayList emp_1 = new ArrayList();
            emp_1.Add(new Employee_ { Empid = 20, Empname = "Rajesh" });
            emp_1.Add(new Employee_ { Empid = 21, Empname = "Ramesh" });

            ArrayList emp_2 = new ArrayList();
            emp_2.Add(new Employee_ { Empid = 22, Empname = "Rahuljesh" });
            emp_2.Add(new Employee_ { Empid = 23, Empname = "Ram" });

            ArrayList emp_3 = new ArrayList();
            emp_3.Add(new Employee_ { Empid = 24, Empname = "Rajeshwar" });
            emp_3.Add(new Employee_ { Empid = 25, Empname = "Rameshwar" });

            ArrayList depts_ = new ArrayList();
            depts_.Add(new Department_ { Deptcode = 01, Deptname = "Marketing", emps = emp_1 });
            depts_.Add(new Department_ { Deptcode = 02, Deptname = "Development", emps = emp_2 });
            depts_.Add(new Department_ { Deptcode = 03, Deptname = "Recruitment", emps = emp_3 });


            //foreach (Department_ d in depts_)
            //{
            //    Console.WriteLine($" {d.Deptcode}   {d.Deptname}");
            //    foreach (Employee e in d.emps)
            //    {
            //        Console.WriteLine($"\t {e.Empid} {e.Empname}");
            //    }

            //}



















        }
    }
}
