using System;
using System.Collections.Generic;
using System.Text;

namespace Management.Models
{
    class Student
    {
        public string FullName;
        public int GroupNo;
        public bool Type;

        public static List<Student> AllStudents = new List<Student>() { };

        public Student(string fullName,bool type)
        {
            
            if(fullName == null || fullName== "")
            {
                throw new NullReferenceException("Telebe adini bow qoya bilmezsen");
            }
            else
            {
                FullName = fullName;
            }

            

            Type = type;

            
        }

        public override string ToString()
        {
            var typeO = Type ? "Zemanetli" : "Zemanetsiz";
            return $"Name:{FullName}\nGroupNo: {GroupNo}\nType: {typeO}";
        }
    }
}
