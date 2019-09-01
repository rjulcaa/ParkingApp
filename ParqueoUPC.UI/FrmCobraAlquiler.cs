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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace ParqueoUPC.UI
{
    public partial class FrmCobraAlquiler : Form
    {
        public FrmCobraAlquiler()
        {
            InitializeComponent();
        }

        private void btnTickert_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wi=PdfWriter.GetInstance(doc,new FileStream("Comprobante.pdf",FileMode.Create));
            doc.Open();
            Paragraph factura = new Paragraph("FacturaId");
            Paragraph name = new Paragraph("Nombre");
            Paragraph last = new Paragraph("Apellido");
            Paragraph ruc = new Paragraph("RUC");
            Paragraph esapcio = new Paragraph("No Espacio");
            Paragraph mount = new Paragraph("Monto");
            doc.Add(factura); 
            doc.Add(name);
            doc.Add(last);
             doc.Add(ruc);
               doc.Add(esapcio);
               doc.Add(mount);
              doc.Close();
        }
    }
}
