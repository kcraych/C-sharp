using Car_Insurance_Quote_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Car_Insurance_Quotes_MVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public ActionResult Quote(string fName, string lName, string email, DateTime dob,
                                     int carYr, string carMk, string carMl,
                                     int dui, int speedTx, string covType)
        {
            using (CarInsuranceEntities db = new CarInsuranceEntities())
            {
                var quote = new Quote();
                quote.FirstName = fName;
                quote.LastName = lName;
                quote.Email = email;
                quote.DOB = dob;
                quote.CarYear = carYr;
                quote.CarMake = carMk;
                quote.CarModel = carMl;
                quote.DUI = (dui == 1) ? true : false;
                quote.NumOfSpeedTx = speedTx;
                quote.CoverageType = covType;

                //logic to calculate the car insurance quote
                quote.QuoteAmount = 50;
                quote.QuoteAmount += (dob.AddYears(26) > DateTime.Today) ? 25 : 0;
                quote.QuoteAmount += (dob.AddYears(19) > DateTime.Today) ? 75 : 0;
                quote.QuoteAmount += (dob.AddYears(100) < DateTime.Today) ? 25 : 0;
                quote.QuoteAmount += (carYr < 2000 || carYr > 2015) ? 25 : 0;
                quote.QuoteAmount += (carMk == "Porsche") ? 25 : 0;
                quote.QuoteAmount += (carMk == "Porsche" && carMl == "911 Carrera") ? 25 : 0;
                quote.QuoteAmount += speedTx * 10;
                decimal duiPenalty = (dui == 1) ? .25m : 0;
                decimal covCharge = (covType == "Full") ? .5m : 0;
                quote.QuoteAmount += quote.QuoteAmount * (duiPenalty + covCharge);

                db.Quotes.Add(quote);
                db.SaveChanges();

                ViewBag.QuoteAmount = quote.QuoteAmount;
            }
            return View("Index");
        }

        public ActionResult Index()
        {
            ViewBag.maxCarYear = DateTime.Today.Year + 1;
            return View();
        }
    }
}