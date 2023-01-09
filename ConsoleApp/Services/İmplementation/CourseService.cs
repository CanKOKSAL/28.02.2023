using ConsoleApp.Enums;
using ConsoleApp.Models;
using ConsoleApp.Services.İnterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp.Services.İmplementation
{
    internal class CourseService : ICourseService
    {
        private List<Student> _students { get; set; } = new List<Student>();
        public List<Student> Students { get { return _students; } }


        public string CreateStudent(string name, string surName, ClassNo classNo)
        {
            foreach (var item in Students)
            {
                if (item.Name == name && item.SurName == surName)
                {
                    Console.WriteLine("This name all ready in system");
                }

            }
            Student student = new Student(name, surName);
            Students.Add(student);

            return $"{student} Student Succesly Created";
        }
        //public string EditStudent(string name, string surName,ClassNo classNo)
        //{
        //        foreach (Student student in Students)
        //        {
        //            if (student.Name.Trim() != name.Trim())
        //            {
        //            student.Name = name;
        //            Students.Equals(Students);
        //            return $"{name}-Name uptated{student.Name}";
        //            }
        //            if (student.SurName.Trim() == surName.Trim()) 
        //            {
        //            student.SurName = surName;
        //            Students.Equals(Students);
        //            return $"{surName}-Name uptated{student.SurName}";
        //            }
        //        if (student.Name == name)
        //        {
        //            Console.WriteLine("Your name still same");
        //        }
        //        if (student.SurName == surName)
        //        {
        //            Console.WriteLine("Your Surname still same");
        //        }
        //            if(IsOnline==false)
        //            {
        //                if (student.ClassNo == classNo)
        //                {
        //                    Students.Equals(Students);
        //                    return $"{classNo}-ClassNo uptated{student.ClassNo}";

        //                }
        //            }
        //        }                 
            
        //}

        private List<Group> _groups { get; set; } = new List<Group>();
        public List<Group> Groups { get { return _groups; } }


        public string CreateGroup(GroupCategory category, int no)
        {
            Group group = new Group(category, no);
            Groups.Add(group);
            return $"{group} Group Succesly Created";
        }
        public string EditGroup(GroupCategory category, int no)
        {
            foreach (Group group in Groups)
            {
                if (group.No.ToString().ToLower().Trim() != no.ToString().ToLower().Trim()) 
                {
                    group.Category = category;
                    Groups.Equals(group);
                    return $"{no}-Group uptated{group.No}";
                }
            }
            return $"Please write valid Group Category";
        }
        public void GetAllStudent(string Name, string SurName, ClassNo classNo, GroupCategory category)
        {
            foreach (Student student in Students)
            {
                Console.WriteLine(Name);
                Console.WriteLine(SurName);
                Console.WriteLine(classNo);
                Console.WriteLine(category);
            }

        }
        public void SeeAllGroup(GroupCategory category)
        {
            foreach(Group group in Groups)
            {
                Console.WriteLine(category);
            }
        }
    }
}
