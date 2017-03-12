using System;
using System.Linq;
using Career_Rescue.ViewModels;
using Career_Rescue.Models.DB;
using System.Data.Entity.Validation;

namespace Career_Rescue.Models.EnityManager
{
    public class EmployerManager
    {
        public void AddEmployerAccount(EmployerSignUpView employer)
        {
            using (CareerRescueEntities db = new CareerRescueEntities())
            {
                Employer EMP = new Employer();
                Random b = new Random();
                int c = b.Next();
                EMP.Employer_id = employer.Employer_id > 0 ? employer.Employer_id : c; //1
                EMP.Email = employer.Email;
                EMP.Password = employer.Password;
                EMP.companyName = employer.companyName;
                EMP.contactName = employer.contactName;
                EMP.business_type = employer.business_type;
                EMP.Phone = employer.Phone;
                EMP.website = employer.website;

               /* EMP.status =employer.ToString(DateTime.Now);*/

                db.Employers.Add(EMP);
                
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
                return db.Employers.Where(o => o.Email.Equals(loginName)).Any();
            }
        }
    }
}