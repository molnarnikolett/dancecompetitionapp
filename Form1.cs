using Microsoft.EntityFrameworkCore;
using tancverseny_applikacio.Data;
using tancverseny_applikacio.Data.Migrations;

namespace tancverseny_applikacio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseSqlServer(@"Server=desktop-rfhbu8u\sqlexpress;Database=UserData;Trusted_Connection=True;TrustServerCertificate=True;")
            .Options;

            using var context = new AppDbContext(options);

            try
            {
                var user = context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Kérlek, add meg a felhasználónevet és jelszót!");
                    return;
                }

                
                if (user != null && user.Type == "admin")
                {
                    this.Hide();
                    AdminForm adminForm = new AdminForm();
                    adminForm.ShowDialog();
                    this.Show();
                }

                else if(user != null && user.Type == "user")
                {
                    this.Hide();
                    var userid = user.Id;
                    UserForm userForm = new UserForm(userid);
                    userForm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Hibás felhasználónév vagy jelszó.");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt: " + ex.Message);
            }
        }
    }
}
