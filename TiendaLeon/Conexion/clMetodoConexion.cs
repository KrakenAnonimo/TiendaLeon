﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaLeon.Conexion
{
    class clMetodoConexion
    {
        SqlConnection objConex = null;

        public int mtdConectado(string sql)
        {

            clConexion objConexion = new clConexion();
            objConex = objConexion.mtdConexion();
            objConex.Open();
            SqlCommand cmdSql = new SqlCommand(sql, objConex);
            int resultado = cmdSql.ExecuteNonQuery();
            objConex.Close();
            return resultado;

        }


        public DataTable mtdDesconectado(string consulta)
        {
            clConexion objConexion = new clConexion();
            objConex = objConexion.mtdConexion();
            objConex.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, objConex);
            DataTable tblDatos = new DataTable();
            adaptador.Fill(tblDatos);
            objConex.Close();
            return tblDatos;

        }
    }
}
