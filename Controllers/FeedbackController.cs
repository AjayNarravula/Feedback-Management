using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Feedback.Controllers
{
    public class FeedbackController : Controller
    {
        // GET: Feedback
        public static List<Feedback> feedbackList =
           new List<Feedback>();

        public void LoadData()
        {
            ViewBag.Categories = new SelectList(
                new[] { "Teaching", "Facilities", "Website", "Other" });

            ViewBag.FeedbackList = feedbackList;
        }

        public ActionResult Index()
        {
            LoadData();
            return View(new Feedback());
        }

        [HttpPost]
        public ActionResult Index(Feedback f)
        {
            if (ModelState.IsValid)
            {
                feedbackList.Add(f);
                ViewBag.Message = "Feedback submitted successfully!";
                ModelState.Clear();
                LoadData();
                return View(new Feedback());
            }

            LoadData();
            return View(f);
        }
    }
}