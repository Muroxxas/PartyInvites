using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvites.Models;
using PartyInvites.Concrete;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        private EFDbContext db = new EFDbContext();

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        
       
        [HttpPost]
        public ActionResult RsvpForm(GuestResponse model)
        {
            try
            {
                GuestResponse guest = new GuestResponse();
                guest.Name = model.Name;
                guest.Email = model.Email;
                guest.Phone = model.Phone;
                guest.WillAttend = model.WillAttend;

                db.PartyInvitesTable.Add(guest);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}