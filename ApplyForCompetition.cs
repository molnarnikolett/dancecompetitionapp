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
    public partial class ApplyForCompetition : Form
    {
        private List<Competition> competitionList;
        int userid;

        public ApplyForCompetition(int userid)
        {
            InitializeComponent();
            this.Load += ApplyForCompetition_Load;
            this.userid = userid;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }
        private void ApplyForCompetition_Load(object sender, EventArgs e)
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

            competitionList = context.Competitions.Where(c => c.ApplicationStart<=DateTime.Now && c.ApplicationEnd>DateTime.Now).ToList();
            dataGridView1.DataSource = competitionList;

            if (!dataGridView1.Columns.Contains("Apply"))
            {
                var buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.Name = "Apply";
                buttonColumn.HeaderText = "Jelentkezés";
                buttonColumn.Text = "Jelentkezem";
                buttonColumn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(buttonColumn);
            }

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Apply")
            {
                var selectedCompetition = competitionList[e.RowIndex];

                var form = new AddProductionForm(selectedCompetition.Id, userid);
                form.Show();
            }
        }

    }
}
