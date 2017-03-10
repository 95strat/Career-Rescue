using System.Web.Mvc;
using System.Web.Security;
using Career_Rescue.ViewModels;
using Career_Rescue.Models.EnityManager;

namespace Career_Rescue.Controllers
{
    public class MemberAccountController : Controller
    {
        // GET: MemberAccount
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(MemberSignUpView MSV)
        {
            if (ModelState.IsValid)
            {
                MemberManager MM = new MemberManager();
                if (!MM.IsLoginNameExist(MSV.Email))
                {
                    MM.AddMemberAccount(MSV);
                    FormsAuthentication.SetAuthCookie(MSV.firstName, false);
                    return RedirectToAction("Membership", "Members");

                }
                else
                    ModelState.AddModelError("", "Login Name already taken.");
            }
            return View();

        }

    }