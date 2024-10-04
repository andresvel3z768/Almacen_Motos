using Almacen_Motos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Almacen_Motos.Clases
{
    public class ClsRepuesto
    {
        private repuestos_motosEntities Repuesto =new repuestos_motosEntities();
        public respuestos repuesto { get; set; }
        public string Insertar()
        {
            try
            {
                //Para grabar en la base de datos con EF, solo se invoca el método .add de la clase que se quiere gestionar
                Repuesto.respuestos.Add(repuesto);
                //Se debe grabar en la información con el método .savechanges();
                Repuesto.SaveChanges();
                //Retorna la respuesta
                return "se ingreso el repuesto correctamente ";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Actualizar()
        {
            try
            {
                Repuesto.respuestos.AddOrUpdate(repuesto);
                Repuesto.SaveChanges();
                return "Se actualizaron los datos del repuesto " + repuesto.Nombre_repuesto;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Eliminar()
        {
            try
            {
                //Hay que consultar el cliente, como el método devuelve un objeto de tipo cliente, debo crear una instancia de la clase CLIEnte
                respuestos _repuesto = Consultar(repuesto.Nombre_repuesto);
                //Se valida si el cliente existe para eliminarlo
                if (_repuesto == null)
                {
                    //El cliente no existe
                    return "El cliente no se encuentra en la base de datos";
                }
                else
                {

                    Repuesto.respuestos.Remove(_repuesto);
                    Repuesto.SaveChanges();
                    return "Se eliminó el repuesto: " + _repuesto.Nombre_repuesto + " " + _repuesto.Codigo;
                }
            }
            catch (Exception ex)
            {
                return "Debes tener problema para eliminar ,elimina el servcio para elimar el repuesto " + ex.Message;
            }
        }
        public respuestos Consultar(string Nombre)
        {
            
            //Las expresiones lambda, son "variables" que se convierten en una instancia del objeto que se está "trabajando"
            //Se escribe la "variable" seguido de la instrución "=>"
            return Repuesto.respuestos.FirstOrDefault(R=>R.Nombre_repuesto==Nombre);
        }
    }
}