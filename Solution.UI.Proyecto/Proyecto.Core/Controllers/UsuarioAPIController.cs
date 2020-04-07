using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Proyecto.Core.Models;

namespace Solution.Core.Controllers
{
    public class UsuarioAPIController : Controller
    {
        string baseurl = "http://localhost:50729/";

        public async Task<ActionResult> Index()
        {
            List<Usuario> aux = new List<Usuario>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage res = await client.GetAsync("api/Usuario");

                if (res.IsSuccessStatusCode)
                {
                    var auxRes = res.Content.ReadAsStringAsync().Result;

                    aux = JsonConvert.DeserializeObject<List<Usuario>>(auxRes);
                }
            }
            return View(aux);

            //return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Usuario entidad)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseurl);

                var myContent = JsonConvert.SerializeObject(entidad);
                var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var postTask = client.PostAsync("api/Usuario", byteContent).Result;

                var result = postTask;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            ModelState.AddModelError(string.Empty, "Server Error, Please contact administrator");
            return View(entidad);
        }

        // GET: PaisW/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            Usuario aux = new Usuario();
            aux = await GetUsuario(id, aux);
            return View(aux);
        }

        // GET: PaisW/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Usuario aux = new Usuario();
            var Usuario = await GetUsuario(id, aux);
            if (Usuario == null)
            {
                return NotFound();
            }
            return View(Usuario);
        }

        // POST: PaisW/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idUsuario,nomUsuario,contrasena,idTipoUsuario,apellido1,apellido2,correo,direccion,telefono")] Usuario usuario)
        {
            if (id != usuario.idUsuario)
            {
                return NotFound();
            }

            //try
            //{
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseurl);

                var myContent = JsonConvert.SerializeObject(usuario);
                var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var postTask = client.PutAsync("api/Usuario/" + id, byteContent).Result;

                var result = postTask;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error, Please contact administrator");
            return View(usuario);
            //}
            //catch (Exception ee)
            //{
            //    ModelState.AddModelError(string.Empty, "Server Error, Please contact administrator");
            //    return View(pais);
            //}
        }

        // GET: PaisW/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Usuario aux = new Usuario();
            var usuario = await GetUsuario(id, aux);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: PaisW/Delete/5
        [HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Usuario aux = new Usuario();
            var usuario = await GetUsuario(id, aux);

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseurl);

                var myContent = JsonConvert.SerializeObject(usuario);
                var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var postTask = client.DeleteAsync("api/Usuario/" + id).Result;

                var result = postTask;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            return RedirectToAction("Index");
        }


        private async Task<Usuario> GetUsuario(int? id, Usuario aux)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //HttpResponseMessage res = await client.GetAsync("api/Pais/"+id);
                HttpResponseMessage res = await client.GetAsync("api/Usuario/" + id);
                if (res.IsSuccessStatusCode)
                {
                    var auxRes = res.Content.ReadAsStringAsync().Result;

                    aux = JsonConvert.DeserializeObject<Usuario>(auxRes);
                }
            }

            return aux;
        }

    }
}