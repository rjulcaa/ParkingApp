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
    public partial class FrmMuestraCLientes : Form
    {

        public FrmMuestraCLientes()
        {
            InitializeComponent();
        }
        public void ActualizarGrilla()
        {
            VentaBC objVentaBC = new VentaBC();
            dgvAdminCliente.DataSource = objVentaBC.ClienteListarFiltro("Abonado");
        }
        private void FrmAdminClientes_Load(object sender, EventArgs e)
        {
            try
            {

                ConfigurarControles(dgvAdminCliente);
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

            dgvAdminCliente.Columns["Nombre"].DisplayIndex = 0;
            dgvAdminCliente.Columns["Nombre"].HeaderText = "Nombre del Cliente";
            dgvAdminCliente.Columns["Nombre"].Width = 100;
            dgvAdminCliente.Columns["Nombre"].DefaultCellStyle = csLetras;
            dgvAdminCliente.Columns["Nombre"].HeaderCell.Style = csLetras;

            dgvAdminCliente.Columns["Apellidos"].DisplayIndex = 1;
            dgvAdminCliente.Columns["Apellidos"].HeaderText = "Apellidos";
            dgvAdminCliente.Columns["Apellidos"].Width = 100;
          //  dgvAdminCliente.Columns["Nombre"].DefaultCellStyle = csLetras;
           // dgvAdminCliente.Columns["Nombre"].HeaderCell.Style = csLetras;

            dgvAdminCliente.Columns["Dni"].DisplayIndex = 2;
            dgvAdminCliente.Columns["Dni"].HeaderText = "DNI";
            dgvAdminCliente.Columns["Dni"].Width = 100;
           // dgvAdminCliente.Columns["Nombre"].DefaultCellStyle = csLetras;
           // dgvAdminCliente.Columns["Nombre"].HeaderCell.Style = csLetras;

            dgvAdminCliente.Columns["EstadoPago"].DisplayIndex = 3;
            dgvAdminCliente.Columns["EstadoPago"].HeaderText = "Estado de Pago";
            dgvAdminCliente.Columns["EstadoPago"].Width = 100;


            dgvAdminCliente.Columns["FechaInicio"].DisplayIndex = 4;
            dgvAdminCliente.Columns["FechaInicio"].HeaderText = "Fecha de Alquiler";
            dgvAdminCliente.Columns["FechaInicio"].Width = 100;


            dgvAdminCliente.Columns["HoraInicio"].DisplayIndex = 5;
            dgvAdminCliente.Columns["HoraInicio"].HeaderText = "Hora de Alquiler";
            dgvAdminCliente.Columns["HoraInicio"].Width = 100;


            dgvAdminCliente.Columns["DTipoCliente"].DisplayIndex = 6;
            dgvAdminCliente.Columns["DTipoCliente"].HeaderText = "Nombre Tipo del cliente";
            dgvAdminCliente.Columns["DTipoCliente"].Width = 100;

            dgvAdminCliente.Columns["NumeroEspacio"].DisplayIndex = 7;
            dgvAdminCliente.Columns["NumeroEspacio"].HeaderText = "Numero del Espacio";
            dgvAdminCliente.Columns["NumeroEspacio"].Width = 100;


            dgvAdminCliente.Columns["NumeroPiso"].DisplayIndex = 8;
            dgvAdminCliente.Columns["NumeroPiso"].HeaderText = "Numero Piso";
            dgvAdminCliente.Columns["NumeroPiso"].Width = 100;
          //  dgvAdminCliente.Columns["DTipoCliente"].DefaultCellStyle = csLetras;
           // dgvAdminCliente.Columns["DTipoCliente"].HeaderCell.Style = csLetras;


           dgvAdminCliente.Columns["TipoClienteId"].Visible = false;
            dgvAdminCliente.Columns["ClienteId"].Visible = false;
            dgvAdminCliente.Columns["Venta"].Visible = false;
            dgvAdminCliente.Columns["VentaId"].Visible = false;
            dgvAdminCliente.ClearSelection();
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

        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAdminCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        

    }
}
