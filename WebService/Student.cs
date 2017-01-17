using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService
{
    public class Student
    {
        //ToDo delete
        private int id;
        private string name;
        private DateTime date;
        public Student() { }

        //ToDo delete
        public Student(int _id, string _name, DateTime _date)
        {

        }

        //ToDo Move to parent class and convert to auto-property
        public int Id { get { return id; } set { id = value; } }
        //ToDo convert to auto-property
        public string Name { get { return name; } set { name = value; } }
        public DateTime Date { get { return date; } set { date = value; } }
    }
}