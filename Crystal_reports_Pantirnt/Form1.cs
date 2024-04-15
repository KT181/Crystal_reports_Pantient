using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScottPlot;

namespace Crystal_reports_Pantirnt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void research_Click(object sender, EventArgs e)
        {
            string roomnm = roomnumber.Text.ToString();
            string bednm = bednumber.Text.ToString();

            string databasePath = "db\\vitalsigns.db";
            string connectionString = $"Data Source={databasePath};Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                
                object id = null;
                string queryP_7Days_ID = "SELECT ID FROM room WHERE room_nb = @room AND bed_nb = @bed";
                using (SQLiteCommand command = new SQLiteCommand(queryP_7Days_ID, connection))
                {
                    command.Parameters.AddWithValue("@room", roomnm);
                    command.Parameters.AddWithValue("@bed", bednm);
                    id = command.ExecuteScalar();
                    if (id == null)
                    {
                        MessageBox.Show("查無此病人資料", "提示");
                        return;
                    }
                }

                string patientname_qu = "SELECT patientname FROM room WHERE room_nb = @room AND bed_nb = @bed";
                using (SQLiteCommand command = new SQLiteCommand(patientname_qu, connection))
                {
                    command.Parameters.AddWithValue("@room", roomnm);
                    command.Parameters.AddWithValue("@bed", bednm);
                    patientname.Text = "患者:" + command.ExecuteScalar().ToString();
                    if (id == null)
                    {
                        MessageBox.Show("查無此病人資料", "提示");
                        return;
                    }

                }

                List<DateTime> times = new List<DateTime>();
                List<double> hr = new List<double>();
                List<double> bt = new List<double>();
                List<double> bp_sbp = new List<double>();
                List<double> bp_dbp = new List<double>();

                DateTime startDate = starttime.Value.Date;
                DateTime endDate = endtime.Value.Date.AddDays(1).AddSeconds(-1);
                // 將日期轉換為 SQL Server DateTime 格式的字符串
                string startDateString = startDate.ToString("yyyy-MM-ddTHH:mm:ss");
                string endDateString = endDate.ToString("yyyy-MM-ddTHH:mm:ss");

                string queryP_allVB_withID = "SELECT * FROM patient WHERE ID= @P_ID  AND date >= @StartDate AND date <= @EndDate ";
                using (SQLiteCommand command = new SQLiteCommand(queryP_allVB_withID, connection))
                {
                    command.Parameters.AddWithValue("@P_ID", id.ToString());
                    command.Parameters.AddWithValue("@StartDate", startDateString);
                    command.Parameters.AddWithValue("@EndDate", endDateString);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                double bt_ = Convert.ToDouble(reader["bt"]);
                                double hr_ = Convert.ToDouble(reader["hr"]);
                                double bp_sbp_ = Convert.ToDouble(reader["bp_sbp"]);
                                double bp_dbp_ = Convert.ToDouble(reader["bp_dbp"]);
                                DateTime date = Convert.ToDateTime(reader["date"]);
                                times.Add(date);
                                bt.Add(bt_);
                                hr.Add(hr_);
                                bp_dbp.Add(bp_dbp_);
                                bp_sbp.Add(bp_sbp_);
                                dataGridView1.Rows.Add(bt_,hr_, bp_sbp_, bp_dbp_,date);
                            }
                           

                        }
                        else
                        {
                            MessageBox.Show("查無此病人歷史資料", "提示");
                            return;
                        }
                    }
                    double[] xs = times.Select(x => x.ToOADate()).ToArray();
                    double[] hr_ys = hr.ToArray();
                    double[] bt_ys = bt.ToArray();
                    double[] bp_sbp_ys = bp_sbp.ToArray();
                    double[] bp_dbp_ys = bp_dbp.ToArray();

                    displayplot.Plot.Clear();
                    displayplot.Plot.Title("生命象徵數據");
                    displayplot.Plot.XLabel("時間");
                    displayplot.Plot.YLabel("各項數據");
                    displayplot.Plot.AddScatter(xs, bt_ys, label: "體溫");
                    displayplot.Plot.AddScatter(xs, hr_ys, label: "心率");
                    displayplot.Plot.AddScatter(xs, bp_dbp_ys, label: "收縮壓");
                    displayplot.Plot.AddScatter(xs, bp_sbp_ys, label: "舒張壓");
                    displayplot.Plot.Legend(true);
                    displayplot.Plot.XAxis.DateTimeFormat(true);
                    displayplot.Render();
                    




                }

            }
        }

        private void generate_report_Click(object sender, EventArgs e)
        {
            reportform form2 = new reportform(dataGridView1, roomnumber.Text,bednumber.Text,patientname.Text);
            form2.Show();
        }
    }
}
