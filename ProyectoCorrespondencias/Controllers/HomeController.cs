using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProyectoCorrespondencias.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCorrespondencias.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            using (CorrespondenciasContext db = new CorrespondenciasContext())
            {
                return View(db.Plantillas.ToList());
            }
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
                using (CorrespondenciasContext db = new CorrespondenciasContext())
                {
                    db.Plantillas.Add(plantilla);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
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
                    return View(siExiste);
                }
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Details(Plantilla plantilla)
        {
            return View();
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
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
