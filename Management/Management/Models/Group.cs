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
        public static List<Group> groups = new List<Group>() { };

        private static int Bp = 200;
        private static int Bn = 200;
        private static int Dn = 200;

        public Group(Category categories,bool online)
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
                    Console.WriteLine("Bele bir qrup adi yoxdur");
                    return;
            }
            Category = categories;

            if (online == true || online == false)
            {
                isOnline = online;
            }
            else
            {
                Console.WriteLine("Duzgun cavab daxil edin (True/False)");
                return;
            }

            if (online == true)
            {
                Limit = 15;
                students = new List<Student>(Limit);
            }
            else
            {
                Limit = 10;
                students = new List<Student>(Limit);
            }

            
        }


        public void AddStudent(Student student)
        {

            if (students.Count < Limit)
            {
                students.Add(student);
            }
            else
            {
                Console.WriteLine("Student sayi limiti asir!");
                return;
            }
            if(student.GroupNo == default)
            {
                student.GroupNo = No;
            }
            else
            {
                throw new Exception("Bu telebe hal-hazirda basqa bir qrupdadir");
            }
            
        }

        public override string ToString()
        {
            var onlineO = isOnline ? "Online" : "Offline";
            string catO;
            if(Category == Category.Programming)
            {
                catO = "Programming";
            }
            else if(Category == Category.Design)
            {
                catO = "Design";
            }
            else
            {
                catO = "System";
            }
            return $"\nAdi:{No}\nCategory: {catO}\nOnline Status: {onlineO}\n";
        }

        

    }
}
