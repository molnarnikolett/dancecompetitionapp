using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class CompetitionsOver : Form
    {
        private List<Competition> competitionList;
        public CompetitionsOver()
        {
            InitializeComponent();
            this.Load += CompetitionsOver_Load;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        private void CompetitionsOver_Load(object sender, EventArgs e)
        {
            LoadCompetitions();
        }
        private void LoadCompetitions()
        {
            //kilistázzuk azokat a versenyeket, amiknek már vége van

            CompetitionHandler handler = new CompetitionHandler();
            competitionList = handler.ListEndedCompetitions();
            dataGridView1.DataSource = competitionList;

            if (!dataGridView1.Columns.Contains("Productions"))
            {
                var buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.Name = "Productions";
                buttonColumn.HeaderText = "Produkciók";
                buttonColumn.Text = "Produkciók";
                buttonColumn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(buttonColumn);
            }

            if (!dataGridView1.Columns.Contains("Winner"))
            {
                var buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.Name = "Winner";
                buttonColumn.HeaderText = "Nyertes megadása";
                buttonColumn.Text = "Nyertes megadása";
                buttonColumn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(buttonColumn);
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Productions")
            {
                var selectedCompetition = competitionList[e.RowIndex];

                var form = new GivePoint(selectedCompetition.Id);
                form.Show();
            }

            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Winner")
            {
                var selectedCompetition = competitionList[e.RowIndex];

                var form = new SetWinner(selectedCompetition.Id);
                form.Show();
            }

        }

    }
}
