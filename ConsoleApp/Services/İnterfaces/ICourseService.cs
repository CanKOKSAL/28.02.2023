using ConsoleApp.Enums;
using ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp.Services.İnterfaces
{
    internal interface ICourseService
    {
        public List<Student> Students { get; }
        public List<Group> Groups { get; }
        

        public string CreateStudent(string Name, string SurName, ClassNo classNo);
        //public string EditStudent(string Name, string SurName,ClassNo classNo);
        public string CreateGroup(GroupCategory category, int no);
        public string EditGroup(GroupCategory category, int no);
        public void GetAllStudent(string Name,string SurName,ClassNo classNo, GroupCategory category);
        public void SeeAllGroup(GroupCategory category);
        

    }
}
