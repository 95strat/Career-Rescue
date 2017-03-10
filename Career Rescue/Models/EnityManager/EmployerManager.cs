using System;
using System.Linq;
using Career_Rescue.ViewModels;
using Career_Rescue.Models.DB;

namespace Career_Rescue.Models.EnityManager
{
    public class EmployerManager
    {
        public void AddEmployerAccount(EmployerSignUpView employer)
        {
            using (CareerRescueEntities db = new CareerRescueEntities())
            {
                Employer EMP = new Employer();

                EMP.Email = employer.Email;
                EMP.Password = employer.Password;
                EMP.Employer_id = employer.Employer_id > 0 ? employer.Employer_id : 1;
                EMP.companyName = employer.companyName;
                EMP.contactName = employer.contactName;
                EMP.business_type = employer.business_type;
                EMP.Phone = employer.Phone;
                EMP.website = employer.website;

               /* EMP.status =employer.ToString(DateTime.Now);*/

                db.Employers.Add(EMP);
                db.SaveChangesAsync();

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