﻿using System;
using System.Collections.Generic;

namespace dotNetTutorial.DbModels
{
    public partial class EmpMaster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
    }
}
