using System;
using System.Linq;
using Career_Rescue.Models.DB;
using Career_Rescue.ViewModels;
using System.Data.Entity.Validation;

namespace Career_Rescue.Models.EnityManager
{
    public class MemberManager
    {
        public void AddMemberAccount(MemberSignUpView member)
        {
            using (CareerRescueEntities db = new CareerRescueEntities())
            {
                Member MBR = new Member();
                Random a = new Random();
                MBR.Member_id = member.Member_id > 0 ? member.Member_id : a.Next(); //1
                                   
                MBR.Email = member.Email;
                MBR.Password = member.Password;
                
                MBR.firstName = member.firstName;
                MBR.middleName = member.middleName;
                MBR.lastName = member.lastName;
                MBR.Address = member.Address;
                MBR.City = member.City;
                MBR.State = member.State;
                MBR.Phone = member.Phone;
                MBR.Birth_date = member.Birth_date;
                MBR.Gender = member.Gender;
                MBR.Experience = member.Experience;
                MBR.Skills = member.Skills;
                MBR.Resume = member.Resume;

                //MBR.status = member.ToString(DateTime.Now);

                db.Members.Add(MBR);
                try
                {
                    
                    db.SaveChanges();

                }
                catch (DbEntityValidationException e)
                {
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                ve.PropertyName, ve.ErrorMessage);
                        }
                    }
                    //throw;
                }

            }
        }
     public bool IsLoginNameExist(string loginName)
     {
        using (CareerRescueEntities db = new CareerRescueEntities())
        {
             return db.Members.Where(o => o.Email.Equals(loginName)).Any();
        }
     }
    }
    
}