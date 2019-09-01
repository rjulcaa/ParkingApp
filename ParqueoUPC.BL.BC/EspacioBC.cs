using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

using System.Data.Entity;
using ParqueoUPC.DL.DataModel;
namespace ParqueoUPC.BL.BC
{
    public class EspacioBC
    {
        Font font = new Font("Arial", 10);
        Point point;
      
        public IEnumerable<Object> ListarFiltro(bool ocupado)
        {
            ParqueoUPCEntities context = new ParqueoUPCEntities();
         return (from e in context.Espacio
                    where e.Ocupado.Equals(ocupado)
                    select new
                    {
                        EspacioId = e.EspacioId,
                       
                    }).ToList();
       }
        public Espacio GetEspacio(int EspacioId)
        {
            ParqueoUPCEntities context = new ParqueoUPCEntities();
            Espacio objEspacio = context.Espacio.FirstOrDefault(X => X.EspacioId == EspacioId);
                return objEspacio;
        
        }
        public void CambiarEstado(Espacio objEspacio)
        {
            ParqueoUPCEntities context = new ParqueoUPCEntities();
            Espacio objEspacioOri = context.Espacio.FirstOrDefault(X => X.EspacioId == objEspacio.EspacioId);
            objEspacioOri.Ocupado = true;
            context.SaveChanges();
        }
        public void InsertarEspacios(Espacio objEspacio)
        {
            ParqueoUPCEntities context = new ParqueoUPCEntities();
            context.Espacio.Add(objEspacio);
            context.SaveChanges();
        }
        /*public List<Espacio> EspacioListar()
        {
         ParqueoUPCEntities context =new ParqueoUPCEntities();
         return context.Espacio.ToList();
        }*/
        
        public void DibujarEspacios(Graphics g, int PisoId,Image c, Image s)
        {  
            
            ParqueoUPCEntities context = new ParqueoUPCEntities();
             ParqueoUPCEntities cont = new ParqueoUPCEntities();
             
          

            foreach (Espacio b in context.Espacio.ToList() )
            {
                if (b.PisoId == PisoId)
                {
                    point=new Point(b.x+b.Ancho/2-2,b.y+1);
                    g.DrawLine(Pens.White, b.x, b.y, b.x + b.Ancho, b.y);
                    g.DrawLine(Pens.White, b.x, b.y + b.Alto, b.x + b.Ancho, b.y + b.Alto);
                    g.DrawString(Convert.ToString(b.EspacioId), font, Brushes.Azure, point);
                    if(b.Ocupado==true)                    
                    g.DrawImage(c, b.x+30, b.y+30, b.Ancho-20, b.Alto/2);

                }
            }
        }

        public bool Colisiona(int px,int py,int PisoIdActual)
        {
            ParqueoUPCEntities context = new ParqueoUPCEntities();
            foreach (Espacio b in context.Espacio.ToList())
            {
                if (b.PisoId == PisoIdActual)
                    if ((px >= b.x && px <= b.x + b.Ancho && py >= b.y && py <= b.y + b.Alto)
                        || (px+b.Ancho>=px && px+b.Ancho<=b.x+b.Ancho &&  py+b.Alto>=b.y && py+b.Alto<=b.y+b.Alto))
                        return true;

            }
            return false;
        }

        public bool EstaSeleccionado(int px, int py, int PisoActual)
        {   
            ParqueoUPCEntities context = new ParqueoUPCEntities();
            foreach (Espacio b in context.Espacio.ToList())
            {
                if (b.Piso.NroPiso == PisoActual)
                    if ((px >= b.x && px <= b.x + b.Ancho && py >= b.y && py <= b.y + b.Alto))
                        return true;
            }

               return false;
        }
        public bool DevuelveEspacio(int px, int py, int Piso)
        {   
             ParqueoUPCEntities context = new ParqueoUPCEntities();
            foreach (Espacio b in context.Espacio.ToList())
            {
                if (EstaSeleccionado(px, py, Piso) && b.Ocupado == false)
                {
                   EspacioEliminar(b.EspacioId);
                    return true;
                }
                
         }
            return false;
        }


          public void EspacioEliminar(int EspacioId)
        {
            ParqueoUPCEntities context = new ParqueoUPCEntities();
            Espacio objEspacio = context.Espacio.FirstOrDefault(X => X.EspacioId == EspacioId);
            context.Espacio.Remove(objEspacio);
            context.SaveChanges();
        }
        
        public void DibujarCarros()
        { 
        
        }
       
       
    }
}
