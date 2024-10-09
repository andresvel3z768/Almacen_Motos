using Almacen_Motos.Clases;
using Almacen_Motos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Almacen_Motos.Controllers
{
    [RoutePrefix("api/repuestos")]
    public class RepuestoController : ApiController
    {
        [HttpGet]
        [Route("consultar")]
        public respuestos ConsultarXcodigo(string Nombre)
        {
            ClsRepuesto clsRepuesto = new ClsRepuesto();
            return clsRepuesto.Consultar(Nombre);
        }
        [HttpPost]
        [Route("insetar")]
        public string insertar([FromBody] respuestos Respuesto)
        {
            ClsRepuesto _repuesto = new ClsRepuesto();
            _repuesto.repuesto = Respuesto;
            return _repuesto.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] respuestos Respuesto)
        {
            ClsRepuesto _repuesto = new ClsRepuesto();
            _repuesto.repuesto = Respuesto;
            return _repuesto.Actualizar();
        }
        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] respuestos Respuesto)
        {
            ClsRepuesto _Repuesto = new ClsRepuesto();
            _Repuesto.repuesto = Respuesto;
            return _Repuesto.Eliminar();
        }
    }
}