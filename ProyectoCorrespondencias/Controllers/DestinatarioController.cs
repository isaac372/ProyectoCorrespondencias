using Microsoft.AspNetCore.Mvc;
using ProyectoCorrespondencias.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCorrespondencias.Controllers
{
    public class DestinatarioController : Controller
    {
        public IActionResult Index()
        {
            using (CorrespondenciasContext db = new CorrespondenciasContext())
            {
                return View(db.Destinatarios.ToList());
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Destinatario destinatario)
        {
            try
            {
                using (CorrespondenciasContext db = new CorrespondenciasContext())
                {
                    db.Destinatarios.Add(destinatario);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {
                return RedirectToAction("create");
            }
        }

        public IActionResult Edit(int id)
        {
            try
            {
                using (CorrespondenciasContext db = new CorrespondenciasContext())
                {
                    Destinatario siExiste = db.Destinatarios.Find(id);
                    return View(siExiste);
                }
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Edit(Destinatario destinatario)
        {
            try
            {
                using (CorrespondenciasContext db = new CorrespondenciasContext())
                {
                    Destinatario siExiste = db.Destinatarios.Find(destinatario.Id);

                    siExiste.Nombre = destinatario.Nombre;
                    siExiste.Correo = destinatario.Correo;
                    db.Entry(siExiste).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {
                return RedirectToAction("Edit");
            }
        }

        public IActionResult Details(int id)
        {
            try
            {
                using (CorrespondenciasContext db = new CorrespondenciasContext())
                {
                    Destinatario siExiste = db.Destinatarios.Find(id);
                    return View(siExiste);
                }
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
        }

        public IActionResult Delete(int id)
        {
            try
            {
                using (CorrespondenciasContext db = new CorrespondenciasContext())
                {
                    Destinatario siExiste = db.Destinatarios.Find(id);
                    return View(siExiste);
                }
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Delete(Destinatario destinatario)
        {
            try
            {
                using (CorrespondenciasContext db = new CorrespondenciasContext())
                {
                    Destinatario siExiste = db.Destinatarios.Find(destinatario.Id);
                    db.Remove(siExiste);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception e)
            {
                var mensaje = e.Message;
                return RedirectToAction("Delete");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
