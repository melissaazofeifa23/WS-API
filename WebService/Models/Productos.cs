using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService.Models
{
    public class Productos
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public string Fotografia { get; set; }
    }
}