namespace chartFinal
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_date = new System.Windows.Forms.TabPage();
            this.tab_ora = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tab_univ = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.tab_csv = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.tab_image = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tab_chart = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tab_ora.SuspendLayout();
            this.tab_univ.SuspendLayout();
            this.tab_csv.SuspendLayout();
            this.tab_image.SuspendLayout();
            this.tab_chart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_date);
            this.tabControl1.Controls.Add(this.tab_ora);
            this.tabControl1.Controls.Add(this.tab_univ);
            this.tabControl1.Controls.Add(this.tab_csv);
            this.tabControl1.Controls.Add(this.tab_image);
            this.tabControl1.Controls.Add(this.tab_chart);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(755, 367);
            this.tabControl1.TabIndex = 1;
            // 
            // tab_date
            // 
            this.tab_date.Location = new System.Drawing.Point(4, 22);
            this.tab_date.Name = "tab_date";
            this.tab_date.Padding = new System.Windows.Forms.Padding(3);
            this.tab_date.Size = new System.Drawing.Size(747, 341);
            this.tab_date.TabIndex = 0;
            this.tab_date.Text = "Date personale";
            this.tab_date.UseVisualStyleBackColor = true;
            // 
            // tab_ora
            // 
            this.tab_ora.Controls.Add(this.button2);
            this.tab_ora.Controls.Add(this.button1);
            this.tab_ora.Location = new System.Drawing.Point(4, 22);
            this.tab_ora.Name = "tab_ora";
            this.tab_ora.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ora.Size = new System.Drawing.Size(747, 341);
            this.tab_ora.TabIndex = 1;
            this.tab_ora.Text = "Schimbare format ora";
            this.tab_ora.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(5, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "FORMAT FARA AM/PM";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "FORMAT AM/PM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tab_univ
            // 
            this.tab_univ.Controls.Add(this.button3);
            this.tab_univ.Location = new System.Drawing.Point(4, 22);
            this.tab_univ.Name = "tab_univ";
            this.tab_univ.Size = new System.Drawing.Size(747, 341);
            this.tab_univ.TabIndex = 2;
            this.tab_univ.Text = "Universitati";
            this.tab_univ.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 20);
            this.button3.TabIndex = 0;
            this.button3.Text = "Arata Universitati";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tab_csv
            // 
            this.tab_csv.Controls.Add(this.button4);
            this.tab_csv.Location = new System.Drawing.Point(4, 22);
            this.tab_csv.Name = "tab_csv";
            this.tab_csv.Size = new System.Drawing.Size(747, 341);
            this.tab_csv.TabIndex = 3;
            this.tab_csv.Text = "csv";
            this.tab_csv.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(273, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 67);
            this.button4.TabIndex = 0;
            this.button4.Text = "CSV";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tab_image
            // 
            this.tab_image.Controls.Add(this.button5);
            this.tab_image.Controls.Add(this.textBox1);
            this.tab_image.Location = new System.Drawing.Point(4, 22);
            this.tab_image.Name = "tab_image";
            this.tab_image.Size = new System.Drawing.Size(747, 341);
            this.tab_image.TabIndex = 4;
            this.tab_image.Text = "Imagini";
            this.tab_image.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(170, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 20);
            this.button5.TabIndex = 1;
            this.button5.Text = "Cauta";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 0;
            // 
            // tab_chart
            // 
            this.tab_chart.Controls.Add(this.chart1);
            this.tab_chart.Location = new System.Drawing.Point(4, 22);
            this.tab_chart.Name = "tab_chart";
            this.tab_chart.Size = new System.Drawing.Size(747, 341);
            this.tab_chart.TabIndex = 5;
            this.tab_chart.Text = "Chart";
            this.tab_chart.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Teal;
            series1.Legend = "Legend1";
            series1.Name = "Numar Facultati";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(741, 335);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 384);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_ora.ResumeLayout(false);
            this.tab_univ.ResumeLayout(false);
            this.tab_csv.ResumeLayout(false);
            this.tab_image.ResumeLayout(false);
            this.tab_image.PerformLayout();
            this.tab_chart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_date;
        private System.Windows.Forms.TabPage tab_ora;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tab_univ;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tab_csv;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabPage tab_image;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tab_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

