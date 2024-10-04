using Almacen_Motos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Almacen_Motos.Clases
{
    public class ClsServicio
    {
        private repuestos_motosEntities Servicio = new repuestos_motosEntities();

        public servicio_mecanica servicio_ { get; set; }

        public string insertar()
        {
            Servicio.servicio_mecanica.Add(servicio_);
            Servicio.SaveChanges();
            return "se inserto un servicio felicidades";
        }
    }
}