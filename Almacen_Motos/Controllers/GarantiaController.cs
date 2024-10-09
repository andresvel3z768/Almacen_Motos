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
    [RoutePrefix("api/garantias")]
    public class GarantiaController : ApiController
    {
        [HttpGet]
        [Route("consultar")]
        public garantia ConsultarXcodigo(int codigo)
        {
            ClsGarantia clsgarantia = new ClsGarantia();
            return clsgarantia.consultar(codigo);
        }
        [HttpPost]
        [Route("insetar")]
        public string insertar([FromBody] garantia GARANTIA)
        {
            ClsGarantia _garantia = new ClsGarantia();
            _garantia.Garantia = GARANTIA;
            return _garantia.insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] garantia GARANTIA)
        {
            ClsGarantia _garantia = new ClsGarantia();
            _garantia.Garantia = GARANTIA;
            return _garantia.actualizar();
        }
        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] garantia GARANTIA)
        {
            ClsGarantia _garantia = new ClsGarantia();
            _garantia.Garantia = GARANTIA;
            return _garantia.Eliminar();
        }
    }
}