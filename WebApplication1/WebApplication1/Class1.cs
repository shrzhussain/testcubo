﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Class1
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double salary { get; set; }
        public int Age { get; set; }

        public int getAge()
        {
            return 20;
        }

        public string getFullName()
        {
            return "Shiraz Hussain";
        }

        public string getSalary()
        {
            return "20";
        }
        
    }

}