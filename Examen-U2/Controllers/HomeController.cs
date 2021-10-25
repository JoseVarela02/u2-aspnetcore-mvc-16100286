using Examen_U2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_U2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }



        public IActionResult AgregarObjeto()
        {
            return View();
        }

        public IActionResult ListaObjetos()
        {
            return View(Datos.Objetos);
        }

        [HttpPost]

        public IActionResult AgregarObjeto(Productos pro)

        {
            if(ModelState.IsValid)
            {
                Datos.AgregarProducto(pro);
                return View("RegistroExitoso", pro);
            }
            else
            {
                return View("AgregarObjeto");
            }
        }

        public IActionResult EditarObjeto(int codprodu)
        {
            Productos productos = Datos.Objetos.Where(e => e.CodigoProducto == codprodu).FirstOrDefault();

            return View(productos);

        }
        [HttpPost]
        public IActionResult EditarObjeto(Productos produc)
        {
            Productos productos = Datos.Objetos.Where(e => e.CodigoProducto == produc.CodigoProducto).FirstOrDefault();

            productos.NombreProducto = produc.NombreProducto;
            productos.ProductosEnExistencia = produc.ProductosEnExistencia;
            productos.Precio = produc.Precio;


            return RedirectToAction("ListaObjetos");

        }

        public IActionResult ConfirmarEliminar(int Producto)
        {
            return RedirectToAction("ListaObjetos");
        }

        public IActionResult EliminarObjeto(int codproduc)
        {
            Productos productos = Datos.Objetos.Where(e => e.CodigoProducto ==  codproduc).FirstOrDefault();

            return View(productos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
