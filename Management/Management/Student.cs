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

        public Student(string fullName,int groupNo,bool type)
        {
            
            if(fullName == null || fullName== "")
            {
                throw new NullReferenceException("Telebe adini bow qoya bilmezsen");
            }
            else
            {
                FullName = fullName;
            }

            if(groupNo == 0)
            {
                throw new NullReferenceException("Grup nomresini bos qoya bilmezsen");
            }
            else
            {
                GroupNo = groupNo;
            }

            Type = type;

            
        }

        public override string ToString()
        {
            var typeO = Type ? "Zemanetli" : "Zemanetsiz";
            return $"Name:{FullName}\nGroupNo: {GroupNo}Type: {typeO}";
        }
    }
}
