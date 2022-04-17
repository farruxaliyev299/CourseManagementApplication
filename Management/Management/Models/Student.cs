using System;
using System.Collections.Generic;
using System.Text;

namespace Management.Models
{
    class Student
    {
        public string FullName;
        public string GroupNo;
        public bool Type; //zemanetli,zemanetsiz

        public static List<Student> AllStudents = new List<Student>() { };

        public Student(string fullName,bool type)
        {
            FullName = fullName;
            Type = type; 
        }

        public override string ToString()
        {
            var group0 = GroupNo!=null ? $"{GroupNo}" : "Qrupda deyil";
            var typeO = Type ? "Zemanetli" : "Zemanetsiz";
            return $"\nName:{FullName}\nGroupNo: {group0}\nType: {typeO}\n";
        }
    }
}
