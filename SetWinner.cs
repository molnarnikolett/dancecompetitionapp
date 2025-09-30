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
    public partial class SetWinner : Form
    {
        public int competitionid;
        public SetWinner(int competitionid)
        {
            InitializeComponent();
            this.competitionid = competitionid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseSqlServer(@"Server=desktop-rfhbu8u\sqlexpress;Database=UserData;Trusted_Connection=True;TrustServerCertificate=True;")
            .Options;

            using var context = new AppDbContext(options);

            var competitions = context.Competitions.ToList();
            try
            {
                string winner = textBox1.Text;
                int winpoint = int.Parse(textBox2.Text);

                foreach (Competition comp in competitions)
                {
                    if (comp.Id == competitionid)
                    {
                        comp.Winner = winner;
                        comp.WinnerPoint = winpoint;
                    }
                }

                context.SaveChanges();
                MessageBox.Show("Kihirdetted a nyertest!");
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hiba" + ex.Message);
            }

        }
    }
}
