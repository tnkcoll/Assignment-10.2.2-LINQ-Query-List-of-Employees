﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_10._2._2_LINQ_Query_List_of_Employees
{
    internal class Employee
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }


        public Employee(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
    }
}
