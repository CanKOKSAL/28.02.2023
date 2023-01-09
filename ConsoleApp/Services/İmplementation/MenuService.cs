using ConsoleApp.Enums;
using ConsoleApp.Models;
using ConsoleApp.Services.İnterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Services.İmplementation
{
    internal static class MenuService
    {
        private static CourseService CourseService = new();
    
    
        public static void CreateGroup()
        {
            up:
            Console.WriteLine("Please Write Category No");
            int.TryParse(Console.ReadLine(), out int no);
            Console.WriteLine("Please Choose Category");
            foreach (var item in Enum.GetValues(typeof(GroupCategory)))
            {
                Console.WriteLine($"{(int)item}.{item}");
            }
            int.TryParse(Console.ReadLine(), out int categoryName);
            if(categoryName<0)
            {
                goto up;
            }
           
            
            string result=CourseService.CreateGroup((GroupCategory)categoryName,no);
            Console.WriteLine(result);
        }

        public static void EditGroup()
        {
            Console.WriteLine("Please add Group Name");
            string Number = Console.ReadLine();
        
        up:
            Console.WriteLine("Please Write Category No");
            int.TryParse(Console.ReadLine(), out int no);
            Console.WriteLine("Please Choose Category");
            foreach (var item in Enum.GetValues(typeof(GroupCategory)))
            {
                Console.WriteLine($"{(int)item}.{item}");
            }
           
            
            int.TryParse(Console.ReadLine(), out int categoryName);
            
            
             if (categoryName < 0)
            {
                goto up;
            }


            string result = CourseService.CreateGroup((GroupCategory)categoryName, no);
            Console.WriteLine(result);
        }
        public static void CreateStudent()
        {
            Console.WriteLine("Please Write Name");
            Console.ReadLine() ;
            Console.WriteLine("Please Write Surname");
            Console.ReadLine();
            foreach (var item in Students)
            {

            }
        }
    }
}
