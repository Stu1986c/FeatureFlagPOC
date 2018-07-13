using FeatureFlagPOC.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FeatureFlagPOC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFeatureService _featureService;
        private const int _qaTestUserId = 123456;

        public HomeController(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var welcomeMessage = "This is the old welcome message";

            if (_featureService.IsFeatureEnabled("ShowNewWelcome") && _featureService.IsUserFlaggedOn(_qaTestUserId))
            {
                welcomeMessage = $"Hello QA Tester {_qaTestUserId}. This is your special welcome message. Only you can see it.";
            }

            return View("Index", model: welcomeMessage);
        }

        [HttpGet]
        public ActionResult Registration()
        {
            return View("Registration");
        }

        [HttpGet]
        public ActionResult PersonalDetails()
        {
            return View("PersonalDetails");
        }

        [HttpGet]
        public ActionResult Payment()
        {
            if (_featureService.IsFeatureEnabled("UseStripePaymentMethod"))
            {
                return View("StripePayment");
            }
            return View("PaypalPayment");
        }

        [HttpGet]
        public ActionResult PaypalPayment()
        {

            return View("PaypalPayment");
        }

        [HttpGet]
        public ActionResult StripePayment()
        {
            return View("StripePayment");
        }

        [HttpGet]
        public ActionResult Complete()
        {
            return View("Complete");
        }


    }
}