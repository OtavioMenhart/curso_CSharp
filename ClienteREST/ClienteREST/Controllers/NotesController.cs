using ClienteREST.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace ClienteREST.Controllers
{
    public class NotesController : Controller
    {
        HttpClient client = new HttpClient();

        public NotesController()
        {
            client.BaseAddress = new Uri("http://devmedianotesapi.azurewebsites.net/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
        // GET: Notes
        public ActionResult Index()
        {
            List<Notes> notes = new List<Notes>();
            HttpResponseMessage response = client.GetAsync("api/notes").Result;
            if (response.IsSuccessStatusCode)
            {
                notes = response.Content.ReadAsAsync<List<Notes>>().Result;
            }
            return View(notes);
        }

        // GET: Notes/Details/5
        public ActionResult Details(int id)
        {
            HttpResponseMessage response = client.GetAsync($"api/notes/{id}").Result;
            Notes note = response.Content.ReadAsAsync<Notes>().Result;
            if(note != null)
            {
                return View(note);
            }
            else
            {
                return HttpNotFound();
            }
        }

        // GET: Notes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Notes/Create
        [HttpPost]
        public ActionResult Create(Notes note)
        {
            try
            {
                HttpResponseMessage response = client.PostAsJsonAsync<Notes>("api/notes", note).Result;
                if (response.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.Error = "Error while creating note";
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Notes/Edit/5
        public ActionResult Edit(int id)
        {
            HttpResponseMessage response = client.GetAsync($"api/notes/{id}").Result;
            Notes note = response.Content.ReadAsAsync<Notes>().Result;
            if (note != null)
            {
                return View(note);
            }
            else
            {
                return HttpNotFound();
            }
        }

        // POST: Notes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Notes note)
        {
            try
            {
                HttpResponseMessage response = client.PutAsJsonAsync<Notes>($"api/notes/{id}", note).Result;
                if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.Error = "Error while creating note";
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Notes/Delete/5
        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = client.GetAsync($"api/notes/{id}").Result;
            Notes note = response.Content.ReadAsAsync<Notes>().Result;
            if (note != null)
            {
                return View(note);
            }
            else
            {
                return HttpNotFound();
            }
        }

        // POST: Notes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Notes note)
        {
            try
            {
                HttpResponseMessage response = client.DeleteAsync($"api/notes/{id}").Result;
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.Error = "Error while creating note";
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }
    }
}
