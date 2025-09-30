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
    public partial class UserApplicationPoints : Form
    {
        private List<Production> productionList;
        public int userid;
        public UserApplicationPoints(int userid)
        {
            InitializeComponent();
            this.userid = userid;
            this.Load += UserApplicationPoints_Load;
        }
        private void UserApplicationPoints_Load(object sender, EventArgs e)
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

            productionList = context.Productions.Where(p => p.UserId == userid && p.Points != 0).ToList();

            dataGridView1.DataSource = productionList;

            double allpoints = 0;
            double number = 0;

            foreach(Production p in productionList)
            {
                if (p.Points != null)
                {
                    allpoints = allpoints + (double)p.Points;
                    number++;
                }
            }

            label2.Text = (allpoints / number).ToString();
        }
    }
}
