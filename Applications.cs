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
using System.Xml.Serialization;
using tancverseny_applikacio.Data;

namespace tancverseny_applikacio
{
    public partial class Applications : Form
    {
        private List<Competition> competitionList;

        public Applications()
        {
            InitializeComponent();
            this.Load += Applications_Load;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }
        private void Applications_Load(object sender, EventArgs e)
        {
            LoadCompetitions();
        }

        private void LoadCompetitions()
        {
            //kilistázzuk a versenyeket a táblázatba

            CompetitionHandler handler = new CompetitionHandler();
            competitionList = handler.ListAllCompetitions();
            dataGridView1.DataSource = competitionList;

            if (!dataGridView1.Columns.Contains("Applications"))
            {
                var buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.Name = "Applications";
                buttonColumn.HeaderText = "Jelentkezések kezelése";
                buttonColumn.Text = "Kezelés";
                buttonColumn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(buttonColumn);
            }
            if (!dataGridView1.Columns.Contains("Export"))
            {
                var buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.Name = "Export";
                buttonColumn.HeaderText = "Exportálás XML-be";
                buttonColumn.Text = "Exportálás";
                buttonColumn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(buttonColumn);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Applications")
            {
                var selectedCompetition = competitionList[e.RowIndex];
                var form = new CompetitionApplications(selectedCompetition.Id);
                form.ShowDialog();
            }
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Export")
            {
                var selectedCompetition = competitionList[e.RowIndex];
                ExportAcceptedProductionsToXml(selectedCompetition);
            }

        }
        private void ExportAcceptedProductionsToXml(Competition selectedCompetition)
        {
            if (selectedCompetition.ApplicationEnd > DateTime.Now)
            {
                MessageBox.Show("A nevezési időszak még nem zárult le, nem exportálható.");
                return;
            }

            //kilistázzuk azokat a produkciókat, amiket erre a versenyre elfogadtak

            var productionHandler = new ProductionHandler();
            var acceptedProductions = productionHandler.ListAcceptedProductionsByCompetition(selectedCompetition.Id);

            if (!acceptedProductions.Any())
            {
                MessageBox.Show("Nincs elfogadott produkció ezen a versenyen.");
                return;
            }

            var saveFileDialog = new SaveFileDialog
            {
                Filter = "XML fájl|*.xml",
                FileName = $"Verseny_{selectedCompetition.Id}_produkciok.xml"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var serializer = new XmlSerializer(typeof(List<Production>));
                using var stream = new FileStream(saveFileDialog.FileName, FileMode.Create);
                serializer.Serialize(stream, acceptedProductions);
                MessageBox.Show("Exportálás sikeres!");
            }
        }

    }
}
