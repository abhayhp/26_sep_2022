using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_sep_2022
{
    public class Department_
    {
        public int Deptcode { get; set; }

        public string Deptname { get; set; }

        public ArrayList emps { get; set; }

    }


    public class Employee_
    {
        public int Empid { get; set; }
        public string Empname { get; set; }
    }



    public class Department
    {
        public int Deptcode { get; set; }

        public string Deptname { get; set; }

        public Employee[] emps { get; set; }

    }

    public class Employee
    {
        public int Empid { get; set; }
        public string Empname { get; set; }
    }




}
