using Almacen_Motos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Almacen_Motos.Clases
{
    public class ClsGarantia
    {
        private repuestos_motosEntities Garantia_ = new repuestos_motosEntities();
        public garantia Garantia { get; set; }

        public garantia consultar(int codigo_garantia) 
        {
           return Garantia_.garantia.FirstOrDefault(CG=> CG.codigo== codigo_garantia);
        }

        public string insertar(garantia Garantia)
        {
            try
            {
                if (Garantia.C_Servicio == null)
                {
                    return "debes ingresar un servicio para la garantia ";
                }
                else
                {
                    Garantia_.garantia.Add(Garantia);
                    Garantia_.SaveChanges();
                    return "se ingreso la garatia correctamente";
                }
            }
            catch (Exception ex) { return ex.Message; }
        }

        public string actualizar()
        {
            try
            {
                Garantia_.garantia.AddOrUpdate(Garantia);
                Garantia_.SaveChanges();
                return "se actualizo correctamente";

            } catch (Exception ex) { return ex.Message; }   
        }

        public string Eliminar() 
        {
            try
            {
                garantia GARANTIA_ = consultar(Garantia.codigo);

                if (GARANTIA_ == null)
                {
                    return "NO SE ENCUENTRA EN LA BASE DE DATOS";
                }
                else 
                {
                    string mensaje = "debes Eliminar el repuesto para eliminar la garantia";
                    Console.WriteLine(mensaje);
                    Garantia_.garantia.Remove(Garantia);
                    Garantia_.SaveChanges();
                    return "se elimino correctamente la garantia con el codigo "+Garantia.codigo;

                }
            }
            catch (Exception ex) { return ex.Message; }
        }
    }
}