﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Person
    {
        //properties when public
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        //fields when private
        private double _salary { get; set; }

        public void setSalary(double salary)
        {
            _salary = salary;
        }

        public double getSalary()
        { 
            return _salary;
        }
        public string getFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public string getFullName(string middleName)
        {
            return $"{FirstName} {middleName} {LastName}";
        }
    }
}
