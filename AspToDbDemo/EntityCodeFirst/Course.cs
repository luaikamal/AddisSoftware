﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityCodeFirst
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }
    }
}