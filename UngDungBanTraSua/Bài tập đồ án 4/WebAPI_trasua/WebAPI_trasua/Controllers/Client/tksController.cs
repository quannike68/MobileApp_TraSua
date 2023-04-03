using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WebAPI_trasua.Models;

namespace WebAPI_trasua.Controllers.Client
{
    public class tksController : Controller
    {
      

        // GET: tks
        public ActionResult Index()
        {
            IEnumerable<tk> tks = null;
            using (var client = new HttpClient())
            {
                var responsetask = client.GetAsync("https://webapi-trasua.conveyor.cloud/api/tks");
                responsetask.Wait();
                var result = responsetask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<tk>>();
                    readTask.Wait();
                    tks = readTask.Result;
                }
                else
                {
                    tks = Enumerable.Empty<tk>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(tks);

        }

        // GET: tks/Details/5
        public ActionResult Details(int? id)
        {
            tk tk = null;

            using (var client = new HttpClient())
            {
                //HTTP GET
                var responseTask = client.GetAsync("https://webapi-trasua.conveyor.cloud/api/tk/gettt/" + id);
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<tk>();
                    readTask.Wait();

                    tk = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    tk = null;

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }

            return View(tk);
        }

        // GET: tks/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idtk,hoten,email,mk,sdt,diachi")] tk tk)
        {
            using (var client = new HttpClient())
            {

                //HTTP POST
                var postTask = client.PostAsJsonAsync<tk>("https://webapi-trasua.conveyor.cloud/api/tk/Posttk", tk);
                postTask.Wait();
                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return View(tk);
        }


        public ActionResult Delete(int? id)
        {
            tk tk = null;

            using (var client = new HttpClient())
            {
                //HTTP GET
                var responseTask = client.GetAsync("https://webapi-trasua.conveyor.cloud/api/tk/gettt/" + id);
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<tk>();
                    readTask.Wait();

                    tk = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    tk = null;

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }

            return View(tk);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            using (var client = new HttpClient())
            {

                var responseTask = client.DeleteAsync("https://webapi-trasua.conveyor.cloud/api/tk/Deletetk/" + id);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
                }

            }
            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
            return RedirectToAction("Index");
        }

      
    }
}
