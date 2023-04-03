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
    public class san_phamController : Controller
    {

        // GET: san_pham
        public ActionResult Index()
        {
            IEnumerable<san_pham> san_pham = null;
            using (var client = new HttpClient())
            {
                var responsetask = client.GetAsync("https://webapi-trasua.conveyor.cloud/api/san_pham/getall");
                responsetask.Wait();
                var result = responsetask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<san_pham>>();
                    readTask.Wait();
                    san_pham = readTask.Result;
                }
                else
                {
                    san_pham = Enumerable.Empty<san_pham>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(san_pham);
        }

        // GET: san_pham/Details/5
        public ActionResult Details(int? id)
        {
            san_pham san_pham = null;

            using (var client = new HttpClient())
            {
                //HTTP GET
                var responseTask = client.GetAsync("https://webapi-trasua.conveyor.cloud/api/san_pham/getchitiet/" + id);
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<san_pham>();
                    readTask.Wait();

                    san_pham = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    san_pham = null;

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }

            return View(san_pham);
        }

        // GET: san_pham/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idsp,iddm,tensp,giatien,hinhanh,ghichu")] san_pham san_pham)
        {
            using (var client = new HttpClient())
            {

                var postTask = client.PostAsJsonAsync<san_pham>("https://webapi-trasua.conveyor.cloud/api/sanpham/Postsan_pham", san_pham);
                postTask.Wait();
                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
              
            }



            return View(san_pham);
        }

        // GET: san_pham/Edit/5
        public ActionResult Edit(int? id)
        {
            san_pham san_pham = null;

            using (var client = new HttpClient())
            {
                //HTTP GET
                var responseTask = client.GetAsync("https://webapi-trasua.conveyor.cloud/api/san_pham/getchitiet/" + id);
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<san_pham>();
                    readTask.Wait();


                    san_pham = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    san_pham = null;

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }

            return View(san_pham);
        }

        // POST: san_pham/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idsp,iddm,tensp,giatien,hinhanh,ghichu")] san_pham san_pham)
        {
            using (var client = new HttpClient())
            {
                //HTTP PUT
                var putTask = client.PutAsJsonAsync<san_pham>("https://webapi-trasua.conveyor.cloud/api/sanpham/Putsan_pham/" + san_pham.idsp, san_pham);
                putTask.Wait();

                var result = putTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
            }
            return View(san_pham);
        }

        // GET: san_pham/Delete/5
        public ActionResult Delete(int? id)
        {
            san_pham san_pham = null;

            using (var client = new HttpClient())
            {
                //HTTP GET
                var responseTask = client.GetAsync("https://webapi-trasua.conveyor.cloud/api/san_pham/getchitiet/" + id);
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<san_pham>();
                    readTask.Wait();


                    san_pham = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    san_pham = null;

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }

            return View(san_pham);
        }

        // POST: san_pham/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            using (var client = new HttpClient())
            {

                var responseTask = client.DeleteAsync("https://webapi-trasua.conveyor.cloud/api/sanpham/Deletesan_pham/" + id);
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
