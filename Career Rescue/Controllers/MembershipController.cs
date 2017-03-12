using System.Web.Mvc;
using System.Web.Security;
using Career_Rescue.ViewModels;
using Career_Rescue.Models.EnityManager;


namespace Career_Rescue.Controllers
{
    
    
    public class MembershipController : Controller
    {
        
        public ActionResult Members()
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult Members(MemberSignUpView MSV)
        {
            if (ModelState.IsValid)
            {
                MemberManager MM = new MemberManager();
                if (!MM.IsLoginNameExist(MSV.Email))
                {
                    MM.AddMemberAccount(MSV);
                    FormsAuthentication.SetAuthCookie(MSV.firstName, false);
                    return RedirectToAction("Welcome", "Home");

                }
                else
                    ModelState.AddModelError("", "Login Name already taken.");
            }
            return View();

        }

        public ActionResult Employers()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Employers(EmployerSignUpView ESV)
        {
            if (ModelState.IsValid)
            {
                EmployerManager EM = new EmployerManager();
                if (!EM.IsLoginNameExist(ESV.Email))
                {
                    EM.AddEmployerAccount(ESV);
                    FormsAuthentication.SetAuthCookie(ESV.contactName, false);
                    return RedirectToAction("Welcome", "Home");

                }
                else
                    ModelState.AddModelError("", "Login Name already taken.");
            }
            return View();

        }

        public ActionResult MemberHome()
        {
            return View();
        }

        public ActionResult EmployerHome()
        {
            return View();
        }


    }
}
