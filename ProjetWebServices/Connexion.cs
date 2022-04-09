using System.Net;
using System.Text;
using System.Net.Http.Json;
using Newtonsoft.Json;

namespace ProjetWebServices
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();

        }

        private static readonly String baseUrl = "http://localhost:8181/api/";



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            username.BackColor = Color.White;
            StringBuilder sb = new StringBuilder();

            foreach (char c in username.Text)
            {
                if (Char.IsDigit(c))
                    sb.Append(c);
            }

        }

        private async void button1_Click(object sender, EventArgs e)

        {

            //buton connexion
            var log = username.Text;
            var pass = password.Text;
            Utilisateur user = new Utilisateur(log, pass);
            var response = await UseAPI.LogU(user);
            // MessageBox.Show(response.ToString());
            if (response != null)
            {
                
                MessageBox.Show("Connexion etablie!!! ");
                Menu F3 = new Menu();
                F3.ShowDialog();
                username.Clear();
                password.Clear();
            }
            else
            {
                Console.WriteLine("nullll::");
                MessageBox.Show("Login ou mot de passe incorrecte");

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in password.Text)
            {
                if (Char.IsDigit(c))
                    sb.Append(c);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inscription ins = new Inscription();
            ins.ShowDialog();
        }

       
            
        private void password_TextChanged(object sender, EventArgs e)
        {
             password.PasswordChar = (char)0x25CF;
         
        }
    }
    
}