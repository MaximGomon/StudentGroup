using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "ServiceBD" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы ServiceBD.svc или ServiceBD.svc.cs в обозревателе решений и начните отладку.
    public class ServiceBD : IServiceBD
    {
        public void AddStudent()
        {
            throw new NotImplementedException();
        }

        public void AddStudent(string _name, DateTime _date)
        {
            using (DbConnect db = new DbConnect())
            {
                db.Students.Add(new Student { Id = 1, Name = _name, Date = _date });
                db.SaveChanges();
            }
        }

        public List<Student> GetStudent()
        {
            List<Student> list = new List<Student>();
            using (DbConnect db = new DbConnect())
            {
                list = db.Students.ToList();
            }
            return list;
        }

        public void RemoveStudent(int id, string name, DateTime date)
        {
            using (DbConnect db = new DbConnect())
            {
                Student stud = db.Students.Find(id);
                if (stud != null)
                {
                    db.Students.Remove(stud);
                    db.SaveChanges();
                }

            }
        }

        public void AddOtherData(int studentID, string gender, string street, string telephone, string ticket, float middle)
        {
            using (DbConnect db = new DbConnect())
            {
                AllDataStudent stud = new AllDataStudent { Id = 1, NumberStudent = studentID, Gender = gender, MiddleMark = middle, NumberSdudentTickets = ticket, Street = street, Telephone = telephone };
                try
                {
                    //db.AllDataStud.Add(new AllDataStudent {NumberStudent = studentID, Gender = gender, MiddleMark = middle, NumberSdudentTickets = ticket, Street = street, Telephone = telephone});
                    db.AllDataStud.Add(stud);
                    db.SaveChanges();
                }catch(Exception ex)
                {
                    string s = ex.ToString();
                    string q = "QQQ";
                }
                
            }
        }

        public void UpdateOtherInfo(int studentID, string gender, string street, string telephone, string ticket, float middle)
        {
            using (DbConnect db = new DbConnect())
            {
                foreach(var i in db.AllDataStud)
                {
                    if(i.NumberStudent == studentID)
                    {
                        //i.NumberStudent = studentID;
                        //i.Gender = gender;
                        //i.Telephone = telephone;
                        //i.Street = street;
                        //i.MiddleMark = middle;
                        //i.NumberSdudentTickets = ticket;
                        AllDataStudent stud = new AllDataStudent {NumberStudent = studentID, Gender = gender, MiddleMark = middle, NumberSdudentTickets = ticket, Street = street, Telephone = telephone };
                        db.AllDataStud.Add(stud);
                    }
                }
                db.SaveChanges();
            }
        }

        public List<AllDataStudent> GetOtherInfo()
        {
            List<AllDataStudent> list = new List<AllDataStudent>();
            using (DbConnect db = new DbConnect())
            {
                list = db.AllDataStud.ToList();
            }
            return list;
        }
    }
}
