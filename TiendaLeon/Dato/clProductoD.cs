using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLeon.Conexion;
using TiendaLeon.Entidad;

namespace TiendaLeon.Dato
{
    class clProductoD
    {
        //Metodo registrar PRODUCTOS
        public int mtdRegistrarProducto(clProductoE objDatos)
        {
            string sqlInsert = "insert into PRODUCTOS(Precio,Nombre,Cantidad)" +
            "values('" + objDatos.Precio + "','" + objDatos.Nombre + "','" + objDatos.Cantidad + "')";

            clMetodoConexion objMtdCN = new clMetodoConexion();
            int result = objMtdCN.mtdConectado(sqlInsert);

            return result;
        }

        //Metodo Eliminar PRODUCTOS
        public int mtdEliminarProducto(clProductoE objDatos)
        {
            string consulta = "Delete from PRODUCTOS where Nombre = '" + objDatos.Nombre + "'";
            clMetodoConexion objMtdCN = new clMetodoConexion();
            int result = objMtdCN.mtdConectado(consulta);

            return result;
        }

        //Metodo Listar PRODUCTOS
        public List<clProductoE> mtdListarProducto()
        {
            string consulta = "select * from PRODUCTOS";
            clMetodoConexion objMtdCN = new clMetodoConexion();
            DataTable tblDatos = new DataTable();
            tblDatos = objMtdCN.mtdDesconectado(consulta);

            List<clProductoE> ListaProductos = new List<clProductoE>();
            for (int i = 0; i < tblDatos.Rows.Count; i++)
            {
                clProductoE objPasDatos = new clProductoE();
                objPasDatos.IdProducto = int.Parse(tblDatos.Rows[i][0].ToString());
                objPasDatos.Precio = int.Parse(tblDatos.Rows[i][1].ToString());
                objPasDatos.Cantidad = int.Parse(tblDatos.Rows[i][2].ToString());
                objPasDatos.Nombre = tblDatos.Rows[i][3].ToString();
                ListaProductos.Add(objPasDatos);
            }
            return ListaProductos;
        }

        //Metodo Actualizar PRODUCTOS
        public int mtdActualizarProducto(clProductoE objDatos)
        {
            string consulta = "Update PRODUCTOS set Nombre = '" + objDatos.Nombre + "', Precio = '" + objDatos.Precio + "', Cantidad = '" + objDatos.Cantidad  + "'where IdProducto = '" + objDatos.IdProducto + "'";
            clMetodoConexion objMtdCN = new clMetodoConexion();
            int regis = objMtdCN.mtdConectado(consulta);
            return regis;
        }

    }
}
