using PaymentSolutionApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaymentSolutionApp.Controllers
{
    public class LogController : Controller
    {
        private paymentsolutionEntities db = new paymentsolutionEntities();
        // GET: Log
        public ActionResult Index()
        {
            return View(db.Logs.ToList());
        }
    }
}