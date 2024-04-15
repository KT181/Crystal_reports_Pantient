namespace Crystal_reports_Pantirnt
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.research = new System.Windows.Forms.Button();
            this.starttime = new System.Windows.Forms.DateTimePicker();
            this.endtime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.roomnumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bednumber = new System.Windows.Forms.TextBox();
            this.patientname = new System.Windows.Forms.Label();
            this.displayplot = new ScottPlot.FormsPlot();
            this.generate_report = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bp_sbp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bp_dbp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 80);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Crystal_reports_Pantirnt.Properties.Resources.sizeable;
            this.pictureBox2.Location = new System.Drawing.Point(905, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Crystal_reports_Pantirnt.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(961, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "數據報表";
            // 
            // research
            // 
            this.research.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.research.Location = new System.Drawing.Point(926, 103);
            this.research.Name = "research";
            this.research.Size = new System.Drawing.Size(75, 30);
            this.research.TabIndex = 1;
            this.research.Text = "查詢";
            this.research.UseVisualStyleBackColor = true;
            this.research.Click += new System.EventHandler(this.research_Click);
            // 
            // starttime
            // 
            this.starttime.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.starttime.Location = new System.Drawing.Point(469, 103);
            this.starttime.Name = "starttime";
            this.starttime.Size = new System.Drawing.Size(200, 30);
            this.starttime.TabIndex = 2;
            // 
            // endtime
            // 
            this.endtime.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.endtime.Location = new System.Drawing.Point(711, 103);
            this.endtime.Name = "endtime";
            this.endtime.Size = new System.Drawing.Size(200, 30);
            this.endtime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(675, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "~";
            // 
            // roomnumber
            // 
            this.roomnumber.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.roomnumber.Location = new System.Drawing.Point(93, 103);
            this.roomnumber.Name = "roomnumber";
            this.roomnumber.Size = new System.Drawing.Size(100, 33);
            this.roomnumber.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(15, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "病房號:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(209, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "病床號:";
            // 
            // bednumber
            // 
            this.bednumber.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bednumber.Location = new System.Drawing.Point(299, 103);
            this.bednumber.Name = "bednumber";
            this.bednumber.Size = new System.Drawing.Size(100, 33);
            this.bednumber.TabIndex = 8;
            // 
            // patientname
            // 
            this.patientname.AutoSize = true;
            this.patientname.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.patientname.Location = new System.Drawing.Point(17, 162);
            this.patientname.Name = "patientname";
            this.patientname.Size = new System.Drawing.Size(53, 24);
            this.patientname.TabIndex = 9;
            this.patientname.Text = "患者:";
            // 
            // displayplot
            // 
            this.displayplot.Location = new System.Drawing.Point(19, 206);
            this.displayplot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.displayplot.Name = "displayplot";
            this.displayplot.Size = new System.Drawing.Size(982, 574);
            this.displayplot.TabIndex = 10;
            // 
            // generate_report
            // 
            this.generate_report.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.generate_report.Location = new System.Drawing.Point(906, 162);
            this.generate_report.Name = "generate_report";
            this.generate_report.Size = new System.Drawing.Size(95, 24);
            this.generate_report.TabIndex = 11;
            this.generate_report.Text = "生成報表";
            this.generate_report.UseVisualStyleBackColor = true;
            this.generate_report.Click += new System.EventHandler(this.generate_report_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bt,
            this.hr,
            this.bp_sbp,
            this.bp_dbp,
            this.date});
            this.dataGridView1.Location = new System.Drawing.Point(990, 309);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(557, 150);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.Visible = false;
            // 
            // bt
            // 
            this.bt.HeaderText = "體溫(°C)";
            this.bt.Name = "bt";
            // 
            // hr
            // 
            this.hr.HeaderText = "心率(bpm)";
            this.hr.Name = "hr";
            // 
            // bp_sbp
            // 
            this.bp_sbp.HeaderText = "收縮壓(mmHg)";
            this.bp_sbp.Name = "bp_sbp";
            // 
            // bp_dbp
            // 
            this.bp_dbp.HeaderText = "舒張壓(mmHg)";
            this.bp_dbp.Name = "bp_dbp";
            // 
            // date
            // 
            this.date.HeaderText = "日期";
            this.date.Name = "date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 800);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.generate_report);
            this.Controls.Add(this.displayplot);
            this.Controls.Add(this.patientname);
            this.Controls.Add(this.bednumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roomnumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.endtime);
            this.Controls.Add(this.starttime);
            this.Controls.Add(this.research);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "報表";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button research;
        private System.Windows.Forms.DateTimePicker starttime;
        private System.Windows.Forms.DateTimePicker endtime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox roomnumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bednumber;
        private System.Windows.Forms.Label patientname;
        private ScottPlot.FormsPlot displayplot;
        private System.Windows.Forms.Button generate_report;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bt;
        private System.Windows.Forms.DataGridViewTextBoxColumn hr;
        private System.Windows.Forms.DataGridViewTextBoxColumn bp_sbp;
        private System.Windows.Forms.DataGridViewTextBoxColumn bp_dbp;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}

