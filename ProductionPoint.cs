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
    public partial class ProductionPoint : Form
    {
        int productionid;
        public ProductionPoint(int productionid)
        {
            InitializeComponent();
            this.productionid = productionid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
          .UseSqlServer(@"Server=desktop-rfhbu8u\sqlexpress;Database=UserData;Trusted_Connection=True;TrustServerCertificate=True;")
          .Options;

            using var context = new AppDbContext(options);

            var productions = context.Productions.ToList();
            try
            {
                int point = int.Parse(textBox1.Text);

                foreach (Production prod in productions)
                {
                    if (prod.Id == productionid)
                    {
                        prod.Points = point;
                    }
                }
                context.SaveChanges();
                MessageBox.Show("Pontozás sikeres!");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba" + ex.Message);
            }
        }
    }
}
