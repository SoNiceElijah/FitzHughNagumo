namespace nm
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.maxYTB = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.minYTB = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.maxXTB = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.minXTB = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.eTextBox3 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.aTextBox3 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.y0TextBox3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.epsTextBox3 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.rbTextBox3 = new System.Windows.Forms.TextBox();
            this.x0TextBox3 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.rButton3 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.hTextBox3 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.nTextBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainChart
            // 
            chartArea7.Name = "ChartArea1";
            this.mainChart.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.mainChart.Legends.Add(legend7);
            this.mainChart.Location = new System.Drawing.Point(6, 221);
            this.mainChart.Name = "mainChart";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.mainChart.Series.Add(series7);
            this.mainChart.Size = new System.Drawing.Size(706, 402);
            this.mainChart.TabIndex = 12;
            this.mainChart.Text = "chart1";
            // 
            // chart1
            // 
            chartArea8.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chart1.Legends.Add(legend8);
            this.chart1.Location = new System.Drawing.Point(782, 353);
            this.chart1.Name = "chart1";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(0, 195);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button1);
            this.groupBox7.Controls.Add(this.label26);
            this.groupBox7.Controls.Add(this.maxYTB);
            this.groupBox7.Controls.Add(this.label25);
            this.groupBox7.Controls.Add(this.minYTB);
            this.groupBox7.Controls.Add(this.label24);
            this.groupBox7.Controls.Add(this.maxXTB);
            this.groupBox7.Controls.Add(this.label23);
            this.groupBox7.Controls.Add(this.minXTB);
            this.groupBox7.Location = new System.Drawing.Point(6, 165);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(706, 50);
            this.groupBox7.TabIndex = 23;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Настройки";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(599, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "применить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(313, 20);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(34, 13);
            this.label26.TabIndex = 7;
            this.label26.Text = "MaxY";
            // 
            // maxYTB
            // 
            this.maxYTB.Location = new System.Drawing.Point(353, 17);
            this.maxYTB.Name = "maxYTB";
            this.maxYTB.Size = new System.Drawing.Size(55, 20);
            this.maxYTB.TabIndex = 6;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(215, 20);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(31, 13);
            this.label25.TabIndex = 5;
            this.label25.Text = "MinY";
            // 
            // minYTB
            // 
            this.minYTB.Location = new System.Drawing.Point(252, 17);
            this.minYTB.Name = "minYTB";
            this.minYTB.Size = new System.Drawing.Size(55, 20);
            this.minYTB.TabIndex = 4;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(109, 20);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(34, 13);
            this.label24.TabIndex = 3;
            this.label24.Text = "MaxX";
            // 
            // maxXTB
            // 
            this.maxXTB.Location = new System.Drawing.Point(149, 17);
            this.maxXTB.Name = "maxXTB";
            this.maxXTB.Size = new System.Drawing.Size(55, 20);
            this.maxXTB.TabIndex = 2;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(10, 20);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(31, 13);
            this.label23.TabIndex = 1;
            this.label23.Text = "MinX";
            // 
            // minXTB
            // 
            this.minXTB.Location = new System.Drawing.Point(47, 17);
            this.minXTB.Name = "minXTB";
            this.minXTB.Size = new System.Drawing.Size(55, 20);
            this.minXTB.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBox2);
            this.groupBox6.Controls.Add(this.checkBox1);
            this.groupBox6.Controls.Add(this.comboBox1);
            this.groupBox6.Controls.Add(this.eTextBox3);
            this.groupBox6.Controls.Add(this.label27);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.aTextBox3);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.y0TextBox3);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.epsTextBox3);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.rbTextBox3);
            this.groupBox6.Controls.Add(this.x0TextBox3);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.rButton3);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.hTextBox3);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.nTextBox3);
            this.groupBox6.Location = new System.Drawing.Point(6, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(431, 147);
            this.groupBox6.TabIndex = 40;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Параметры";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "t -> x",
            "t -> y",
            "x -> y"});
            this.comboBox1.Location = new System.Drawing.Point(294, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(126, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // eTextBox3
            // 
            this.eTextBox3.Location = new System.Drawing.Point(214, 112);
            this.eTextBox3.Name = "eTextBox3";
            this.eTextBox3.Size = new System.Drawing.Size(59, 20);
            this.eTextBox3.TabIndex = 42;
            this.eTextBox3.Text = "0.01";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(211, 96);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(57, 13);
            this.label27.TabIndex = 41;
            this.label27.Text = "e - парам.";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(146, 96);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(57, 13);
            this.label22.TabIndex = 39;
            this.label22.Text = "a - парам.";
            // 
            // aTextBox3
            // 
            this.aTextBox3.Location = new System.Drawing.Point(149, 112);
            this.aTextBox3.Name = "aTextBox3";
            this.aTextBox3.Size = new System.Drawing.Size(59, 20);
            this.aTextBox3.TabIndex = 40;
            this.aTextBox3.Text = "1.2";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(68, 16);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(24, 13);
            this.label21.TabIndex = 37;
            this.label21.Text = "y(0)";
            // 
            // y0TextBox3
            // 
            this.y0TextBox3.Location = new System.Drawing.Point(71, 32);
            this.y0TextBox3.Name = "y0TextBox3";
            this.y0TextBox3.Size = new System.Drawing.Size(62, 20);
            this.y0TextBox3.TabIndex = 38;
            this.y0TextBox3.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Эпсилон";
            // 
            // epsTextBox3
            // 
            this.epsTextBox3.Location = new System.Drawing.Point(7, 110);
            this.epsTextBox3.Name = "epsTextBox3";
            this.epsTextBox3.Size = new System.Drawing.Size(126, 20);
            this.epsTextBox3.TabIndex = 36;
            this.epsTextBox3.Text = "0.001";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "x(0) ";
            // 
            // rbTextBox3
            // 
            this.rbTextBox3.Location = new System.Drawing.Point(149, 71);
            this.rbTextBox3.Name = "rbTextBox3";
            this.rbTextBox3.Size = new System.Drawing.Size(124, 20);
            this.rbTextBox3.TabIndex = 34;
            this.rbTextBox3.Text = "10";
            // 
            // x0TextBox3
            // 
            this.x0TextBox3.Location = new System.Drawing.Point(7, 32);
            this.x0TextBox3.Name = "x0TextBox3";
            this.x0TextBox3.Size = new System.Drawing.Size(58, 20);
            this.x0TextBox3.TabIndex = 25;
            this.x0TextBox3.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(146, 55);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "Правая граница";
            // 
            // rButton3
            // 
            this.rButton3.Location = new System.Drawing.Point(294, 94);
            this.rButton3.Name = "rButton3";
            this.rButton3.Size = new System.Drawing.Size(126, 38);
            this.rButton3.TabIndex = 11;
            this.rButton3.Text = "запуск";
            this.rButton3.UseVisualStyleBackColor = true;
            this.rButton3.Click += new System.EventHandler(this.rButton3_Click_1);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 55);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 13);
            this.label19.TabIndex = 26;
            this.label19.Text = "h - начальный шаг";
            // 
            // hTextBox3
            // 
            this.hTextBox3.Location = new System.Drawing.Point(7, 71);
            this.hTextBox3.Name = "hTextBox3";
            this.hTextBox3.Size = new System.Drawing.Size(126, 20);
            this.hTextBox3.TabIndex = 27;
            this.hTextBox3.Text = "0.001";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(146, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 13);
            this.label20.TabIndex = 28;
            this.label20.Text = "Количество шагов";
            // 
            // nTextBox3
            // 
            this.nTextBox3.Location = new System.Drawing.Point(149, 32);
            this.nTextBox3.Name = "nTextBox3";
            this.nTextBox3.Size = new System.Drawing.Size(126, 20);
            this.nTextBox3.TabIndex = 29;
            this.nTextBox3.Text = "1000";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(443, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(294, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(109, 17);
            this.checkBox1.TabIndex = 43;
            this.checkBox1.Text = "Сохранить в .dat";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(294, 44);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(114, 17);
            this.checkBox2.TabIndex = 44;
            this.checkBox2.Text = "Переменный шаг";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 630);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.mainChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Решения системы ФитцХью-Нагумо";
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart mainChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox maxYTB;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox minYTB;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox maxXTB;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox minXTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox eTextBox3;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox aTextBox3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox y0TextBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox epsTextBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox rbTextBox3;
        private System.Windows.Forms.TextBox x0TextBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button rButton3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox hTextBox3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox nTextBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

