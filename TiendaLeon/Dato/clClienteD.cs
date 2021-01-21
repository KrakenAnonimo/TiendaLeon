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
    class clClienteD
    {
        //Metodo registrar CLIENTES
        public int mtdRegistrarCliente(clClienteE objDatos)
        {
            string sqlInsert = "insert into CLIENTES(Documento,Telefono,Nombre,Apellido,Genero)" +
            "values('" + objDatos.Documento + "','" + objDatos.Telefono + "','" + objDatos.Nombre + "','" + objDatos.Apellido + "','" + objDatos.Genero + "')";

            clMetodoConexion objMtdCN = new clMetodoConexion();
            int result = objMtdCN.mtdConectado(sqlInsert);

            return result;
        }

        //Metodo Eliminar CLIENTES
        public int mtdEliminarCliente(clClienteE objDatos)
        {
            string consulta = "Delete from CLIENTES where Nombre = '" + objDatos.Nombre + "'";
            clMetodoConexion objMtdCN = new clMetodoConexion();
            int result = objMtdCN.mtdConectado(consulta);

            return result;
        }

        //Metodo Listar CLIENTES
        public List<clClienteE> mtdListarCliente()
        {
            string consulta = "select * from CLIENTES";
            clMetodoConexion objMtdCN = new clMetodoConexion();
            DataTable tblDatos = new DataTable();
            tblDatos = objMtdCN.mtdDesconectado(consulta);

            List<clClienteE> ListaCliente = new List<clClienteE>();
            for (int i = 0; i < tblDatos.Rows.Count; i++)
            {
                clClienteE objPasDatos = new clClienteE();
                objPasDatos.IdCliente = int.Parse(tblDatos.Rows[i][0].ToString());
                objPasDatos.Documento = int.Parse(tblDatos.Rows[i][1].ToString());
                objPasDatos.Nombre = tblDatos.Rows[i][2].ToString();
                objPasDatos.Apellido = tblDatos.Rows[i][3].ToString();
                objPasDatos.Genero = tblDatos.Rows[i][4].ToString();
                objPasDatos.Telefono = int.Parse(tblDatos.Rows[i][5].ToString());
                ListaCliente.Add(objPasDatos);
            }
            return ListaCliente;
        }

        //Metodo Actualizar CLIENTES
        public int mtdActualizarCliente(clClienteE objDatos)
        {
            string consulta = "Update CLIENTES set Nombre = '" + objDatos.Nombre + "', Apellido = '" + objDatos.Apellido + "', Telefono = '" + objDatos.Telefono + "', Documento = '" + objDatos.Documento + "'where IdCliente = '" + objDatos.IdCliente + "'";
            clMetodoConexion objMtdCN = new clMetodoConexion();
            int regis = objMtdCN.mtdConectado(consulta);
            return regis;
        }

    }
}
