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
    public partial class UserForm : Form
    {
        private List<Competition> competitionList;
        int userid;

        public UserForm(int userid)
        {
            InitializeComponent();
            this.Load += FormUser_Load;
            this.userid = userid;
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            LoadCompetitions();
        }

        private void LoadCompetitions()
        {
            //kilistázunk minden meghirdetett versenyt

            var competitonHandler = new CompetitionHandler();
            competitionList = competitonHandler.ListAllCompetitions();
            dataGridView1.DataSource = competitionList;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var form = new UserApplications(userid);
            form.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new ApplyForCompetition(userid);
            form.ShowDialog();
        }
    }
}
