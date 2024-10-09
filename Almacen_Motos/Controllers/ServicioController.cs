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
    [RoutePrefix("api/servicio")]
    public class ServicioController : ApiController
    {
        [HttpGet]
        [Route("consultar")]
        public servicio_mecanica ConsultarXcodigo(int codigo)
        {
            ClsServicio clsservi = new ClsServicio();
            return clsservi.consultar(codigo);
        }
        [HttpPost]
        [Route("insetar")]
        public string insertar([FromBody] servicio_mecanica servicio)
        {
            ClsServicio _servicio = new ClsServicio();
            _servicio.servicio_ = servicio;
            return _servicio.insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] servicio_mecanica servicio)
        {
            ClsServicio _servicio = new ClsServicio();
            _servicio.servicio_ = servicio;
            return _servicio.actualizar();
        }
        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] servicio_mecanica servicio)
        {
            ClsServicio _servicio = new ClsServicio();
            _servicio.servicio_ = servicio;
            return _servicio.Eliminar();
        }
    }
}