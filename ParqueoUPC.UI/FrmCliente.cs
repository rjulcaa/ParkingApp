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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }
        public void ActualizarGrilla()
        {
            VentaBC objVentaBC = new VentaBC();
            dgvBuscarClientes.DataSource = objVentaBC.ClienteListarBusqueda(txtNombre.Text);
           
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                ConfigurarControles(dgvBuscarClientes);
                ActualizarGrilla();
                dgvClienteConfigurar();
            }
            catch (Exception ex)
            {

            }
        }
        private void dgvClienteConfigurar()
        {
            DataGridViewCellStyle csLetras = new DataGridViewCellStyle();
            DataGridViewCellStyle csCantidad = new DataGridViewCellStyle();
            csLetras.Alignment = DataGridViewContentAlignment.MiddleLeft;
            csCantidad.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvBuscarClientes.Columns["Nombre"].DisplayIndex = 0;
            dgvBuscarClientes.Columns["Nombre"].HeaderText = "Nombre del Cliente";
            dgvBuscarClientes.Columns["Nombre"].Width = 100;
            dgvBuscarClientes.Columns["Nombre"].DefaultCellStyle = csLetras;
            dgvBuscarClientes.Columns["Nombre"].HeaderCell.Style = csLetras;

            dgvBuscarClientes.Columns["Apellidos"].DisplayIndex = 1;
            dgvBuscarClientes.Columns["Apellidos"].HeaderText = "Apellidos";
            dgvBuscarClientes.Columns["Apellidos"].Width = 100;
            //  dgvAdminCliente.Columns["Nombre"].DefaultCellStyle = csLetras;
            // dgvAdminCliente.Columns["Nombre"].HeaderCell.Style = csLetras;

            dgvBuscarClientes.Columns["Dni"].DisplayIndex = 2;
            dgvBuscarClientes.Columns["Dni"].HeaderText = "DNI";
            dgvBuscarClientes.Columns["Dni"].Width = 100;
            // dgvAdminCliente.Columns["Nombre"].DefaultCellStyle = csLetras;
            // dgvAdminCliente.Columns["Nombre"].HeaderCell.Style = csLetras;

            dgvBuscarClientes.Columns["EstadoPago"].DisplayIndex = 3;
            dgvBuscarClientes.Columns["EstadoPago"].HeaderText = "Estado de Pago";
            dgvBuscarClientes.Columns["EstadoPago"].Width = 100;


            dgvBuscarClientes.Columns["FechaInicio"].DisplayIndex = 4;
            dgvBuscarClientes.Columns["FechaInicio"].HeaderText = "Fecha de Alquiler";
            dgvBuscarClientes.Columns["FechaInicio"].Width = 100;


            dgvBuscarClientes.Columns["HoraInicio"].DisplayIndex = 5;
            dgvBuscarClientes.Columns["HoraInicio"].HeaderText = "Hora de Alquiler";
            dgvBuscarClientes.Columns["HoraInicio"].Width = 100;


            dgvBuscarClientes.Columns["DTipoCliente"].DisplayIndex = 6;
            dgvBuscarClientes.Columns["DTipoCliente"].HeaderText = "Nombre Tipo del cliente";
            dgvBuscarClientes.Columns["DTipoCliente"].Width = 100;

            dgvBuscarClientes.Columns["NumeroEspacio"].DisplayIndex = 7;
            dgvBuscarClientes.Columns["NumeroEspacio"].HeaderText = "Numero del Espacio";
            dgvBuscarClientes.Columns["NumeroEspacio"].Width = 100;


            dgvBuscarClientes.Columns["NumeroPiso"].DisplayIndex = 8;
            dgvBuscarClientes.Columns["NumeroPiso"].HeaderText = "Numero Piso";
            dgvBuscarClientes.Columns["NumeroPiso"].Width = 100;
            //  dgvAdminCliente.Columns["DTipoCliente"].DefaultCellStyle = csLetras;
            // dgvAdminCliente.Columns["DTipoCliente"].HeaderCell.Style = csLetras;


            dgvBuscarClientes.Columns["TipoClienteId"].Visible = false;
            dgvBuscarClientes.Columns["ClienteId"].Visible = false;
            dgvBuscarClientes.Columns["Venta"].Visible = false;
            dgvBuscarClientes.Columns["VentaId"].Visible = false;
            dgvBuscarClientes.ClearSelection();
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
        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }

        private void dgvBuscarClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
