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
    public partial class FrmAdminUsuario : Form
    {
        public FrmAdminUsuario()
        {
            InitializeComponent();
        }
        public void ActualizarGrilla()
        {
            UsuarioBC objUsuarioBC=new UsuarioBC();
            dgvAdminUsuarios.DataSource=objUsuarioBC.UsuarioListar();
        }
        private void FrmAdminUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigurarControles(dgvAdminUsuarios);
                ActualizarGrilla();
                dgvUsuarioConfigurar();
            }
            catch (Exception ex)
            { 
            
            }
        }

        private void dgvUsuarioConfigurar()
        {
            DataGridViewCellStyle csLetras = new DataGridViewCellStyle();
            DataGridViewCellStyle csCantidad = new DataGridViewCellStyle();
            csLetras.Alignment = DataGridViewContentAlignment.MiddleLeft;
            csCantidad.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvAdminUsuarios.Columns["Nombre"].DisplayIndex = 0;
            dgvAdminUsuarios.Columns["Nombre"].HeaderText = "Nombre";
            dgvAdminUsuarios.Columns["Nombre"].Width = 100;
            dgvAdminUsuarios.Columns["Nombre"].DefaultCellStyle = csLetras;
            dgvAdminUsuarios.Columns["Nombre"].HeaderCell.Style = csLetras;

            dgvAdminUsuarios.Columns["Apellidos"].DisplayIndex = 1;
            dgvAdminUsuarios.Columns["Apellidos"].HeaderText = "Apellidos";
            dgvAdminUsuarios.Columns["Apellidos"].Width = 100;
            dgvAdminUsuarios.Columns["Nombre"].DefaultCellStyle = csLetras;
            dgvAdminUsuarios.Columns["Nombre"].HeaderCell.Style = csLetras;

            dgvAdminUsuarios.Columns["DniUsuario"].DisplayIndex = 2;
            dgvAdminUsuarios.Columns["DniUsuario"].HeaderText = "DNI";
            dgvAdminUsuarios.Columns["DniUsuario"].Width = 100;
            dgvAdminUsuarios.Columns["Nombre"].DefaultCellStyle = csLetras;
            dgvAdminUsuarios.Columns["Nombre"].HeaderCell.Style = csLetras;

            dgvAdminUsuarios.Columns["UsuarioL"].DisplayIndex = 3;
            dgvAdminUsuarios.Columns["UsuarioL"].HeaderText = "Login de Usuario";
            dgvAdminUsuarios.Columns["UsuarioL"].Width = 100;
            dgvAdminUsuarios.Columns["Nombre"].DefaultCellStyle = csLetras;
            dgvAdminUsuarios.Columns["Nombre"].HeaderCell.Style = csLetras;

            dgvAdminUsuarios.Columns["Password"].DisplayIndex = 4;
            dgvAdminUsuarios.Columns["Password"].HeaderText = "Contraseña de Usuario";
            dgvAdminUsuarios.Columns["Password"].Width = 100;
            dgvAdminUsuarios.Columns["Nombre"].DefaultCellStyle = csLetras;
            dgvAdminUsuarios.Columns["Nombre"].HeaderCell.Style = csLetras;

            dgvAdminUsuarios.Columns["DTipoUsuario"].DisplayIndex = 5;
            dgvAdminUsuarios.Columns["DTipoUsuario"].HeaderText = "Tipo de Usuario";
            dgvAdminUsuarios.Columns["DTipoUsuario"].Width = 100;
            dgvAdminUsuarios.Columns["Nombre"].DefaultCellStyle = csLetras;
            dgvAdminUsuarios.Columns["Nombre"].HeaderCell.Style = csLetras;

            dgvAdminUsuarios.Columns["UsuarioId"].Visible = false;
           dgvAdminUsuarios.Columns["Venta"].Visible = false;
           dgvAdminUsuarios.Columns["TipoUsuarioId"].Visible = false;
           dgvAdminUsuarios.Columns["TipoUsuario"].Visible = false;
            dgvAdminUsuarios.ClearSelection();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FrmUsuario frm = new FrmUsuario();
            frm.Modo = FrmUsuario.TypeModo.Insertar;
            frm.midelegado += ActualizarGrilla;
            frm.ShowDialog();
        }
        public void ConfigurarControles(DataGridView dgv)
        {
            dgv.AllowDrop = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvAdminUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un Usuario","Parqueo UPC",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            int UsuarioId = Convert.ToInt32(dgvAdminUsuarios.
                                             SelectedRows[0].
                                             Cells["UsuarioId"].
                                             Value);

            FrmUsuario frm = new FrmUsuario();
            frm.Modo = FrmUsuario.TypeModo.Actualizar;
           
            
            frm.UsuarioId = UsuarioId;
            frm.midelegado += ActualizarGrilla;
            frm.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAdminUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAdminUsuarios.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccione un Usuario", "Parqueo UPC",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (MessageBox.Show("Está seguro de eliminar a este Usuario?", "Parqueo UPC",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes)
                    return;

                int UsuarioId = Convert.ToInt32(dgvAdminUsuarios.SelectedRows[0].Cells["UsuarioId"].Value);

               UsuarioBC objUsuarioBC = new UsuarioBC();
               objUsuarioBC.UsuarioEliminar(UsuarioId);

                ActualizarGrilla();

                MessageBox.Show("Se eliminó al Usuario  satisfactoriamente", "Parqueo UPC",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error");
            }
        }

       
    }
}
