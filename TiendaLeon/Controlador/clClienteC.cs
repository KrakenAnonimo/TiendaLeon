using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLeon.Dato;
using TiendaLeon.Entidad;

namespace TiendaLeon.Controlador
{
    class clClienteC
    {
        //Metodo registrar Clientes
        public int mtdRegistrarCliente(clClienteE objDatos)
        {
            clClienteD objCliente = new clClienteD();
            int regi = objCliente.mtdRegistrarCliente(objDatos);
            return regi;
        }

        //Metodo Listar Clientes
        public List<clClienteE> mtdListarCliente()
        {
            clClienteD objCliente = new clClienteD();
            List<clClienteE> ListaCliente = new List<clClienteE>();
            ListaCliente = objCliente.mtdListarCliente();
            return ListaCliente;
        }

        //Metodo Eliminar Clientes
        public int mtdEliminarCliente(clClienteE objDatos)
        {
            clClienteD objCliente = new clClienteD();
            int eliminar = objCliente.mtdEliminarCliente(objDatos);
            return eliminar;
        }

        //Metodo Actualizar Clientes
        public int mtdActualizarCliente(clClienteE objDatos)
        {
            clClienteD objCliente = new clClienteD();
            int Actualizar = objCliente.mtdActualizarCliente(objDatos);
            return Actualizar;
        }





    }
}
