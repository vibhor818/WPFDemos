﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWpfApp
{
   public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public override string ToString()
        {
            return Age+"    " + Name+   "   "+Address;
        }
    }
}
