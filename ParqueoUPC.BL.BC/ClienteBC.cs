using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using ParqueoUPC.DL.DataModel;
namespace ParqueoUPC.BL.BC
{
   public class ClienteBC
    {

        public List<Cliente> ClienteListar()
        { 
            
            ParqueoUPCEntities context = new ParqueoUPCEntities();
            return context.Cliente.ToList();
           
        }

        
        public void ClienteInsertar(Cliente objCliente)
        {
            ParqueoUPCEntities context = new ParqueoUPCEntities();
            context.Cliente.Add(objCliente);
            context.SaveChanges();
        }
        public void ClienteActualizar(Cliente objCliente)
        {
            ParqueoUPCEntities context = new ParqueoUPCEntities();
            Cliente objClienteOri = context.Cliente.FirstOrDefault(X => X.ClienteId == objCliente.ClienteId);
            objClienteOri.Nombre = objCliente.Nombre;         
            objClienteOri.TipoCliente = objCliente.TipoCliente;
            objClienteOri.Apellidos = objCliente.Apellidos;
            objClienteOri.Dni = objCliente.Dni;
            context.SaveChanges();
        }
        public void ClienteEliminar(int ClienteId)
        {
            ParqueoUPCEntities context = new ParqueoUPCEntities();
            Cliente objCliente = context.Cliente.FirstOrDefault(X => X.ClienteId == ClienteId);
            context.Cliente.Remove(objCliente);
            context.SaveChanges();
        }
        public Cliente ClienteObtener(int ClienteId)
        {
            ParqueoUPCEntities context = new ParqueoUPCEntities();
            return context.Cliente.FirstOrDefault(X => X.ClienteId == ClienteId );
        }
        public int  ClienteObtenerDNI(String DNI)
        {
            int aux;
            ParqueoUPCEntities context = new ParqueoUPCEntities();
           Cliente objCliente=context.Cliente.FirstOrDefault(X => X.Dni == DNI);
           aux = objCliente.ClienteId;
           return aux;
        }
        public int ObtenerTipoCliente(int EspacioId, int IdTipoCliente)
        {
            
            ParqueoUPCEntities context = new ParqueoUPCEntities();
            Venta objventa = context.Venta.FirstOrDefault(X=>X.Cliente.TipoClienteId==IdTipoCliente && X.EspacioId==EspacioId);
            if (objventa == null)
                return 0;
            else return objventa.Cliente.TipoClienteId;
        }
    }
}
