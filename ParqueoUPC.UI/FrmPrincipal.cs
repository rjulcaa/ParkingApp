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
    public partial class FrmPrincipal : Form
    {

        int UsuarioIdPrincipal { get; set; }
        public Usuario objUsuarioPrin { get; set; }
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public void archiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmAdministrador_Load(object sender, EventArgs e)
        {
            try
            {
                String aux = objUsuarioPrin.TipoUsuario.DTipoUsuario;
                if (objUsuarioPrin.TipoUsuario.DTipoUsuario== "Admin")
                {
                    MenuCajero.Visible = false;
                    MenuVenta.Visible = false;
                }
                else
                    MenuAdmin.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdminUsuario frm = new FrmAdminUsuario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMuestraCLientes frm = new FrmMuestraCLientes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frm = new FrmCliente();
            frm.MdiParent = this;
            frm.Show();
        }

        private void espaciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdminEspacios frm = new FrmAdminEspacios();
            frm.MdiParent = this;
            frm.Show();
        }

        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {
             FrmVenta frm = new FrmVenta();

             if (MessageBox.Show("¿EL cliente ya esta Registrado?", "Parqueo UPC",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                 frm.Modo = FrmVenta.TypeModo.UsuarioExiste;
                

                
              
             else
                 frm.Modo = FrmVenta.TypeModo.UsuarioNoExiste;

            frm.objUsuario=objUsuarioPrin;
            frm.MdiParent = this;
            frm.Show();
        }

        private void cobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCobraAlquiler frm = new FrmCobraAlquiler();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
