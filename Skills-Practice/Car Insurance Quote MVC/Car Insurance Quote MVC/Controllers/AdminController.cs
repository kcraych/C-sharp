using Car_Insurance_Quote_MVC.Models;
using Car_Insurance_Quote_MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Car_Insurance_Quote_MVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (CarInsuranceEntities db = new CarInsuranceEntities())
            {
                var quotes = db.Quotes;
                var quotesVm = new List<QuoteVm>();
                foreach (var quote in quotes)
                {
                    var quoteVm = new QuoteVm();
                    quoteVm.FirstName = quote.FirstName;
                    quoteVm.LastName = quote.LastName;
                    quoteVm.Email = quote.Email;
                    quoteVm.QuoteAmount = quote.QuoteAmount;
                    quotesVm.Add(quoteVm);
                }
                return View(quotesVm);
            }
        }
    }
}