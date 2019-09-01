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
namespace ParqueoUPC.UI
{
    public partial class FrmUsuario : Form
    {
        public enum TypeModo { Insertar, Actualizar }
        public TypeModo Modo { get; set; }
        public int UsuarioId { get; set; }

        public delegate void dlgActualizarGrilla();
        public dlgActualizarGrilla midelegado;

        private String MensajePregunta;
        private String MensajeRespuesta;
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                if (Modo == TypeModo.Insertar)
                { 
                    lblUsuarios.Text = "Registrar Usuarios";
                    MensajePregunta = "¿Esta seguro de registrar este Usuario?";
                    MensajeRespuesta = "El Usuario se registro correctamente";

                }
                else if (Modo == TypeModo.Actualizar)
                {
                    lblUsuarios.Text = "Editar Usuarios";
                    MensajePregunta = "¿Esta seguro de Actualizar este Usuario?";
                    MensajeRespuesta = "El usuario se actualizao Satisfactoriamente";
                    UsuarioBC objUsuarioBC = new UsuarioBC();
                    Usuario objUsuario = objUsuarioBC.UsuarioObtener(UsuarioId);

                    
                    txtApellido.Text = objUsuario.Apellidos;
                    txtContraseña.Text = objUsuario.Password;
                    txtDni.Text = objUsuario.DniUsuario;
                    txtLogin.Text = objUsuario.UsuarioL;
                    txtNombreUser.Text = objUsuario.Nombre;
                    if (objUsuario.TipoUsuario.TipoUsuarioId == 1)
                    {
                        rbtnCajero.Checked = true;
                        rbtnAdmin.Checked = false;
                    }
                    if (objUsuario.TipoUsuario.TipoUsuarioId == 4)
                    {
                        rbtnAdmin.Checked = true;
                        rbtnCajero.Checked = false;
                    }
                  //  txtTUser.Text = objUsuario.TipoUsuario.DTipoUsuario;

                }

            }
            catch (Exception ex)
            {


            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        { 
            try
            {
                if (String.IsNullOrWhiteSpace(txtApellido.Text) || String.IsNullOrWhiteSpace(txtContraseña.Text) || String.IsNullOrWhiteSpace(txtDni.Text) ||
                    String.IsNullOrWhiteSpace(txtLogin.Text) || String.IsNullOrWhiteSpace(txtNombreUser.Text) || (rbtnAdmin.Checked==false && rbtnCajero.Checked==false))
                {
                    MessageBox.Show("Llena tods los espaciooooooooos!!!", "Parqueo UPC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if(MessageBox.Show(MensajePregunta,"Parqueo UPC",MessageBoxButtons.YesNo,MessageBoxIcon.Question) != DialogResult.Yes)
                return;
              UsuarioBC objUsuarioBC =new UsuarioBC();
                Usuario objUsuario=new Usuario();
                TipoUsuario objTipo = new TipoUsuario();

              //  objUsuario.TipoUsuarioId = Convert.ToInt32(txtTUser.Text);

                if (rbtnAdmin.Checked)
                {
                    objUsuario.TipoUsuarioId = 4;
                }
                else
                    if (rbtnCajero.Checked)
                    {
                        objUsuario.TipoUsuarioId = 1;
                    
                    }
                //string str = Convert.ToString(num);
                objUsuario.Nombre = txtNombreUser.Text;
                objUsuario.Password = txtContraseña.Text;
               
               
                objUsuario.UsuarioL = txtLogin.Text;
                objUsuario.DniUsuario = txtDni.Text;
                objUsuario.Apellidos = txtApellido.Text;
               
            



            if (Modo == TypeModo.Insertar)
                    objUsuarioBC.UsuarioInsertar(objUsuario);
                else if (Modo == TypeModo.Actualizar)
                {
                    objUsuario.UsuarioId = UsuarioId; ;
                    objUsuarioBC.UsuarioActualizar(objUsuario);
                }

                midelegado();
                MessageBox.Show(MensajeRespuesta,
                                "Parqueo UPC",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                this.Close();
            }
            
            
            
            

            catch(Exception ex)
            {
                MessageBox.Show("error");

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }



    }

}