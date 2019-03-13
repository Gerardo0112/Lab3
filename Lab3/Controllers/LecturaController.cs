using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Informacion_Arbol;
using Lab3.Models; 

namespace Lab3.Controllers
{
    public class LecturaController : Controller
    {
        // GET: Lectura
        public ActionResult Almacen()
        {
            return View(new List<Almacen>()); 
        }
        static ArbolBinario arbol = new ArbolBinario();
        [HttpPost]
        public ActionResult Almacen(HttpPostedFileBase postedFile)
        {
            List<Almacen> almacen = new List<Almacen>();
            string filePath = string.Empty;
            if (postedFile != null)
            {
                string path = Server.MapPath("~/Uploads/");
                if(!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                filePath = path + Path.GetFileName(postedFile.FileName);
                string extension = Path.GetExtension(postedFile.FileName);
                postedFile.SaveAs(filePath);
                int contador = 0;
                string Datos = System.IO.File.ReadAllText(filePath);
                foreach (string fila in Datos.Split('\n'))
                {
                    if(!string.IsNullOrEmpty(fila) && (contador != 0))
                    {
                        Almacen productos = new Almacen();
                        productos.id = Convert.ToInt32(fila.Split(';')[0]);
                        productos.nombre = " " + fila.Split(';')[1];
                        productos.descripcion = fila.Split(';')[2];
                        productos.casafarmaceutica = fila.Split(';')[3];
                        productos.precio = Convert.ToDouble (fila.Split(';')[4]);
                        productos.cantidad = Convert.ToInt32(fila.Split(';')[5]);
                        almacen.Add(productos);
                    }
                    else
                    {
                        contador++;
                    }
                }
            }
            foreach (Almacen nodo in almacen)
            {
                Medicamento medicamentos = new Medicamento();
                medicamentos.id = nodo.id;
                medicamentos.nombre = nodo.nombre;
                medicamentos.cantidad = nodo.cantidad;
                medicamentos.descripcion = nodo.descripcion;
                medicamentos.precio = nodo.precio;
                medicamentos.casafarmaceutica = nodo.casafarmaceutica;
                Nodo actual = new Nodo(medicamentos);
                arbol.Add(actual);
            }
            return View(almacen);
        }
    }
}