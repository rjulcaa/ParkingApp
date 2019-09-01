using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ParqueoUPC.BL.BC;
using ParqueoUPC.DL.DataModel;
namespace ParqueoUPC.UI
{
    public partial class FrmAdminEspacios : Form
    {
        private EspacioBC objEspacioBC;
        private PisoBC objPisoBC;
        public bool Crear = false;
        public bool Eliminar = false;
        int NumPisoActual = 1;
        int NumPisoMaximo=0;
        int IDPisoActual = 0;
        public FrmAdminEspacios()
        {
            InitializeComponent();
          
        }

        private void pngEspacios_Paint(object sender, PaintEventArgs e)
        {
           
         

        }

        private void pngEspacios_MouseClick(object sender, MouseEventArgs e)
        { 

            if (!Crear)
                return;
            Espacio objEspacio =new Espacio();
           
            objEspacio.x = e.X;
            objEspacio.y = e.Y;
            objEspacio.PisoId = NumPisoActual;
            objEspacio.Alto = 30;
            objEspacio.Ancho = 30;
           
            objEspacio.Ocupado = false;


            objEspacioBC.InsertarEspacios(objEspacio);
            Crear = false;
        }

        private void btnArriba_Click(object sender, EventArgs e)
        {
           
            PisoBC objPisoBC = new PisoBC();
            NumPisoMaximo = objPisoBC.geTPiso();
            if (NumPisoActual == NumPisoMaximo)
            {
                MessageBox.Show("No Existen mas pisos Disponibles");
                return;
            }
            if (NumPisoActual >= 1)
                NumPisoActual++;
           
               
            panel3.Refresh();
          
        }

        private void brtAbajo_Click(object sender, EventArgs e)
        {
            if (NumPisoActual == 1)
                return;
            else
            {
                NumPisoActual--;
            }
            panel3.Refresh();
        }

        private void btnAumentarPiso_Click(object sender, EventArgs e)
        { 
            
            try
            {
                PisoBC objPisoBC = new PisoBC();
                Piso objpiso = new Piso();

                

                objpiso.NroPiso=objPisoBC.geTPiso();
               
                 ++objpiso.NroPiso;
                objPisoBC.PisoInsertar(objpiso);
                NumPisoMaximo = objpiso.NroPiso;
                panel3.Refresh();

                MessageBox.Show("Se creo el piso " + Convert.ToString(objpiso.NroPiso) + " Satisfactoriamte", "Parqueo UPC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch(Exception ex){
                MessageBox.Show("Error en la creacion de pisos");
            }
        }

        private void btnInsertaEspacio_Click(object sender, EventArgs e)
        { 
               PisoBC objPisoBC = new PisoBC();
               if (Eliminar)
               {
                   if (MessageBox.Show("Usted esta en modo eliminar espacio ¿Desea Salir de este modo y entrar en modo insertar ?", "Parqueo UPC", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                   {
                       Eliminar= false;
                        Crear= true;
                       return;
                   }
                   else
                   {
                       return;
                   }
               }
               Crear=true;
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmAdminEspacios_Load(object sender, EventArgs e) 
        {
            objEspacioBC = new EspacioBC();
            objPisoBC = new PisoBC();
        }

        private void FrmAdminEspacios_Paint(object sender, PaintEventArgs e)
        {
         
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
            objEspacioBC.DibujarEspacios(e.Graphics, objPisoBC.IdPisoMaximo(NumPisoActual),imgAutoC.Image,imgAutoS.Image);
            lblPisoi.Text = Convert.ToString(NumPisoActual);
           
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (!Crear)
                    return;

                Espacio objEspacio = new Espacio();
                EspacioBC objEspacioBC1 = new EspacioBC();
                if (objEspacioBC1.Colisiona(e.X, e.Y, objPisoBC.IdPisoMaximo(NumPisoActual)))
                {
                    MessageBox.Show("Los Espacios Colisionan , no se puede crear este espacio");
                    Crear = false;
                    return;
                }
                objEspacio.x = e.X;
                objEspacio.y = e.Y;
                objEspacio.PisoId = objPisoBC.IdPisoMaximo(NumPisoActual);

                objEspacio.Alto = 30;
                objEspacio.Ancho = 30;

                objEspacio.Ocupado = false;


                objEspacioBC1.InsertarEspacios(objEspacio);
                Crear = false;
                panel3.Refresh();
            }
            catch (Exception ex)
            { 
            
            
            }
        }

        private void panel3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            
            if(Eliminar)
            {
               if(objEspacioBC.EstaSeleccionado(e.X, e.Y, NumPisoActual))
                   MessageBox.Show("Se elimino correctamente el espacio");
               else
                   MessageBox.Show("El espacio esta ocupado por un cliente, no se puede eliminar");
              }
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        { 
            
            if (objEspacioBC.EstaSeleccionado(e.X, e.Y, NumPisoActual))
               
            {
                if(Crear)
                this.Cursor = Cursors.No;
               if(Eliminar)
                this.Cursor = Cursors.Cross;
            }
            else  
             {
                this.Cursor=Cursors.Default;
            }
          

        }

        private void ntnEliminarEspacio_Click(object sender, EventArgs e)
        {   
            if(Crear)
            {
                if (MessageBox.Show("Usted esta en modo crear espacio ¿Desea Salir de este modo y entrar en moddo eliminar ?", "Parqueo UPC", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Crear = false;
                    Eliminar = true;
                    return;
                }
                else
                {
                    return;
                }
            }
            Eliminar = true;
        }

    }
}
