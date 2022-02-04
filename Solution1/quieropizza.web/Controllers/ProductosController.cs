using quieropizza.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace quieropizza.web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var producto1 = new ProductoModel();
            producto1.id = 1;
            producto1.Descripcion = "pizza 6 quesos";

            var producto2 = new ProductoModel();
            producto2.id = 2;
            producto2.Descripcion = "Pizza Hawaiana";

            var producto3 = new ProductoModel();
            producto3.id = 3;
            producto3.Descripcion = "Calzone";

            var producto4 = new ProductoModel();
            producto4.id = 4;
            producto4.Descripcion = "Rotini en salsa Alfredo";

            var listadeProductos = new List<ProductoModel>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);
            listadeProductos.Add(producto4);


            return View(listadeProductos);
        }
    }
}