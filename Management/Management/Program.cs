using System;
using Management.Models;

namespace Management
{
    class Program
    {
        static void Main(string[] args)
        {
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

                switch (n)
                {
                    case 1:
                        CreateStudent();
                        break;
                    case 2:
                        ShowAllStudents();
                        break;
                    case 3:
                        CreateGroup();
                        break;
                    case 4:
                        ShowAllGroups();
                        break;
                    case 5:
                        ShowStudentsGroup();
                        break;
                    case 6:
                        EditGroup();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("=================================");
                        Console.WriteLine("Bele bir content yoxdur , yeniden daxil edin");
                        break;
                }


            }
        }

        static void CreateStudent()
        {
            Console.WriteLine("Telebenin adini ve soyadini daxil edin");
            string fullName = Console.ReadLine().Trim();
            if(fullName == "" || fullName ==" ")
            {
                Console.WriteLine("=================================");
                Console.WriteLine("Xeta: Telebenin adi ve soyadi bos qoyula bilmez!");
                return;
            }
            for (int i = 0; i < Student.AllStudents.Count; i++)
            {
                if (Student.AllStudents[i].FullName.Trim() == fullName.Trim())
                {
                    Console.WriteLine("Bele adda telebe movcuddur!");
                    return;
                }
            }
            Console.WriteLine("Telebenin zemanetli olub olmamasini daxil edin(true/false):");
            bool type = false;
            try
            {
                type = bool.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("=================================");
                Console.WriteLine("Xeta: Zemanet ancaq true/false ola biler!");
                return;
            }
            Student exstudent = new Student(fullName,type);
            Student.AllStudents.Add(exstudent);

            AddStudentGroup(exstudent);
        }

        static void ShowAllStudents()
        {
            if (Student.AllStudents.Count == 0)
            {
                Console.WriteLine("=================================");
                Console.WriteLine("Hal-hazirda hec bir telebe yoxdur!");
                return;
            }
            foreach (var item in Student.AllStudents)
            {
                Console.WriteLine(item.ToString());
            }
        }

        static void CreateGroup()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Kateqoriyalar:\n");
            Console.WriteLine("1.Programming");
            Console.WriteLine("2.Design");
            Console.WriteLine("3.System");
            Console.WriteLine("=================================");
            Console.WriteLine("Qrupun kateqoriyasini daxil edin(example:1,2,3):");
            Category ctg = (Category)int.Parse(Console.ReadLine());
            if((int)ctg < 0 || (int)ctg > 3)
            {
                Console.WriteLine("=================================");
                Console.WriteLine("Duzgun kateqoriya secin , bele kateqoriya movcud deyil");
                return;
            }
            Console.WriteLine("Online status(true/false):");
            bool isOnline = false;
            try
            {
                isOnline = bool.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("=================================");
                Console.WriteLine("Xeta: Online status ancaq true/false ola biler!");
                return;
            }
            Group exgroup = new Group(ctg, isOnline);
            Group.groups.Add(exgroup);
        }

        static void AddStudentGroup(Student student)
        { 
            if(Group.groups.Count > 0)
            {
                Console.WriteLine("=================================");
                Console.WriteLine("Hal-hazirda olan qruplar");
                for (int i = 0; i < Group.groups.Count; i++)
                {
                    Console.WriteLine($"\n{i + 1}.{Group.groups[i].No}\n");
                }
                Console.WriteLine("=================================");
                Console.WriteLine("Elave etmek istediyin qrupun adini daxil et:");
                string groupInput = Console.ReadLine();
                bool check = false;

                for (int i = 0; i < Group.groups.Count; i++)
                {
                    if (groupInput == Group.groups[i].No)
                    {
                        Group.groups[i].AddStudent(student);
                        Console.WriteLine("=================================");
                        Console.WriteLine($"Telebe {Group.groups[i].No} qrupuna daxil edildi.");
                        check = true;
                    }
                }
                if (!check)
                {
                    Console.WriteLine("=================================");
                    Console.WriteLine("Bele adda qrup tapilmadi , telebe hec bir qrupa daxil edilmir.");
                }
            }
            else
            {
                Console.WriteLine("=================================");
                Console.WriteLine("Hal-hazirda hec bir qrup olmadigindan , telebe qrupa daxil edilmir");
                return;
            }
        }

        static void EditGroup()
        {
            if(Group.groups.Count > 0)
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
                bool check = false;
                for(int i = 0; i < Group.groups.Count; i++)
                {
                    if(groupInput == Group.groups[i].No)
                    {
                        check = true;
                    }
                }
                if (!check)
                {
                    Console.WriteLine("=================================");
                    Console.WriteLine("Duzelis etmeye bele adda qrup tapilmadi");
                    return;
                }
                Console.WriteLine("=================================");
                Console.WriteLine("Grupun yeni adini teyin et:");
                string groupInput2 = Console.ReadLine();

                for (int i = 0; i < Group.groups.Count; i++)
                {
                    if (groupInput2 == Group.groups[i].No)
                    {
                        Console.WriteLine("=================================");
                        Console.WriteLine("Bu adda qrup movcuddur, ad deyisdirilmir!\n");
                        return;
                    }
                }

                for (int j = 0; j < Group.groups.Count; j++)
                {
                    if (groupInput == Group.groups[j].No)
                    {
                        Group.groups[j].No = groupInput2;
                    }
                }
            }
            else
            {
                Console.WriteLine("=================================");
                Console.WriteLine("Hal-hazirda hec bir qrup yoxdur!");
                return;
            }
            
        }

        static void ShowAllGroups()
        {
            if(Group.groups.Count == 0)
            {
                Console.WriteLine("=================================");
                Console.WriteLine("Hal-hazirda hec bir qrup yaradilmayib");
                return;
            }
            foreach (var item in Group.groups)
            {
                Console.WriteLine(item.ToString());
            }
        }

        static void ShowStudentsGroup()
        {
            if(Group.groups.Count > 0)
            {
                for (int i = 0; i < Group.groups.Count; i++)
                {
                    Console.WriteLine($"{i + 1}.{Group.groups[i].No}\n");

                }

                Console.WriteLine("Axtardigin qrupun adini daxil et:");
                string gInput = Console.ReadLine();
                bool checkGroup = false;

                for (int i = 0; i < Group.groups.Count; i++)
                {
                    if (gInput == Group.groups[i].No)
                    {
                        checkGroup = true;
                        for (int j = 0; j < Group.groups[i].students.Count; j++)
                        {
                            Console.WriteLine(Group.groups[i].students[j].ToString());
                        }
                    }
                }

                if (!checkGroup)
                {
                    Console.WriteLine("=================================");
                    Console.WriteLine("Bele addda qrup tapilmadi");
                    return;
                }
            }
            else
            {
                Console.WriteLine("=================================");
                Console.WriteLine("Hal-hazirda hec bir qrup yoxdur!");
                return;
            }
            
        }
    }




    
}
