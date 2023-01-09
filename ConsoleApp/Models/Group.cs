using ConsoleApp.Enums;
using ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Group
    {
        public int No { get; set; }
        public GroupCategory Category { get; set; }
       
        public Student[] students { get; set; } 
        
        public Group(GroupCategory category,int no)
        {
           Category=category;
            this.No=no;
           
        }
        public Group(string Name, string Surname,int no)
        { 
           Student student = new(Name,Surname);
           No = no;
        }

        




       
    }



}

