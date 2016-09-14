using LifeInsuranceWeb.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;


namespace LifeInsuranceWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            var AboutModel = new AboutModel();
            AboutModel.Name = "Jordan Rowland";
            AboutModel.Age = 22;
            AboutModel.Location = "Peterborough";

            var AboutModel2 = new AboutModel();
            AboutModel2.Name = "Davey";
            AboutModel2.Age = 30;
            AboutModel2.Location = "Peterborough";

            List<AboutModel> Aboutmodels = new List<AboutModel>();
            Aboutmodels.Add(AboutModel);
            Aboutmodels.Add(AboutModel2);

            return View(Aboutmodels);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Calculate()
        {

            return View();
        }


        [HttpPost]
        public ActionResult Calculate(CalculateModel model)
        {
            return View();
        }

        public ActionResult Calculator(CalculateModel model)
        {
            var customerDetails = new LifeInsurance_2.CustomerDetails();
            var calculations = new LifeInsurance_2.Calculations();

            customerDetails.DateOfBirth = model.DateOfBirth;
            customerDetails.Gender = model.Gender;
            customerDetails.Country = model.Country;
            customerDetails.Children = model.Children;
            customerDetails.Smoker = model.Smoker;
            customerDetails.HoursOfExercise = model.HoursOfExercise;

            decimal price = 0;
            var calculatePremium = new LifeInsurance_2.Calculations();

            price = calculatePremium.CalculatePremium(customerDetails);
  

            return View();
        }
    }
}
