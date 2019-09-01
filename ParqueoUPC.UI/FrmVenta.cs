using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ParqueoUPC.DL.DataModel;
using ParqueoUPC.BL.BC;

using System.IO;

namespace ParqueoUPC.UI
{
    public partial class FrmVenta : Form
    {
        String aux;
        public Usuario objUsuario { get; set; }
        public FrmVenta()
        {
            InitializeComponent();

           
        }
        private FrmLogin login;
        public void getTexto()
        {
            aux = login.txtUsuario.Text;
        }
        
      
        EspacioBC objEspacioBC = new EspacioBC();
        public enum TypeModo { UsuarioExiste, UsuarioNoExiste}
        public TypeModo Modo { get; set; }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }
       
        private void FrmVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'parqueoUPCDataSetCLiente.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.parqueoUPCDataSetCLiente.Cliente);
           // getTexto();
            try
            {
                CbNumeroEspacio.DataSource = null;
                CbNumeroEspacio.DataSource = objEspacioBC.ListarFiltro(false);
                CbNumeroEspacio.DisplayMember = "EspacioId";
                CbNumeroEspacio.ValueMember = "EspacioId";
                if (Modo == TypeModo.UsuarioExiste)
                {
                    pngClienteRegistrado.Enabled = false;                
                }
                else if (Modo == TypeModo.UsuarioNoExiste)
                {
                    CbClienteBuscar.Enabled = false;

                }

            }
            catch (Exception ex)
            {


            }
           
               
        }

        private void button1_Click(object sender, EventArgs e)
        { 
           
            try
            { 

                UsuarioBC objusuarioBC=new UsuarioBC();
               // Usuario objusuario = objusuarioBC.GetUsuario(aux);
                ClienteBC objclienteBC = new ClienteBC();
                VentaBC objVentaBC = new VentaBC();         
              Cliente objCliente=new Cliente();
              Espacio objEspacio;
                Venta objVenta = new Venta();

                int IdUsuario = objUsuario.UsuarioId;
                  int IdCliente=0;
                ///tenerlo aqui
                  int EspacioId=0;
                  
                  EspacioId = Convert.ToInt32(CbNumeroEspacio.Text);
                 if(Modo==TypeModo.UsuarioExiste)
                 {             
              IdCliente=objclienteBC.ClienteObtenerDNI(CbClienteBuscar.Text);
             ///haxer q el combo box te liste solo los espacios no ocupados
              
                 }

                








                if(Modo==TypeModo.UsuarioNoExiste)

                {
                    if (String.IsNullOrWhiteSpace(txtNombre.Text) || String.IsNullOrWhiteSpace(txtApellido.Text) || String.IsNullOrWhiteSpace(txtDNI.Text) ||
                   (rbtAbonado.Checked == false && rbtRegular.Checked == false))
                    {
                        MessageBox.Show("Llena tods los espaciooooooooos!!!", "Parqueo UPC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    

                    objCliente.Apellidos=txtApellido.Text;
                    objCliente.Dni=txtDNI.Text;
                    objCliente.Nombre=txtNombre.Text;
                     if(rbtAbonado.Checked)
                      {
                    objCliente.TipoClienteId=4;
                     }
                     else if(rbtRegular.Checked)
                       {
                    objCliente.TipoClienteId=7;
                     }

                   //igual;
                     int w = 0;




                 objclienteBC.ClienteInsertar(objCliente);
                  IdCliente=objclienteBC.ClienteObtenerDNI(txtDNI.Text);
               
                         
                         }



                ///////////////////////////////////////



                 objEspacio = objEspacioBC.GetEspacio(EspacioId);

                 DateTime hoy = DateTime.Now;
                

                 objVenta.ClienteId = IdCliente;
                 objVenta.EspacioId = EspacioId;
                 
                 objVenta.EstadoPago = false;
                 objVenta.FechayHoraAlquilerInicio = hoy;
                 objVenta.UsuarioId = IdUsuario;



               objVentaBC.InsertarVenta(objVenta);//aqui ingresas la hora  quiero q hagas esto osea q se ingrese la hora 
               objEspacioBC.CambiarEstado(objEspacio);
               MessageBox.Show("La Venta se ha registrado correctamente","Parqueo UPC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error", "Parqueo UPC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
