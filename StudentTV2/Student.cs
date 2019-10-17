using System;
namespace StudentTV2
{
    public class Student
    {
        private string fullName;
        private string id;
        private int age;
        private string course;

        public Student(string fullName, string id, int age, string course)
        {
            this.fullName = fullName;
            this.id = id;
            this.age = age;
            this.course = course;
        }

        //public Student(string fullName, string id, int age) : this(fullName, id, age, "In progress")
        //{ 
        //}

        public string _fullName
        {
            get => fullName;
            set => fullName = value;
        }

        public string _id
        {
            get => id;
            set => id = value;
        }

        public int _age
        {
            get => age;
            set => age = value;
        }

        public string _course
        {
            get => course;
            set => course = value;
        }
    }
}

