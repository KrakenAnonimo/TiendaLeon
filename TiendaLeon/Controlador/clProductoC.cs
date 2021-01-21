using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLeon.Dato;
using TiendaLeon.Entidad;

namespace TiendaLeon.Controlador
{
    class clProductoC
    {//Metodo registrar Productos
        public int mtdRegistrarProducto(clProductoE objDatos)
        {
            clProductoD objProducto = new clProductoD();
            int regi = objProducto.mtdRegistrarProducto(objDatos);
            return regi;
        }

        //Metodo Listar Productos
        public List<clProductoE> mtdListarProducto()
        {
            clProductoD objProducto = new clProductoD();
            List<clProductoE> ListaProducto = new List<clProductoE>();
            ListaProducto = objProducto.mtdListarProducto();
            return ListaProducto;
        }

        //Metodo Eliminar Productos
        public int mtdEliminarProducto(clProductoE objDatos)
        {
            clProductoD objProducto = new clProductoD();
            int eliminar = objProducto.mtdEliminarProducto(objDatos);
            return eliminar;
        }

        //Metodo Actualizar Productos
        public int mtdActualizarProducto(clProductoE objDatos)
        {
            clProductoD objProducto = new clProductoD();
            int Actualizar = objProducto.mtdActualizarProducto(objDatos);
            return Actualizar;
        }
    }
}
