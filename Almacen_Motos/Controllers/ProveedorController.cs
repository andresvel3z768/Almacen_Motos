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
    [RoutePrefix("api/Proveedor")]
    public class ProveedorController : ApiController
    {
        [HttpGet]
        [Route("consultarXcodigo")]
        public proveedor ConsultarXcodigo(int Codigo) 
        {
            ClsProveedor clsProveedor = new ClsProveedor();
            proveedor provedor = clsProveedor.consultar(Codigo);
            return clsProveedor.consultar(Codigo);
        }
        [HttpPost]
        [Route("insetar")]
        public string insertar([FromBody] proveedor Proveedor) 
        {
            ClsProveedor clsProveedor = new ClsProveedor();
            clsProveedor.Proveedor = Proveedor;
            return clsProveedor.insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] proveedor Proveedor)
        {
            ClsProveedor _proveedor = new ClsProveedor();
            _proveedor.Proveedor = Proveedor;
            return _proveedor.actualizar();
        }
        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] proveedor P_Roveedor)
        {
            ClsProveedor _proveedor = new ClsProveedor();
            _proveedor.Proveedor = P_Roveedor;
            return _proveedor.Eliminar();
        }
    }
}