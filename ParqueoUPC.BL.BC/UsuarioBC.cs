using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

using ParqueoUPC.DL.DataModel;

namespace ParqueoUPC.BL.BC
{
    public class UsuarioBC
    {
       /* public List<Usuario> UsuarioListar()
        {   
            ParqueoUPCEntities context = new ParqueoUPCEntities();
            return context.Usuario.ToList(); 
        }
        */
        public int UsuarioIdActual=9;


       /*public int GetUsuarioId()
       {
           ParqueoUPCEntities context = new ParqueoUPCEntities();
       }
        */
       public IEnumerable<Object> UsuarioListar()
        {
            ParqueoUPCEntities context = new ParqueoUPCEntities();
           
           return (from c in context.Usuario  
                 
                    select new
                    {
                      UsuarioId=c.UsuarioId,
                      Nombre=c.Nombre,
                      Apellidos=c.Apellidos,
                      DniUsuario=c.DniUsuario,
                      UsuarioL=c.UsuarioL,
                      Password=c.Password,
                      DTipoUsuario=c.TipoUsuario.DTipoUsuario,
                    }).ToList();
        }
        public Usuario ObternerDatos( string usuario, string password )
        {

            ParqueoUPCEntities context = new ParqueoUPCEntities();
            Usuario objusuario = context.Usuario.FirstOrDefault(X=> X.UsuarioL == usuario && X.Password == password);
         //   UsuarioIdActual = objusuario.UsuarioId;
            return objusuario;
        }
        public Usuario GetUsuario(String NombreLongin)
        {
            ParqueoUPCEntities context = new ParqueoUPCEntities();
            Usuario objusuario = context.Usuario.FirstOrDefault(X => X.UsuarioL == NombreLongin);
            return objusuario;
        }
        public void UsuarioInsertar(Usuario objUsuario)
        {
            ParqueoUPCEntities context = new ParqueoUPCEntities();
            context.Usuario.Add(objUsuario);
            context.SaveChanges();
        }
        
        public void UsuarioActualizar(Usuario objUsuario)
        {
            ParqueoUPCEntities context = new ParqueoUPCEntities();
            Usuario objUsuarioOri = context.Usuario.FirstOrDefault(X => X.UsuarioId == objUsuario.UsuarioId);
            objUsuarioOri.Nombre = objUsuario.Nombre;
            objUsuarioOri.Password = objUsuario.Password;
           // objUsuarioOri.TipoUsuario = objUsuario.TipoUsuario;
            objUsuarioOri.TipoUsuarioId = objUsuario.TipoUsuarioId;
            objUsuarioOri.UsuarioL = objUsuario.UsuarioL;
            objUsuarioOri.Apellidos = objUsuario.Apellidos;
            objUsuarioOri.DniUsuario = objUsuario.DniUsuario;
            context.SaveChanges();
        }
        public void UsuarioEliminar(int UsuarioId)
        {
            ParqueoUPCEntities context = new ParqueoUPCEntities();
            Usuario objUsuario = context.Usuario.FirstOrDefault(X => X.UsuarioId == UsuarioId);
            context.Usuario.Remove(objUsuario);
            context.SaveChanges();
        }
        public Usuario UsuarioObtener(int UsuarioId)
        {
            ParqueoUPCEntities context = new ParqueoUPCEntities();
            return context.Usuario.FirstOrDefault(X => X.UsuarioId == UsuarioId);
        }
       
    }
}
