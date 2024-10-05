using Almacen_Motos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
            try
            {
                Servicio.servicio_mecanica.Add(servicio_);
                Servicio.SaveChanges();
                return "se inserto un servicio felicidades";
            }catch (Exception ex) { return ex.Message; }
        }

        public string actualizar() 
        {
            try
            {
                Servicio.servicio_mecanica.AddOrUpdate(servicio_);
                Servicio.SaveChanges();
                return "se actuzalizo correctamente el servicio adicional ";
            }catch (Exception ex) {return ex.Message;}
        }

        public string Eliminar() 
        {
            try
            {
                servicio_mecanica _Servicio = consultar(servicio_.Codigo_servicio);
                if (_Servicio == null)
                {
                    return "el servicio no esta en la base de datos insertar servicio";
                }
                else
                {
                    Servicio.servicio_mecanica.Remove(_Servicio);
                    Servicio.SaveChanges ();
                    return "se elimino el servicio";
                }
            }
            catch (Exception ex) { return "no se puede eliminar el servicio sin eliminar su dependientes "+ex.Message; }
        }

        public servicio_mecanica consultar(int codigo) 
        { 
            return Servicio.servicio_mecanica.FirstOrDefault(C=> C.Codigo_servicio == codigo);
        }
    }
}