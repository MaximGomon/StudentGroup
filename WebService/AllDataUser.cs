using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService
{
    public class AllDataUser
    {
        private int id;
        private string gender;
        private string street;
        private string telephone;
        private string numberSdudentTickets;
        private float middleMark;
        public AllDataUser(int id, string gender, string street, string telephone,
            string ticket, float middle)
        {
            Id = id;
            Gender = gender;
            Street = street;
            Telephone = telephone;
            NumberSdudentTickets = numberSdudentTickets;
            MiddleMark = middleMark;
        }

        public int Id { get { return id; } set { id = value; } }
        public string Gender { get { return gender; } set { gender = value; } }
        public string Street { get { return street; } set { street = value; } }
        public string Telephone { get { return telephone; } set { telephone = value; } }
        public string NumberSdudentTickets { get { return numberSdudentTickets; } set { numberSdudentTickets = value; } }
        public float MiddleMark { get { return middleMark; } set { middleMark = value; } }
    }
}