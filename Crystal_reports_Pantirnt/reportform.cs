using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using ScottPlot.Plottable;
namespace Crystal_reports_Pantirnt
{
    public partial class reportform : Form
    {
        public bool IsDataGridViewEmpty(DataGridView dataGridView)
        {
            return dataGridView.Rows.Count == 0;
        }
        public reportform( DataGridView dataGridView1,string roomnumber, string bednumber, string patientname)
        {

            
            InitializeComponent();
            DataSet1 dataSet = new DataSet1();
            DataTable dataTable = dataSet.歷史數據;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataRow dRow = dataTable.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dataTable.Rows.Add(dRow);
            }
            
            report cRpt = new report();
            
            cRpt.SetDataSource(dataTable);
            cRpt.SetParameterValue("roomnumber",roomnumber);
            cRpt.SetParameterValue("bednumber", bednumber);
            cRpt.SetParameterValue("patientname", patientname);
            crystalReportViewer1.ReportSource = cRpt;

        }
    }
}
