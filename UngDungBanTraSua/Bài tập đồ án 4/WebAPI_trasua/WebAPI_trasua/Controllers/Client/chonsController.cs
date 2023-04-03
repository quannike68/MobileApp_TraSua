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
    public class chonsController : Controller
    {

        // GET: chon
        public ActionResult Index()
        {
            IEnumerable<chon> chon = null;
            using (var client = new HttpClient())
            {
                var responsetask = client.GetAsync("https://webapi-trasua.conveyor.cloud/api/chon/getall");
                responsetask.Wait();
                var result = responsetask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<chon>>();
                    readTask.Wait();
                    chon = readTask.Result;
                }
                else
                {
                    chon = Enumerable.Empty<chon>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(chon);
        }

        // GET: chon/Details/5
        public ActionResult Details(int? id)
        {
            chon chon = null;

            using (var client = new HttpClient())
            {
                //HTTP GET
                var responseTask = client.GetAsync("https://webapi-trasua.conveyor.cloud/api/chon/Getchon/" + id);
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<chon>();
                    readTask.Wait();

                    chon = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    chon = null;

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }

            return View(chon);
        }

        // GET: chon/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_l,the_loai,ten,tien,ghichu")] chon chon)
        {
            using (var client = new HttpClient())
            {

                var postTask = client.PostAsJsonAsync<chon>("https://webapi-trasua.conveyor.cloud/api/chon/Postchon", chon);
                postTask.Wait();
                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
               
            }



            return View(chon);
        }

        // GET: chon/Edit/5
        public ActionResult Edit(int? id)
        {
            chon chon = null;

            using (var client = new HttpClient())
            {
                //HTTP GET
                var responseTask = client.GetAsync("https://webapi-trasua.conveyor.cloud/api/chon/Getchon/" + id);
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<chon>();
                    readTask.Wait();

                    chon = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    chon = null;

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }

            return View(chon);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_l,the_loai,ten,tien,ghichu")] chon chon)
        {
            using (var client = new HttpClient())
            {
                //HTTP PUT
                var putTask = client.PutAsJsonAsync<chon>("https://webapi-trasua.conveyor.cloud/api/chon/Putchon/" + chon.id_l, chon);
                putTask.Wait();

                var result = putTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
            }
            return View(chon);
        }

        // GET: chon/Delete/5
        public ActionResult Delete(int? id)
        {
            chon chon = null;

            using (var client = new HttpClient())
            {
                //HTTP GET
                var responseTask = client.GetAsync("https://webapi-trasua.conveyor.cloud/api/chon/Getchon/" + id);
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<chon>();
                    readTask.Wait();

                    chon = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    chon = null;

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }

            return View(chon);
        }

        // POST: chon/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            using (var client = new HttpClient())
            {

                var responseTask = client.DeleteAsync("https://webapi-trasua.conveyor.cloud/api/chon/Deletechon/" + id);
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

            return RedirectToAction("Index");
        }
    }
}
