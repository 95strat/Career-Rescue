using System.Web.Mvc;


namespace Career_Rescue.Controllers
{
    
    
    public class MembershipController : Controller
    {
        
        public ActionResult Members()
        {
           
            return View();
        }
        
        public ActionResult Employers()
        {
            return View();
        }
    }
}
