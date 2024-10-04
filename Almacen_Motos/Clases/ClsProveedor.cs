using Almacen_Motos.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Almacen_Motos.Clases
{
    public class ClsProveedor
    {
        private repuestos_motosEntities Repuestos_ = new repuestos_motosEntities();
        public proveedor Proveedor { get; set; }

        public proveedor consultar(int codigo) 
        {
            return Repuestos_.proveedor.FirstOrDefault(P=>P.codigo == codigo);
        }

        public string insertar(proveedor Proveedor) 
        {
            try
            {
                Repuestos_.proveedor.Add(Proveedor);
                Repuestos_.SaveChanges();
                return "se inserto el proveedor en la base de datos";
            }
            catch (Exception ex) 
            {
                return (ex.Message);
            }
        }
    }
}