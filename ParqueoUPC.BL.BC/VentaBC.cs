using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ParqueoUPC.DL.DataModel;

using System.IO;
using iTextSharp.text.pdf;
namespace ParqueoUPC.BL.BC
{
    public class VentaBC
    {
      
        public IEnumerable<Object> ClienteListarFiltro(String Tipo)
        {
            ParqueoUPCEntities context = new ParqueoUPCEntities();

            return (from c in context.Venta
                    where c.Cliente.TipoCliente.DTipoCliente.Contains(Tipo)
                    select new
                    {
                        //ClienteId = c.ClienteId,
                        Nombre = c.Cliente.Nombre,
                        Apellidos = c.Cliente.Apellidos,
                        Dni = c.Cliente.Dni,
                        EstadoPago=c.EstadoPago,
                        FechayHoraInicio=c.FechayHoraAlquilerInicio,
                        //TipoClienteId=c.TipoClienteId,
                        DTipoCliente = c.Cliente.TipoCliente.DTipoCliente,
                        NumeroEspacio=c.Espacio.EspacioId,
                        NumeroPiso=c.Espacio.Piso.NroPiso,
                    }).ToList();
        }

        public IEnumerable<Object> ClienteListarBusqueda(String Nombre1)
        {
            ParqueoUPCEntities context = new ParqueoUPCEntities();
          
            return (from c in context.Venta
                    where c.Cliente.Nombre.Contains(Nombre1) || c.Cliente.Dni.Contains(Nombre1)
                    select new
                    {
                        
                        Nombre = c.Cliente.Nombre,
                        Apellidos = c.Cliente.Apellidos,
                        Dni = c.Cliente.Dni,
                        NumeroEspacio = c.Espacio.EspacioId,
                        NumeroPiso = c.Espacio.Piso.NroPiso,
                     //   TipoClienteId=c.TipoClienteId,
                  

                    }).ToList();
        }

        public void InsertarVenta(Venta objVenta)
        {
            
            ParqueoUPCEntities context = new ParqueoUPCEntities();
   
            context.Venta.Add(objVenta);
 
            context.SaveChanges();
            
        }
      
        public List<Venta> VentaListar()
        {

            ParqueoUPCEntities context = new ParqueoUPCEntities();
            return context.Venta.ToList();

        }

        public void VentaActualizar(Venta objVenta)
        {
            ParqueoUPCEntities context = new ParqueoUPCEntities();
            Venta objVentaOri = context.Venta.FirstOrDefault(X => X.ClienteId == objVenta.ClienteId);
            objVentaOri.UsuarioId = objVenta.UsuarioId;
            objVentaOri.FechayHoraAlquilerInicio = objVenta.FechayHoraAlquilerInicio;
            objVentaOri.EspacioId = objVenta.EspacioId;
            objVentaOri.Espacio.Ocupado = objVenta.Espacio.Ocupado;
            objVentaOri.EstadoPago = objVenta.EstadoPago;
            context.SaveChanges();
        }
        public void VentaEliminar(int VentaId)
        {
            ParqueoUPCEntities context = new ParqueoUPCEntities();
            Venta objVenta = context.Venta.FirstOrDefault(X => X.VentaId == VentaId);
            context.Venta.Remove(objVenta);
            context.SaveChanges();
        }
        public Venta VentaObtener(int VentaId)
        {
            ParqueoUPCEntities context = new ParqueoUPCEntities();
            return context.Venta.FirstOrDefault(X => X.VentaId == VentaId);
        }
    }
}
