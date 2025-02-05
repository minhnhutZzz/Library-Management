namespace LibarySystem
{
    partial class frmThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1Books = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.qlySachDataSet1 = new LibarySystem.qlySachDataSet();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.chart2Books = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1Books)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlySachDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2Books)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1Books
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1Books.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1Books.Legends.Add(legend1);
            this.chart1Books.Location = new System.Drawing.Point(12, 22);
            this.chart1Books.Name = "chart1Books";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1Books.Series.Add(series1);
            this.chart1Books.Size = new System.Drawing.Size(583, 458);
            this.chart1Books.TabIndex = 0;
            this.chart1Books.Text = "chart1";
            // 
            // qlySachDataSet1
            // 
            this.qlySachDataSet1.DataSetName = "qlySachDataSet";
            this.qlySachDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnHienThi
            // 
            this.btnHienThi.BackColor = System.Drawing.Color.Blue;
            this.btnHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.ForeColor = System.Drawing.Color.White;
            this.btnHienThi.Location = new System.Drawing.Point(434, 578);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(141, 59);
            this.btnHienThi.TabIndex = 1;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = false;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(637, 581);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(135, 56);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart2Books
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2Books.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2Books.Legends.Add(legend2);
            this.chart2Books.Location = new System.Drawing.Point(609, 22);
            this.chart2Books.Name = "chart2Books";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2Books.Series.Add(series2);
            this.chart2Books.Size = new System.Drawing.Size(583, 458);
            this.chart2Books.TabIndex = 3;
            this.chart2Books.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(33, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Biểu đồ thể hiện tần suất sách được mượn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(632, 504);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(508, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Biểu đồ thể hiện độ tích cực của thành viên";
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1204, 694);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart2Books);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.chart1Books);
            this.Name = "frmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThongKe";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1Books)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlySachDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2Books)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1Books;
        private qlySachDataSet qlySachDataSet1;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2Books;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}