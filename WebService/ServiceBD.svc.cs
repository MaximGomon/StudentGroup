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

        public void AddOtherData(int id, string gender, string street, string telephone, string ticket, float middle)
        {
            using (DbConnect db = new DbConnect())
            {
                AllDataUser stud = db.AllData.Find(id);
                stud.Gender = gender;
                stud.Street = street;
                stud.Telephone = telephone;
                stud.NumberSdudentTickets = ticket;
                stud.MiddleMark = middle;

                if (stud != null)
                {
                    db.AllData.Add(stud);
                    db.SaveChanges();
                }

            }
        }

        public void SetNewId()
        {
            using (DbConnect db = new DbConnect())
            {
                var list = db.Students;
                int countStudent = 1;
                try
                {
                    foreach(var i in list)
                    {
                        i.Id = countStudent;
                        countStudent++;
                    }
                    db.SaveChanges();
                }
                catch(Exception ex)
                {
                    string s = ex.ToString();
                }
                //db.SaveChanges();
            }
        }
    }
}
