﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRILL_120_Inheritance
{
    public class Person
    {
        //PROPERTIES OF CLASS 'PERSON'
        public string FirstName { get; set; }
        public string LastName { get; set; }

            public void SayName()
        {
            Console.WriteLine("First Name: " + FirstName); 
            Console.WriteLine("Last Name: " + LastName);

          
        }
        }
    }

