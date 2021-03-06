using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using ProyectoCorrespondencias.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ProyectoCorrespondencias.Controllers
{
    public class HomeController : Controller
    {
        public string xhtml = "";
        public IActionResult Index()
        {
            using (CorrespondenciasContext db = new CorrespondenciasContext())
            {
                ViewBag.Destinatarios = Destinatario();
                return View(db.Plantillas.ToList());
            }
        }

        public IList<Destinatario> Destinatario()
        {
            IList<Destinatario> destinatario = new List<Destinatario>();

            using (CorrespondenciasContext db = new CorrespondenciasContext())
            {

                destinatario = db.Destinatarios.ToList();
            }
            return destinatario;
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Plantilla plantilla)
        {
            try
            {
                if (HttpContext.Session.GetString("Destinatario") != null)
                {
                    var destinatario = JsonConvert.DeserializeObject<List<Destinatario>>(HttpContext.Session.GetString("Destinatario"));

                    using (CorrespondenciasContext db = new CorrespondenciasContext())
                    {
                        plantilla.Contacto = "exito";
                        db.Plantillas.Add(plantilla);
                        db.SaveChanges();

                        foreach (var item in destinatario)
                        {
                            Destinatario siExiste = db.Destinatarios.Find(item.Id);

                            siExiste.IdPlantilla = plantilla.Id;
                            db.Entry(siExiste).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                            db.SaveChanges();
                            EnviarCorreo(siExiste, plantilla);
                        }
                        HttpContext.Session.Remove("Destinatario");
                        return RedirectToAction("Index");
                    }

                }
            }
            catch (Exception e)
            {
                var mensaje = e.Message;
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }



        public bool EnviarCorreo(Destinatario destinatario, Plantilla plantilla)
        {
            CorreoTemplate TemplatesEmail = new CorreoTemplate();
            xhtml = "";
            plantilla.Contacto = destinatario.Nombre;
            xhtml = TemplatesEmail.TemplateCorreo(plantilla, "");
            string emailOrigen = "ingresa tu correo ";
            string password = "ingresa tu password";

            MailMessage mailMessage = new MailMessage(emailOrigen, destinatario.Correo, "Test", xhtml);

            mailMessage.SubjectEncoding = System.Text.Encoding.UTF8;
            mailMessage.BodyEncoding = System.Text.Encoding.UTF8;
            mailMessage.Priority = MailPriority.High;
            mailMessage.IsBodyHtml = true;

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Port = 587;
            smtpClient.Credentials = new System.Net.NetworkCredential(emailOrigen, password);
            smtpClient.Send(mailMessage);
            smtpClient.Dispose();
            return true;
        }

        public IActionResult Edit(int id)
        {
            try
            {
                using (CorrespondenciasContext db = new CorrespondenciasContext())
                {
                    Plantilla siExiste = db.Plantillas.Find(id);
                    return View(siExiste);
                }
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Edit(Plantilla plantilla)
        {
            try
            {
                using (CorrespondenciasContext db = new CorrespondenciasContext())
                {
                    Plantilla siExiste = db.Plantillas.Find(plantilla.Id);

                    siExiste.Titulo = plantilla.Titulo;
                    siExiste.Descripcion = plantilla.Descripcion;
                    siExiste.Fecha = plantilla.Fecha;
                    siExiste.Direccion = plantilla.Direccion;
                    siExiste.Contribucion = plantilla.Contribucion;
                    siExiste.Contacto = plantilla.Contacto;
                    db.Entry(siExiste).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception e)
            {
                var mensaje = e.Message;
                return View();
            }
        }

        public IActionResult Details(int id)
        {
            try
            {
                using (CorrespondenciasContext db = new CorrespondenciasContext())
                {
                    Plantilla siExiste = db.Plantillas.Find(id);
                    siExiste.Destinatarios = DestinatarioIdPlantilla(siExiste.Id);

                    return View(siExiste);
                }
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
        }

        public IList<Destinatario> DestinatarioIdPlantilla(int id)
        {
            IList<Destinatario> destinatario = new List<Destinatario>();

            using (CorrespondenciasContext db = new CorrespondenciasContext())
            {
                destinatario = db.Destinatarios.Where(e => e.IdPlantilla == id).ToList();
            }
            return destinatario;
        }

        public IActionResult Delete(int id)
        {
            try
            {
                using (CorrespondenciasContext db = new CorrespondenciasContext())
                {
                    Plantilla siExiste = db.Plantillas.Find(id);
                    return View(siExiste);
                }
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Delete(Plantilla plantilla)
        {
            try
            {
                using (CorrespondenciasContext db = new CorrespondenciasContext())
                {
                    Plantilla siExiste = db.Plantillas.Find(plantilla.Id);
                    db.Remove(siExiste);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {
                return RedirectToAction("Delete");
            }
        }

        [HttpPost]
        public IActionResult ActualizaSession(int id)
        {
            addIdSession(id);
            return Ok();
        }

        public void addIdSession(int id)
        {
            var aadestinatarios = new List<Destinatario>();
            using (CorrespondenciasContext db = new CorrespondenciasContext())
            {
                Destinatario siExiste = db.Destinatarios.Find(id);
                if (siExiste != null)
                {
                    TempData["UsuarioAgregado"] = "Usuario Agregado" + siExiste.Nombre;
                    if (HttpContext.Session.GetString("Destinatario") != null)
                    {
                        var destinatario = JsonConvert.DeserializeObject<List<Destinatario>>(HttpContext.Session.GetString("Destinatario"));
                        destinatario.Add(siExiste);
                        HttpContext.Session.SetString("Destinatario", JsonConvert.SerializeObject(destinatario));
                    }
                    else
                    {
                        aadestinatarios.Add(siExiste);
                        HttpContext.Session.SetString("Destinatario", JsonConvert.SerializeObject(aadestinatarios));
                    }
                }
            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
