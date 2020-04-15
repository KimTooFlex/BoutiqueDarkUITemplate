using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoutiqueDarkUIDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        void loadChart1()
        {
            var r = new Random();
            var Canvas = new Bunifu.DataViz.WinForms.Canvas();

            //Chart colors
            bunifuCharts1.colorSet.Add(Color.FromArgb(0, 213, 254));
            bunifuCharts1.colorSet.Add(Color.FromArgb(254, 169, 0));
            bunifuCharts1.colorSet.Add(Color.FromArgb(254, 0, 0));

            //credit sales chart
            Bunifu.DataViz.WinForms.DataPoint point1 = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_spline);
            point1.addLabely("MONDAY", "5800");
            point1.addLabely("TUESDAY", "5000");
            point1.addLabely("WEDNESDAY", "4000");
            point1.addLabely("THURSDAY", "8000");
            point1.addLabely("FRIDAY", "4000");
            point1.addLabely("SATURDAY", "5800");
            point1.addLabely("SUNDAY", "5000");
            Canvas.addData(point1);
            bunifuCharts1.Render(Canvas);

            //chanell sales chart
            Bunifu.DataViz.WinForms.DataPoint point2 = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_spline);
            point2.addLabely("MONDAY", "2800");
            point2.addLabely("TUESDAY", "2500");
            point2.addLabely("WEDNESDAY", "3200");
            point2.addLabely("THURSDAY", "6000");
            point2.addLabely("FRIDAY", "3500");
            point2.addLabely("SATURDAY", "4000");
            point2.addLabely("SUNDAY", "3000");
            Canvas.addData(point2);
            bunifuCharts1.Render(Canvas);

            //direct sales chart
            Bunifu.DataViz.WinForms.DataPoint point3 = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_spline);
            point3.addLabely("MONDAY", "1000");
            point3.addLabely("TUESDAY", "2000");
            point3.addLabely("WEDNESDAY", "1100");
            point3.addLabely("THURSDAY", "4300");
            point3.addLabely("FRIDAY", "4000");
            point3.addLabely("SATURDAY", "1000");
            point3.addLabely("SUNDAY", "2000");
            Canvas.addData(point3);
            bunifuCharts1.Render(Canvas);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            loadChart1();
            loadChart2();
        }
        void loadChart2()
        {
            var r = new Random();
            var Canvas = new Bunifu.DataViz.WinForms.Canvas();

            //Chart colors
            bunifuCharts2.colorSet.Add(Color.FromArgb(0, 213, 254));
            bunifuCharts2.colorSet.Add(Color.FromArgb(254, 169, 0));
            bunifuCharts2.colorSet.Add(Color.FromArgb(254, 0, 0));

            //credit sales chart
            Bunifu.DataViz.WinForms.DataPoint point1 = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_doughnut);
            point1.addLabely("", "58");
            point1.addLabely("", "50");
            point1.addLabely("", "40");
            point1.addLabely("", "80");
            point1.addLabely("", "40");
            point1.addLabely("", "58");
            point1.addLabely("", "50");
            Canvas.addData(point1);
            bunifuCharts2.Render(Canvas);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadChart1();
            loadChart2();
        }
    }
}
