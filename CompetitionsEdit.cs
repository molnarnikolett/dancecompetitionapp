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
using tancverseny_applikacio.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace tancverseny_applikacio
{
    public partial class CompetitionsEdit : Form
    {
        public CompetitionsEdit()
        {
            InitializeComponent();
            this.Load += FormAdmin_Load;
            dataGridView1.CellMouseDown += dataGridView1_CellMouseDown;
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
        }
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            LoadCompetitions();
        }

        private void LoadCompetitions()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseSqlServer(@"Server=desktop-rfhbu8u\sqlexpress;Database=UserData;Trusted_Connection=True;TrustServerCertificate=True;")
            .Options;

            using var context = new AppDbContext(options);

            var competitions = new BindingList<Competition>(context.Competitions.ToList());
            dataGridView1.DataSource = competitions;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseSqlServer(@"Server=desktop-rfhbu8u\sqlexpress;Database=UserData;Trusted_Connection=True;TrustServerCertificate=True;")
            .Options;
            try
            {
                using (var context = new AppDbContext(options))
                {
                    var competitions = new List<Competition>();

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue;

                        var idCell = row.Cells[0].Value;
                        int id = idCell != null ? Convert.ToInt32(idCell) : 0;

                        var competition = new Competition
                        {
                            Id = id,
                            Name = row.Cells[1].Value?.ToString(),
                            Date = DateTime.Parse(row.Cells[2].Value?.ToString() ?? DateTime.MinValue.ToString()),
                            Place = row.Cells[3].Value?.ToString(),
                            ApplicationStart = DateTime.Parse(row.Cells[4].Value?.ToString() ?? DateTime.MinValue.ToString()),
                            ApplicationEnd = DateTime.Parse(row.Cells[5].Value?.ToString() ?? DateTime.MinValue.ToString()),
                            CompetitionStart = DateTime.Parse(row.Cells[6].Value?.ToString() ?? DateTime.MinValue.ToString()),
                            CompetitionEnd = DateTime.Parse(row.Cells[7].Value?.ToString() ?? DateTime.MinValue.ToString())
                        };
                        competitions.Add(competition);
                    }

                    var dbCompetitions = context.Competitions.ToList();

                    foreach (var competition in competitions)
                    {
                        if (competition.Id == 0)
                        {
                            context.Competitions.Add(competition);
                        }
                        else
                        {
                            var dbCompetition = dbCompetitions.FirstOrDefault(v => v.Id == competition.Id);
                            if (dbCompetition != null)
                            {
                                dbCompetition.Name = competition.Name;
                                dbCompetition.Date = competition.Date;
                                dbCompetition.Place = competition.Place;
                                dbCompetition.ApplicationStart = competition.ApplicationStart;
                                dbCompetition.ApplicationEnd = competition.ApplicationEnd;
                                dbCompetition.CompetitionStart = competition.CompetitionStart;
                                dbCompetition.CompetitionEnd = competition.CompetitionEnd;
                            }
                        }
                    }

                    context.SaveChanges();
                }

                MessageBox.Show("Mentés sikeres!");
                LoadCompetitions();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hiba: " + ex.Message);
            }
        }
        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[0];
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(@"Server=desktop-rfhbu8u\sqlexpress;Database=UserData;Trusted_Connection=True;TrustServerCertificate=True;")
                .Options;

                var id = (int)dataGridView1.CurrentRow.Cells[0].Value;

                using (var context = new AppDbContext(options))
                {
                    var item = context.Competitions.FirstOrDefault(c => c.Id == id);
                    if (item != null)
                    {
                        context.Competitions.Remove(item);
                        context.SaveChanges();
                        MessageBox.Show("Törlés sikeres.");
                        LoadCompetitions();
                    }
                }
            }


        }
    }
}
