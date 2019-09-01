using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using ParqueoUPC.DL.DataModel;
namespace ParqueoUPC.BL.BC
{
    public class PisoBC
    {

        public List<Piso> ListaPiso()
        {
            ParqueoUPCEntities context = new ParqueoUPCEntities();
            return context.Piso.ToList();
        }
        public int geTPiso()
        {
            Piso piso =new Piso();
           piso = ListaPiso().LastOrDefault();
            
            return piso.NroPiso;
        }
        public int IdPisoMaximo(int NumeroPiso)
        {
            Piso piso = new Piso();
            piso = ListaPiso().FirstOrDefault(X => X.NroPiso == NumeroPiso);
            return piso.PisoId;
            
        }
        public void PisoInsertar(Piso objPiso)
        {
            ParqueoUPCEntities context = new ParqueoUPCEntities();
            context.Piso.Add(objPiso);
           
            context.SaveChanges();
        }
    }
}
