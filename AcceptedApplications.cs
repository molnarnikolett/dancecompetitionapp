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
    public partial class AcceptedApplications : Form
    {
        private List<Production> productionList;
        public int userid;
        public AcceptedApplications(int userid)
        {
            InitializeComponent();
            this.userid = userid;
            this.Load += AcceptedApplications_Load;
        }
        private void AcceptedApplications_Load(object sender, EventArgs e)
        {
            LoadProductions();
        }
        private void LoadProductions()
        {
            //Azokat a produkciókat jelenítjük meg a usernek, amelyeket elfogadtak

            ProductionHandler handler = new ProductionHandler();
            var productionList = handler.ListAcceptedProductionsByUser(userid);
            dataGridView1.DataSource = productionList;

        }
    }
}
