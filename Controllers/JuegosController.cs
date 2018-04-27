using FirscodeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirscodeProject.Controllers
{
    public class JuegosController : Controller
    {
        ModeloJuegos modelo;
        public JuegosController()
        {
            this.modelo = new ModeloJuegos();
        }
        // GET: Juegos
        public ActionResult Index()
        {
            List<Juego> lista = this.modelo.ListaJuegos();
            return View(lista);
        }

        public ActionResult Details(int id)
        {
            Juego juego = modelo.BuscarJuego(id);
            return View(juego);
        }

        public ActionResult Edit(int id)
        {
            Juego juego = modelo.BuscarJuego(id);
            return View(juego);
        }

        [HttpPost]
        public ActionResult Edit(Juego juego)
        {
            modelo.ModificarJuego(juego.IdJuego, juego.NombreJuego, juego.Descripcion);
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Juego juego)
        {
            modelo.InsertarJuego(juego.NombreJuego, juego.Descripcion);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            modelo.EliminarJuego(id);
            return RedirectToAction("Index");
        }

    }
}