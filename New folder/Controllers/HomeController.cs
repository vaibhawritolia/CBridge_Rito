using ConsultancyBridge.Models;
using ConsultancyBridge.ViewModel;
using System.Web.Mvc;

namespace ConsultancyBridge.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Career()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Contact(ContactViewModel contactViewModel)
        {
            if (ModelState.IsValid)
            {
                var contact = new Contact
                {
                    Email = contactViewModel.Email,
                    Message = contactViewModel.Message,
                    Name = contactViewModel.Name
                };
                _context.Contacts.Add(contact);
                _context.SaveChanges();
                ViewBag.Message = "Message successfully sent!";
            }
            return View();
        }


        public ActionResult Privacy()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult sdf()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        public ActionResult Terms()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}