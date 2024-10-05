using Almacen_Motos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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

        public string insertar() 
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

        public string actualizar() 
        {
            try
            {
                Repuestos_.proveedor.AddOrUpdate(Proveedor);
                Repuestos_.SaveChanges();
                return "se actualizo correctamente";

            }catch (Exception ex) {return ex.Message; }
        }
        public string Eliminar()
        {
            try
            {
                //Hay que consultar el cliente, como el método devuelve un objeto de tipo cliente, debo crear una instancia de la clase CLIEnte
                proveedor _Proveedor = consultar(Proveedor.codigo);
                //Se valida si el cliente existe para eliminarlo
                if (_Proveedor == null)
                {
                    //El cliente no existe
                    return "El proveedor no se encuentra en la base de datos";
                }
                else
                {

                    Repuestos_.proveedor.Remove(Proveedor);
                    Repuestos_.SaveChanges();
                    return "Se eliminó el proveedor: "+Proveedor.nombre;
                }
            }
            catch (Exception ex)
            {
                return "Debes tener problema para eliminar ,elimina primero las dependencias antes de eliminar " + ex.Message;
            }
        }
    }
}