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

namespace tancverseny_applikacio
{
    public partial class CompetitionApplications : Form
    {
        private List<Production> productionList;

        public int competitionid { get; set; }

        public CompetitionApplications(int competitionid)
        {
            InitializeComponent();
            this.competitionid = competitionid;
            this.Load += CompetitionApplications_Load;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        private void CompetitionApplications_Load(object sender, EventArgs e)
        {
            LoadProductions();
        }


        private void LoadProductions()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseSqlServer(@"Server=desktop-rfhbu8u\sqlexpress;Database=UserData;Trusted_Connection=True;TrustServerCertificate=True;")
            .Options;

            using var context = new AppDbContext(options);

            var productions = new BindingList<Production>(context.Productions.ToList());

            productionList = context.Productions.Where(p => p.CompetitionId == competitionid && p.State == "elfogadásra vár").ToList();

            dataGridView1.DataSource = productionList;

            dataGridView1.Columns[0].Visible = false;

            if (!dataGridView1.Columns.Contains("Accept"))
            {
                var buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.Name = "Accept";
                buttonColumn.HeaderText = "Elfogadás";
                buttonColumn.Text = "Elfogadás";
                buttonColumn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(buttonColumn);
            }
            if (!dataGridView1.Columns.Contains("Deny"))
            {
                var buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.Name = "Deny";
                buttonColumn.HeaderText = "Elutasítás";
                buttonColumn.Text = "Elutasítás";
                buttonColumn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(buttonColumn);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Accept")
            {
                var selectedProduction = productionList[e.RowIndex];
                var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(@"Server=desktop-rfhbu8u\sqlexpress;Database=UserData;Trusted_Connection=True;TrustServerCertificate=True;")
                .Options;

                using (var context = new AppDbContext(options))
                {
                    var prod = context.Productions.FirstOrDefault(p => p.Id == selectedProduction.Id);
                    if (prod != null)
                    {
                        prod.State = "Elfogadva";
                        context.SaveChanges();
                    }
                }

                var form = new GiveStartTime(selectedProduction.Id);
                form.Show();

                LoadProductions();

            }
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Deny")
            {
                var selectedProduction = productionList[e.RowIndex];
                var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(@"Server=desktop-rfhbu8u\sqlexpress;Database=UserData;Trusted_Connection=True;TrustServerCertificate=True;")
                .Options;

                using (var context = new AppDbContext(options))
                {
                    var prod = context.Productions.FirstOrDefault(p => p.Id == selectedProduction.Id);
                    if (prod != null)
                    {
                        prod.State = "Elutasítva";
                        context.SaveChanges();
                    }
                }

                MessageBox.Show("A jelentkezést elutasítottad.");
                LoadProductions();

            }


        }

    }
}
