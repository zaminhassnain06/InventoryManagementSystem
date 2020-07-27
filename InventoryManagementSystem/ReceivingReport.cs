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
    public partial class ReceivingReport : Form
    {
        int ReceiveId=0;
        ReportDocument rd;
        public ReceivingReport(int receiveId)
        {
            ReceiveId = receiveId;
            InitializeComponent();
            ControlBox = true;
        }

        private void ReceivingReport_Load(object sender, EventArgs e)
        {
            ControlBox = true;
            crystalReportViewer2.AllowedExportFormats = (int)(ViewerExportFormats.ExcelRecordFormat | ViewerExportFormats.PdfFormat);
            Retrievel retrieve = new Retrievel();
            rd = new ReportDocument();
            retrieve.ShowonCrystalReportPOReceiving(rd, crystalReportViewer2, "Usp_CreateReceivPDFReport", "@RecivId", ReceiveId);
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
