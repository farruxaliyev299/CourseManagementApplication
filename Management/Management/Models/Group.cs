using System;
using System.Collections.Generic;
using System.Text;

namespace Management.Models
{
    class Group
    {
        public string No;
        public Category Category;
        public bool isOnline;
        public int Limit;
        public List<Student> students;
        public List<Group> groups;
        private static int Bp = 100;
        private static int Bn = 100;
        private static int Dn = 100;

        public Group(Category categories,bool online,int limit)
        {
            switch (categories)
            {   
                case Category.Programming:
                    No = $"BP{Bp++}";
                    break;
                case Category.Design:
                    No = $"BN{Bn++}";
                    break;
                case Category.SystemAdminstration:
                    No = $"DN{Dn++}";
                    break;
                default:
                    throw new Exception("Bele bir qrup adi yoxdur");
                    break;
            }
            Category = categories;

            if (online != true || online != false)
            {
                throw new Exception("Duzgun cavab daxil edin (True/False)");
            }
            else
            {
                isOnline = online;
            }

            if(online == true)
            {
                Limit = 15;
                students = new List<Student>(Limit);
            }
            else
            {
                Limit = 10;
                students = new List<Student>(Limit);
            }

            Group temp = new Group(categories,online,limit);
            groups.Add(temp);
        }


        public void AddStudent(Student student)
        {
            if(students.Count <= Limit)
            {
                students.Add(student);
            }
        }

        public void ShowGroups()
        {
            foreach (var item in groups)
            {
                Console.WriteLine($"GroupName: {item.No}, Group Catagory: {item.Category}, Online Status: {item.isOnline}\n");
            }   
        }

    }
}
