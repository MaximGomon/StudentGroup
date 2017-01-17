using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebService
{
    public class AllDataStudent
    {
        private int id;
        private int numberStudent;
        private string gender;
        private string street;
        private string telephone;
        private string numberSdudentTickets;
        private float middleMark;

        public AllDataStudent() { }
        //ToDo remove
        public AllDataStudent(int numberStudent, string gender, string street, string telephone,
            string ticket, float middle)
        {
            Id = 1;
            NumberStudent = numberStudent;
            Gender = gender;
            Street = street;
            Telephone = telephone;
            NumberSdudentTickets = numberSdudentTickets;
            MiddleMark = middleMark;
        }

        //ToDo convert to auto-property
        public int Id { get { return id; } set { id = value; } }
        public int NumberStudent { get { return numberStudent; } set { numberStudent = value; } }
        //ToDo add data annotation (like max length attribute)
        public string Gender { get { return gender; } set { gender = value; } }
        public string Street { get { return street; } set { street = value; } }
        public string Telephone { get { return telephone; } set { telephone = value; } }
        //ToDo Can student have more that one ticket?
        public string NumberSdudentTickets { get { return numberSdudentTickets; } set { numberSdudentTickets = value; } }
        public float MiddleMark { get { return middleMark; } set { middleMark = value; } }
    }
}