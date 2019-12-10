using core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace nm
{
    public partial class MainForm : Form
    {
        int nums = 0;
        DotForm info;

        double minDot;
        double maxDot;

        public MainForm()
        {
            InitializeComponent();

            this.Shown += MainForm_Shown;
        }

        private void correctAxis(double x, double miny, double maxy, double minx = 0)
        {
            try
            {
                var tmp = !string.IsNullOrWhiteSpace(minXTB.Text) ? Convert.ToDouble(minXTB.Text.Replace('.', ',')) : minx;
                mainChart.ChartAreas[0].AxisX.Minimum = tmp;

                tmp = !string.IsNullOrWhiteSpace(maxXTB.Text) ? Convert.ToDouble(maxXTB.Text.Replace('.', ',')) : x;
                mainChart.ChartAreas[0].AxisX.Maximum = tmp;

                tmp = !string.IsNullOrWhiteSpace(minYTB.Text) ? Convert.ToDouble(minYTB.Text.Replace('.', ',')) : miny;
                mainChart.ChartAreas[0].AxisY.Minimum = tmp;

                tmp = !string.IsNullOrWhiteSpace(maxYTB.Text) ? Convert.ToDouble(maxYTB.Text.Replace('.', ',')) : maxy;
                mainChart.ChartAreas[0].AxisY.Maximum = tmp;
            }
            catch(Exception ex)
            {
                MessageBox.Show(this,ex.Message,"Неправильный ввод", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            correctAxis(10,0,5);

            comboBox1.Select(0,1);

            mainChart.ChartAreas[0].AxisX.Title = "x";
            mainChart.ChartAreas[0].AxisY.Title = "u";

            mainChart.Legends.Clear();
            mainChart.Series.Clear();

            // Добавляем новый график
            var ser = mainChart.Series.Add("Diff");
            ser.ChartType = SeriesChartType.Line;
            ser.Color = Color.FromArgb(255, Color.Red);
            ser.BorderWidth = 1;
            ser.Name = "Численное решение";

            var real = mainChart.Series.Add("Real");
            real.ChartType = SeriesChartType.Line;
            real.Color = Color.FromArgb(255,Color.Blue);
            real.BorderWidth = 2;
            real.Name = "Точное решение";

            chart1.Series.Clear();
            chart1.Legends.Clear();

            var sh = chart1.Series.Add("h");
            sh.ChartType = SeriesChartType.Line;

            ser.Points.AddXY(0, 0);
            ser.Points.AddXY(10, 10);

            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Title = "Шаги";

        }

        Thread super;
        bool sRun = false;


        StreamWriter fileToWrite = null;
        private void rButton3_Click_1(object sender, EventArgs e)
        {
            
            if (sRun)
            {
                sRun = false;
                super.Abort();
                rButton3.Text = "запуск";

                if (fileToWrite != null)
                {
                    fileToWrite.Close();
                    fileToWrite = null;
                }

                return;
            }

            sRun = true;
            rButton3.Text = "cтоп";

            bool saveToFile = checkBox1.Checked;

            
            if (saveToFile)
            {
                fileToWrite = new StreamWriter("output.dat");
                fileToWrite.WriteLine("t\tx\ty");
            }

            int selected = comboBox1.SelectedIndex;
            super = new Thread(() =>
            {
                double x0 = Convert.ToDouble(x0TextBox3.Text.Replace('.', ','));
                double y0 = Convert.ToDouble(y0TextBox3.Text.Replace('.', ','));
                double h = Convert.ToDouble(hTextBox3.Text.Replace('.', ','));
                int n = Convert.ToInt32(nTextBox3.Text.Replace('.', ','));
                double eps = Convert.ToDouble(epsTextBox3.Text.Replace('.', ','));
                double rb = Convert.ToDouble(rbTextBox3.Text.Replace('.', ','));

                double a = Convert.ToDouble(aTextBox3.Text.Replace('.', ','));
                double pe = Convert.ToDouble(eTextBox3.Text.Replace('.', ','));




                SecondMethod m = new SecondMethod(
                    (t, x, y) => (x - ((x * x * x) / 3) - y) / pe,
                    (t, x, y) => (x + a),
                     0, x0, y0, h, eps, checkBox2.Checked);


                mainChart.Invoke(new Action(() =>
                {
                    mainChart.Series["Численное решение"].Points.Clear();
                    mainChart.Series["Точное решение"].Points.Clear();


                    chart1.Series["h"].Points.Clear();
                }));

                ++nums;
                info = new DotForm();
                info.label1.Text = "Запуск номер " + nums + "; Метод 3";


                minDot = double.MaxValue;
                maxDot = double.MinValue;
                double minX = double.MaxValue;

                double minStep = double.MaxValue;
                double mns = 0;

                double maxStep = double.MinValue;
                double mxs = 0;

                MDot p = null;

                int count = 0;
                double maxOLP = 0;

                foreach (var i in Enumerable.Range(0, n))
                {
                    double step = m.Step;
                    p = m.nextStep(out double contr, out double olp);

                    if (Math.Abs(p.U1) < 1e-8)
                        p.U2 = 0;                    
                    if (Math.Abs(p.X) < 1e-8)
                        p.X = 0;

                    if(fileToWrite != null)
                        fileToWrite.WriteLine(p.X.ToString().Replace(',','.') + "\t" + p.U1.ToString().Replace(',', '.') + "\t" + p.U2.ToString().Replace(',', '.'));

                    if (Math.Abs(p.X) > 10e+20)
                        break;
                    if (Math.Abs(p.U1) > 10e+20)
                        break;

                    MDot add = new MDot();

                    if (selected == 0)
                    {
                        add.X = p.X;
                        add.Y = p.U1;
                    }
                    if (selected == 1)
                    {
                        add.X = p.X;
                        add.Y = p.U2;
                    }
                    if (selected == 2)
                    {
                        add.X = p.U1;
                        add.Y = p.U2;
                    }

                    mainChart.Invoke(new Action(() => {
                        mainChart.Series["Численное решение"].Points.AddXY(add.X, add.Y);
                        chart1.Series["h"].Points.AddXY(i, step);
                    }));

                    Console.WriteLine(p.X + " " + p.U1);

                    mainChart.Invoke(new Action(() =>
                    {
                        info.dataGridView1.Rows.Add(i + "", add.Y, contr, olp, step, m.C1, m.C2, "-", "-");
                    }));

                    if (minDot > add.Y)
                        minDot = add.Y;

                    if (maxDot < add.Y)
                        maxDot = add.Y;

                    if (minX > add.X)
                        minX = add.X;

                    if (p.X > rb)
                        break;

                    if (maxOLP < Math.Abs(olp))
                        maxOLP = Math.Abs(olp);

                    if (step > maxStep)
                    {
                        maxStep = step;
                        mxs = p.X;
                    }

                    if (step < minStep)
                    {
                        minStep = step;
                        mns = p.X;
                    }

                    count++;

                }

                mainChart.Invoke(new Action(() =>
                {
                    correctAxis(rb, minDot - 0.01, maxDot + 0.01);

                    info.param.Text = $"n = : {count}, \nb-Xn: {rb - p.X}, \nmaxOLP: {maxOLP}, \nC1: {m.C1}, \nC2: {m.C2}, \nmax Hi: {maxStep} -> x: {mxs}, \nmin Hi: {minStep} -> x: {mns}";
                    info.Show();

                    sRun = false;
                    rButton3.Text = "запуск";

                    if (fileToWrite != null)
                    {
                        fileToWrite.Close();
                        fileToWrite = null;
                    }

                    if (selected == 0)
                    {
                        mainChart.ChartAreas[0].AxisX.Title = "t";
                        mainChart.ChartAreas[0].AxisY.Title = "x";
                    }
                    if (selected == 1)
                    {
                        mainChart.ChartAreas[0].AxisX.Title = "t";
                        mainChart.ChartAreas[0].AxisY.Title = "y";
                    }
                    if (selected == 2)
                    {
                        mainChart.ChartAreas[0].AxisX.Title = "x";
                        mainChart.ChartAreas[0].AxisY.Title = "y";

                        correctAxis(rb, minDot - 0.01, maxDot + 0.01, minX - 0.01);
                    }

                }));
            });

            super.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double rb = Convert.ToDouble(rbTextBox3.Text.Replace('.', ','));
            correctAxis(rb, minDot - 0.01, maxDot + 0.01);
        }
    }
  
}
