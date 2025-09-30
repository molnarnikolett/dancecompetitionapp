using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using tancverseny_applikacio.Data;


namespace tancverseny_applikacio
{
    public partial class MonthlyApplicationsChart : Form
    {
        Chart c = new Chart();
        int X = 0;

        public MonthlyApplicationsChart()
        {
            InitializeComponent();
            this.Load += MonthlyApplicationsChart_Load;
        }
        private void MonthlyApplicationsChart_Load(object sender, EventArgs e)
        {
            LoadChart();
        }

        private void LoadChart()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseSqlServer(@"Server=desktop-rfhbu8u\sqlexpress;Database=UserData;Trusted_Connection=True;TrustServerCertificate=True;")
            .Options;

            using var context = new AppDbContext(options);

            var productions = context.Productions.Where(p => p.State == "Elfogadva").ToList();

            int january = 0;
            int february = 0;
            int march = 0;
            int april = 0;
            int may = 0;
            int june = 0;
            int july = 0;
            int august = 0;
            int september = 0;
            int october = 0;
            int november = 0;
            int december = 0;

            foreach(var production in productions)
            {
                switch (production.ApplyDate.Month)
                {
                    case 1:
                        january++;
                        break;
                    case 2:
                        february++;
                        break;
                    case 3:
                        march++;
                        break;
                    case 4:
                        april++;
                        break;
                    case 5:
                        may++;
                        break;
                    case 6:
                        june++;
                        break;
                    case 7:
                        july++;
                        break;
                    case 8:
                        august++;
                        break;
                    case 9:
                        september++;
                        break;
                    case 10:
                        october++;
                        break;
                    case 11:
                        november++;
                        break;
                    case 12:
                        december++;
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
            ChartArea chartArea = new ChartArea();
            chartArea.Name = "terulet";
            Series series = new Series();
            series.ChartArea = "terulet";
            c.ChartAreas.Add(chartArea);
            c.Series.Add(series);
            series.Points.AddXY(10, january);
            series.Points.AddXY(20, february);
            series.Points.AddXY(30, march);
            series.Points.AddXY(40, april);
            series.Points.AddXY(50, may);
            series.Points.AddXY(60, june);
            series.Points.AddXY(70, july);
            series.Points.AddXY(80, august);
            series.Points.AddXY(90, september);
            series.Points.AddXY(100, october);
            series.Points.AddXY(110, november);
            series.Points.AddXY(120, december);
            Controls.Add(c);

        }

    }
}
