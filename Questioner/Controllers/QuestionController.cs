using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.IO;

namespace Questioner.Controllers
{
    public class QuestionController : Controller
    {
        public int value { get; set; }
        public ActionResult Increment()
        {
            value = int.Parse(System.IO.File.ReadAllText("D:\\TestProjects\\asp.nets\\core\\WebApplication1\\Questioner\\wwwroot\\names.txt")) + 1;

            System.IO.File.WriteAllText("D:\\TestProjects\\asp.nets\\core\\WebApplication1\\Questioner\\wwwroot\\names.txt", value.ToString());

            return RedirectToAction(nameof(Index)); 
        }

        // GET: QuestionController
        public ActionResult Index()
        {
            value = int.Parse(System.IO.File.ReadAllText("D:\\TestProjects\\asp.nets\\core\\WebApplication1\\Questioner\\wwwroot\\names.txt"));
            

            ViewData["value"] = value;
            return View();
        }

        // GET: QuestionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: QuestionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuestionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                



                Debug.WriteLine(collection["question"]);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: QuestionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: QuestionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: QuestionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: QuestionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
