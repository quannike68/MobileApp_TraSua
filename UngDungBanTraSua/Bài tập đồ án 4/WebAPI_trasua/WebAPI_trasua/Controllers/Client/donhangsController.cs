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
    public class donhangsController : Controller
    {
        private Model1 db = new Model1();

        // GET: donhangs
        public ActionResult Index()
        {
            IEnumerable<donhang> chon = null;
            using (var client = new HttpClient())
            {
                var responsetask = client.GetAsync("https://webapi-trasua.conveyor.cloud/api/donhang/Getdonhangs");
                responsetask.Wait();
                var result = responsetask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<donhang>>();
                    readTask.Wait();
                    chon = readTask.Result;
                }
                else
                {
                    chon = Enumerable.Empty<donhang>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(chon);
        }

        // GET: donhangs/Details/5
        public ActionResult Details(int? id)
        {
            donhang donhang = null;
            giohang giohang = null;
            using (var client = new HttpClient())
            {
                //HTTP GET
                var responseTask2 = client.GetAsync("https://webapi-trasua.conveyor.cloud/api/donhang/Getdonhangs/" + id);
                responseTask2.Wait();
                var result2 = responseTask2.Result;
                if (result2.IsSuccessStatusCode)
                {
                    var readTask2 = result2.Content.ReadAsAsync<donhang>();
                    readTask2.Wait();
                    donhang = readTask2.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    donhang = null;

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            using (var client = new HttpClient())
            {
                var responseTask1 = client.GetAsync("https://webapi-trasua.conveyor.cloud/api/giohang/Getgiohang/" + donhang.idgh);
                responseTask1.Wait();
                var result1 = responseTask1.Result;
                if (result1.IsSuccessStatusCode)
                {
                    var readTask1 = result1.Content.ReadAsAsync<giohang>();
                    readTask1.Wait();
                    giohang = readTask1.Result;
                   
                }
                else
                {
                    giohang = null;

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
          ViewBag.giohang = giohang;
            
            return View(donhang);
        }

        // GET: donhangs/Create
      

        // GET: donhangs/Edit/5
        public ActionResult Edit(int? id)
        {
            donhang donhang = null;
            giohang giohang = null;
            using (var client = new HttpClient())
            {
                //HTTP GET
                var responseTask2 = client.GetAsync("https://webapi-trasua.conveyor.cloud/api/donhang/Getdonhangs/" + id);
                responseTask2.Wait();
                var result2 = responseTask2.Result;
                if (result2.IsSuccessStatusCode)
                {
                    var readTask2 = result2.Content.ReadAsAsync<donhang>();
                    readTask2.Wait();
                    donhang = readTask2.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    donhang = null;

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            using (var client = new HttpClient())
            {
                var responseTask1 = client.GetAsync("https://webapi-trasua.conveyor.cloud/api/giohang/Getgiohang/" + donhang.idgh);
                responseTask1.Wait();
                var result1 = responseTask1.Result;
                if (result1.IsSuccessStatusCode)
                {
                    var readTask1 = result1.Content.ReadAsAsync<giohang>();
                    readTask1.Wait();
                    giohang = readTask1.Result;

                }
                else
                {
                    giohang = null;

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            ViewBag.giohang = giohang;
           
            return View(donhang);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "iddh,idtk,idgh,loinhan,ngaygio,hanhchinh,ghichu")] donhang donhang)
        {
            using (var client = new HttpClient())
            {
               
                var putTask = client.PutAsJsonAsync<donhang>("https://webapi-trasua.conveyor.cloud/api/donhang/Putdonhang/" + donhang.iddh, donhang);
                putTask.Wait();

                var result = putTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
            }
            return View(donhang);
        }

        // GET: donhangs/Delete/5
        public ActionResult Delete(int? id)
        {
            donhang donhang = null;
            giohang giohang = null;
            using (var client = new HttpClient())
            {
                //HTTP GET
                var responseTask2 = client.GetAsync("https://webapi-trasua.conveyor.cloud/api/donhang/Getdonhangs/" + id);
                responseTask2.Wait();
                var result2 = responseTask2.Result;
                if (result2.IsSuccessStatusCode)
                {
                    var readTask2 = result2.Content.ReadAsAsync<donhang>();
                    readTask2.Wait();
                    donhang = readTask2.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    donhang = null;

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            using (var client = new HttpClient())
            {
                var responseTask1 = client.GetAsync("https://webapi-trasua.conveyor.cloud/api/giohang/Getgiohang/" + donhang.idgh);
                responseTask1.Wait();
                var result1 = responseTask1.Result;
                if (result1.IsSuccessStatusCode)
                {
                    var readTask1 = result1.Content.ReadAsAsync<giohang>();
                    readTask1.Wait();
                    giohang = readTask1.Result;

                }
                else
                {
                    giohang = null;

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            ViewBag.giohang = giohang;

            return View(donhang);
        }

        // POST: donhangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            using (var client = new HttpClient())
            {

                var responseTask = client.DeleteAsync("https://webapi-trasua.conveyor.cloud/api/donhang/Deletedonhang/" + id);
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

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
