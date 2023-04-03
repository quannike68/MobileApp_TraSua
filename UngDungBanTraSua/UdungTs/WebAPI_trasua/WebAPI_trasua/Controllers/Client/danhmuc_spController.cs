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
    public class danhmuc_spController : Controller
    {

        // GET: danhmuc_sp
        public ActionResult Index()
        {
            IEnumerable<danhmuc_sp> danhmuc_sp = null;
            using (var client = new HttpClient())
            {
                var responsetask = client.GetAsync("https://webapi-trasua.conveyor.cloud/api/danhmuc/getall");
                responsetask.Wait();
                var result = responsetask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<danhmuc_sp>>();
                    readTask.Wait();
                    danhmuc_sp = readTask.Result;
                }
                else
                {
                    danhmuc_sp = Enumerable.Empty<danhmuc_sp>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(danhmuc_sp);
        }

        // GET: danhmuc_sp/Details/5
        public ActionResult Details(int? id)
        {
            danhmuc_sp danhmuc_sp = null;

            using (var client = new HttpClient())
            {
                //HTTP GET
                var responseTask = client.GetAsync("https://webapi-trasua.conveyor.cloud/api/danhmuc/Getdanhmuc_sp/" + id);
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<danhmuc_sp>();
                    readTask.Wait();

                    danhmuc_sp = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    danhmuc_sp = null;

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }

            return View(danhmuc_sp);
        }

        // GET: danhmuc_sp/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "iddm,tendm,hinhanh,ghichu")] danhmuc_sp danhmuc_sp)
        {
            using (var client = new HttpClient())
            {

                var postTask = client.PostAsJsonAsync<danhmuc_sp>("https://webapi-trasua.conveyor.cloud/api/danhmuc/Postdanhmuc_sp", danhmuc_sp);
                postTask.Wait();
                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
               
            }

            

            return View(danhmuc_sp);
        }

        // GET: danhmuc_sp/Edit/5
        public ActionResult Edit(int? id)
        {
            danhmuc_sp danhmuc_sp = null;

            using (var client = new HttpClient())
            {
                //HTTP GET
                var responseTask = client.GetAsync("https://webapi-trasua.conveyor.cloud/api/danhmuc/Getdanhmuc_sp/" + id);
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<danhmuc_sp>();
                    readTask.Wait();

                    danhmuc_sp = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    danhmuc_sp = null;

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }

            return View(danhmuc_sp);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "iddm,tendm,hinhanh,ghichu")] danhmuc_sp danhmuc_sp)
        {
            using (var client = new HttpClient())
            {
                //HTTP PUT
                var putTask = client.PutAsJsonAsync<danhmuc_sp>("https://webapi-trasua.conveyor.cloud/api/danhmuc/Putdanhmuc_sp/" + danhmuc_sp.iddm, danhmuc_sp);
                putTask.Wait();

                var result = putTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
            }
            return View(danhmuc_sp);
        }

        // GET: danhmuc_sp/Delete/5
        public ActionResult Delete(int? id)
        {
            danhmuc_sp danhmuc_sp = null;

            using (var client = new HttpClient())
            {
                //HTTP GET
                var responseTask = client.GetAsync("https://webapi-trasua.conveyor.cloud/api/danhmuc/Getdanhmuc_sp/" + id);
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<danhmuc_sp>();
                    readTask.Wait();

                    danhmuc_sp = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    danhmuc_sp = null;

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }

            return View(danhmuc_sp);
        }

        // POST: danhmuc_sp/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            using (var client = new HttpClient())
            {

                var responseTask = client.DeleteAsync("https://webapi-trasua.conveyor.cloud/api/danhmuc/Deletedanhmuc_sp/" + id);
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
