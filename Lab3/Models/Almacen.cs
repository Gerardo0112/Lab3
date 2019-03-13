using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3.Models
{
    public class Almacen
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int cantidad { get; set; }
        public string descripcion { get; set; }
        public double precio { get; set; }
        public string casafarmaceutica { get; set; }
    }
}