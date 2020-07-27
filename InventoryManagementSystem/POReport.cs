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
    public partial class POReport : Form
    {
        int PO=0;
        ReportDocument rd;
        public POReport(int PoNumber)
        {
            PO = PoNumber;
            InitializeComponent();
            ControlBox = true;
        }

        private void POReport_Load(object sender, EventArgs e)
        {
            ControlBox = true;
            Retrievel retrieve = new Retrievel();
            crystalReportViewer2.AllowedExportFormats = (int) (ViewerExportFormats.ExcelRecordFormat | ViewerExportFormats.PdfFormat);
            rd = new ReportDocument();
            retrieve.ShowonCrystalReport(rd,crystalReportViewer2, "Usp_CreatePOPDFReport", "@PoNumber", PO);
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
