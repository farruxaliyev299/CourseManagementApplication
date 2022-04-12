using System;
using Management.Models;

namespace Management
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("1.Yeni qrup yarat");
            //Console.WriteLine("2.Qruplarin siyahisini goster");
            //Console.WriteLine("3.Qrupdaki teleblerin siyahisi");
            //Console.WriteLine("4.Butun telebelerin siyahisi");
            //Console.WriteLine("5.Telebe yarat");

            //Student student1 = new Student("Ferrux Aliyev,", true);
            //Student student2 = new Student("Samir Aliyev", false);

            
            
            bool check = true;
            while (check)
            {
                Console.WriteLine("1.Telebe Yarat");
                Console.WriteLine("2.Butun Telebeleri goster");
                Console.WriteLine("3.Qrup Yarat");
                Console.WriteLine("4.Butun qruplari goster");
                Console.WriteLine("5.Studenti qrupa elave et");
                Console.WriteLine("0.Dayandir");

                int n = int.Parse(Console.ReadLine());

                if (n == 1)
                {
                    CreateStudent();
                }
                else if (n == 2)
                {
                    ShowAllStudents();
                }
                else if (n == 3)
                {
                    CreateGroup();
                }
                else if (n == 4)
                {
                    ShowAllGroups();
                }
                else if (n == 5)
                {
                    AddStudentGroup();
                }
                else if (n == 0)
                {
                    check = false;
                    break;
                }


            }

            




        }

        static void CreateStudent()
        {
            Console.WriteLine("Telebenin tam adini ve zemanetli olub olmadigini daxil edin");
            Student exstudent = new Student(Console.ReadLine(), bool.Parse(Console.ReadLine()));
            Student.AllStudents.Add(exstudent);
        }

        static void ShowAllStudents()
        {
            foreach (var item in Student.AllStudents)
            {
                Console.WriteLine(item.ToString());
            }
        }

        static void CreateGroup()
        {
            Console.WriteLine("Grupun kategoriyasini ve online durumunu daxil edin: ");
            Console.WriteLine("1.Programming");
            Console.WriteLine("2.Design");
            Console.WriteLine("3.System");
            Category ctg = (Category)int.Parse(Console.ReadLine());
            Group exgroup = new Group(ctg, bool.Parse(Console.ReadLine()));
            Group.groups.Add(exgroup);
        }

        static void ShowAllGroups()
        {
            foreach (var item in Group.groups)
            {
                Console.WriteLine(item.ToString());
            }
        }

        static void AddStudentGroup()
        {
            int menu;
            for (int i = 0; i < Group.groups.Count; i++)
            {
                Console.WriteLine($"{i+1}.{Group.groups[i].No}");
                menu = i;
            }

            //int groupSel = int.Parse(Console.ReadLine());
            //if(groupSel == menu)

        }
    }




    
}
