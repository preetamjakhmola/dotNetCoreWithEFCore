using System;
using System.Collections.Generic;

namespace dotNetTutorial.DbModels
{
    public partial class StudentMaster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Batch { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }
}
