using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using tancverseny_applikacio.Data;


namespace tancverseny_applikacio
{
    public partial class PointsChart : Form
    {
        Chart c = new Chart();
        int X = 0;
        public PointsChart()
        {
            InitializeComponent();
            this.Load += PointsChart_Load;
        }
        private void PointsChart_Load(object sender, EventArgs e)
        {
            LoadChart();
        }
        private void LoadChart()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseSqlServer(@"Server=desktop-rfhbu8u\sqlexpress;Database=UserData;Trusted_Connection=True;TrustServerCertificate=True;")
            .Options;

            using var context = new AppDbContext(options);

            var competitions = context.Competitions.Where(c => c.CompetitionEnd < DateTime.Now).ToList();
            var productions = context.Productions.ToList();

            int count = competitions.Count;

            Dictionary<int, int> allpoints = new Dictionary<int, int>();

            foreach(var competition in competitions)
            {
                allpoints.Add(competition.Id, 0);
                foreach(var production in productions)
                {
                    if(production.CompetitionId == competition.Id)
                    {
                        if( production.Points != null)
                        {
                            allpoints[competition.Id] += (int)production.Points;
                        }
                        
                    }
                }
            }

            ChartArea chartArea = new ChartArea();
            chartArea.Name = "terulet";
            Series series = new Series();
            series.ChartArea = "terulet";
            c.ChartAreas.Add(chartArea);
            c.Series.Add(series);

            int index = 0;

            foreach (var pair in allpoints)
            {
                int competitionId = pair.Key;
                int point = pair.Value;

                series.Points.AddXY(index + 10, point);
                index++;
            }

            Controls.Add(c);

        }

    }
}
