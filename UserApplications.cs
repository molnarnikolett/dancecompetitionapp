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
    public partial class UserApplications : Form
    {
        private List<Production> productionList;
        public int userid;
        public UserApplications(int userid)
        {
            InitializeComponent();
            this.userid = userid;
            this.Load += UserApplications_Load;
        }
        private void UserApplications_Load(object sender, EventArgs e)
        {
            LoadProductions();
        }
        private void LoadProductions()
        {
            //kilistázunk minden produkciót, amire a user jelentkezett

            ProductionHandler handler = new ProductionHandler();
            productionList = handler.ListAllProductionsForUser(userid);
            dataGridView1.DataSource = productionList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new AcceptedApplications(userid);
            form.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new UserApplicationPoints(userid);
            form.Show();
        }
    }
}
