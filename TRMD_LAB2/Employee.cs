﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMD_LAB2
{
    public  class Employee
    {
        public decimal Salary { get; set; }
        public static Employee operator +(Employee emp, decimal premium)
        {
            return new Employee { Salary = emp.Salary + premium};
        }
    }
}
