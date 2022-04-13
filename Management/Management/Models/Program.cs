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
                Console.WriteLine("=================================");
                Console.WriteLine("1.Telebe Yarat");
                Console.WriteLine("2.Butun Telebeleri goster");
                Console.WriteLine("3.Qrup Yarat");
                Console.WriteLine("4.Butun qruplari goster");
                Console.WriteLine("5.Qrupdaki teleblerin siyahisi");
                Console.WriteLine("6.Qrupda düzeliş etmek");
                Console.WriteLine("0.Dayandir");
                Console.WriteLine("=================================");
                Console.WriteLine("Menu contentini daxil et:");
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
                    ShowStudentsGroup();
                }
                else if(n == 6)
                {
                    EditGroup();
                }
                else if (n == 0)
                {
                    break;
                }


            }
        }

        static void CreateStudent()
        {
            Console.WriteLine("Telebenin adini daxil edin");
            string fullName = Console.ReadLine().Trim();
            for (int i = 0; i < Student.AllStudents.Count; i++)
            {
                if (Student.AllStudents[i].FullName.Trim() == fullName.Trim())
                {
                    Console.WriteLine("Bele adda telebe movcuddur!");
                    return;
                }
            }
            Console.WriteLine("Telebenin zemanetli olub olmamasini daxil edin(true/false):");
            bool type = bool.Parse(Console.ReadLine());
            Student exstudent = new Student(fullName,type);
            Student.AllStudents.Add(exstudent);

            AddStudentGroup(exstudent);
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
            Console.WriteLine("=================================");
            Console.WriteLine("1.Programming");
            Console.WriteLine("2.Design");
            Console.WriteLine("3.System");
            Console.WriteLine("=================================");
            Console.WriteLine("Qrupun kateqoriyasini daxil edin(example:1,2,3):");
            Category ctg = (Category)int.Parse(Console.ReadLine());
            if((int)ctg < 0 || (int)ctg > 3)
            {
                Console.WriteLine("Duzgun kateqoriya secin");
                return;
            }
            Console.WriteLine("Online status(true/false):");
            bool isOnline = bool.Parse(Console.ReadLine());
            Group exgroup = new Group(ctg, isOnline);
            Group.groups.Add(exgroup);
        }

        static void AddStudentGroup(Student student)
        {
            Console.WriteLine("Hal-hazirda olan qruplar");
            if(Group.groups.Count > 0)
            {
                for (int i = 0; i < Group.groups.Count; i++)
                {
                    Console.WriteLine($"\n{i + 1}.{Group.groups[i].No}\n");
                }

                Console.WriteLine("Elave etmek istediyin qrupun adini daxil et:");
                string groupInput = Console.ReadLine();

                for (int i = 0; i < Group.groups.Count; i++)
                {
                    if (groupInput == Group.groups[i].No)
                    {
                        Group.groups[i].AddStudent(student);
                    }
                }
            }
            
        }

        static void EditGroup()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Hal-hazirda olan qruplar");
            for (int i = 0; i < Group.groups.Count; i++)
            {
                Console.WriteLine($"\n{i + 1}.{Group.groups[i].No}\n");
            }
            Console.WriteLine("=================================");
            Console.WriteLine("Duzelis etmek istediyin qrupun adini yaz:");
            string groupInput = Console.ReadLine();
            Console.WriteLine("Grupun yeni adini teyin et:");
            string groupInput2 = Console.ReadLine();

            for (int i = 0; i < Group.groups.Count; i++)
            {
                if(groupInput2 == Group.groups[i].No)
                {
                    Console.WriteLine("\nBu adda qrup movcuddur, ad deyisdirilmir!\n");
                    return;
                }
            }

            for (int j = 0; j < Group.groups.Count; j++)
            {
                if(groupInput == Group.groups[j].No)
                {
                    Group.groups[j].No = groupInput2;
                }
            }
        }

        static void ShowAllGroups()
        {
            foreach (var item in Group.groups)
            {
                Console.WriteLine(item.ToString());
            }
        }

        static void ShowStudentsGroup()
        {
            for (int i = 0; i < Group.groups.Count; i++)
            {
                Console.WriteLine($"{i+1}.{Group.groups[i].No}\n");
                
            }

            Console.WriteLine("Axtardigin qrupun adini daxil et:");
            string gInput = Console.ReadLine();

            for (int i = 0; i < Group.groups.Count; i++)
            {
                if (gInput == Group.groups[i].No)
                {
                    for (int j = 0; j < Group.groups[i].students.Count; j++)
                    {
                        Console.WriteLine(Group.groups[i].students[j].ToString());
                    }
                    
                }
            }
        }
    }




    
}
