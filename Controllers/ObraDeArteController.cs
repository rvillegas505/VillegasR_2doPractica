using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VillegasR_2doPractica.Models;
using VillegasR_2doPractica.Servicios;

namespace VillegasR_2doPractica.Controllers
{
    public class ObraDeArteController : Controller
    {
        IObraDeArteServicio _obraDeArteServicio;

        public ObraDeArteController (IObraDeArteServicio obraDeArteServicio)
        {
            _obraDeArteServicio = obraDeArteServicio;
        }


        [HttpGet]
        public ActionResult Home()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Agregar(ObraDeArte obra)
        {
            _obraDeArteServicio.Agregar(obra);
            return RedirectToAction("ListarTodas");

        }

        [HttpGet]
        public ActionResult ListarTodas()
        {
            List<ObraDeArte> obras = _obraDeArteServicio.ObtenerTodas();
            return View(obras);
        }

        [HttpGet]
        public ActionResult sigloxix()
        {
            List<ObraDeArte> obras = _obraDeArteServicio.ObtenerSigloxix();
            return View(obras);
        }

        [HttpGet]
        public ActionResult Eliminar(int id)
        {
            _obraDeArteServicio.Eliminar(id);
            return RedirectToAction("ListarTodas");
        }

        [HttpGet]
        public ActionResult Modificar(int id)
        {
            ObraDeArte obraAModificar =  _obraDeArteServicio.ObtenerPorId(id);
            return View(obraAModificar);
            
        }

        [HttpPost]
        public ActionResult Modificar(ObraDeArte obra)
        {
            _obraDeArteServicio.Modificar(obra);
            return RedirectToAction("ListarTodas");

        }



    }
}
