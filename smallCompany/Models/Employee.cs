﻿using System;
using System.Collections.Generic;
namespace smallCompany.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public ICollection<Assignment> Assignments { get; set; }
    }
}
