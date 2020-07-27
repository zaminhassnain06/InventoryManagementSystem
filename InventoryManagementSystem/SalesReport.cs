using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace InventoryManagementSystem
{
    public partial class SalesReport : Form
    {
        int saleId=0;
        ReportDocument rd;
        public SalesReport(int salesId)
        {
            saleId = salesId;
            InitializeComponent();
            ControlBox = true;
        }

        private void SalesReport_Load(object sender, EventArgs e)
        {
            ControlBox = true;
            crystalReportViewer2.AllowedExportFormats = (int)(ViewerExportFormats.ExcelRecordFormat | ViewerExportFormats.PdfFormat);
            Retrievel retrieve = new Retrievel();
            rd = new ReportDocument();
            retrieve.ShowonCrystalReportSalesInvoice(rd, crystalReportViewer2, "Usp_CreatePOSalesPDFReport", "@SalesNumber", saleId);
        }

        private void POReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(rd!=null)
            {
                rd.Close();
            }
            
        }
    }
}
