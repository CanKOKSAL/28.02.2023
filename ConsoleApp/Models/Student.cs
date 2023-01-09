using ConsoleApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    internal class Student
    {
        public ClassNo ClassNo { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public bool IsOnline { get; set; }


        public Student(string name, string Surname)
        {
            Name = name;
            SurName = Surname;
        }


    }
}
