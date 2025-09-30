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
    public partial class AddProductionForm : Form
    {
        public int competitionid { get; set; }
        public int userid { get; set; }
        public AddProductionForm(int competitionid, int userid)
        {
            this.competitionid = competitionid;
            this.userid = userid;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
           .UseSqlServer(@"Server=desktop-rfhbu8u\sqlexpress;Database=UserData;Trusted_Connection=True;TrustServerCertificate=True;")
           .Options;

            using var context = new AppDbContext(options);

            try
            {
                var production = new Production
                {
                    ApplicantName = textBox1.Text.ToString(),
                    Style = textBox2.Text.ToString(),
                    ProductionName = textBox3.Text.ToString(),
                    MusicName = textBox4.Text.ToString(),
                    MusicianName = textBox5.Text.ToString(),
                    LengthOfMusic = int.Parse(textBox6.Text),
                    ApplyDate = DateTime.Now,
                    CompetitionId = competitionid,
                    State = "elfogadásra vár",
                    UserId = userid,
                    Points = 0
                };

                context.Productions.Add(production);

                context.SaveChanges();
                MessageBox.Show("Jelentkezés sikeres!");
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hiba" + ex.Message);
            }
        }
    }
}
