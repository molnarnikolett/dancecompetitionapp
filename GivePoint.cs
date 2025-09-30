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
    public partial class GivePoint : Form
    {
        private List<Production> productionList;
        public int competitionid { get; set; }

        public GivePoint(int competitionid)
        {
            InitializeComponent();
            this.competitionid = competitionid;
            this.Load += GivePoint_Load;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        private void GivePoint_Load(object sender, EventArgs e)
        {
            LoadProductions();
        }

        private void LoadProductions()
        {
            //kilistázzuk a produkciókat arra a versenyre, ami kell

            ProductionHandler handler = new ProductionHandler();
            productionList = handler.ListAllProductionsForACompetition(competitionid);

            dataGridView1.DataSource = productionList;

            if (!dataGridView1.Columns.Contains("GivePoint"))
            {
                var buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.Name = "GivePoint";
                buttonColumn.HeaderText = "Pontoz";
                buttonColumn.Text = "Pontoz";
                buttonColumn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(buttonColumn);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "GivePoint")
            {
                var selectedProduction = productionList[e.RowIndex];

                var form = new ProductionPoint(selectedProduction.Id);
                form.Show();
            }
        }

    }
}
