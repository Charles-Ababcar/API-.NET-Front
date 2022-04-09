using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetWebServices
{
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
        }
        [System.ComponentModel.Browsable(false)]
        public bool Modal { get; }
        //Modal 
        private void ShowMyNonModalForm()
        {
            Form myForm = new Form();
            myForm.Text = "My Form";
            myForm.SetBounds(10, 10, 200, 200);
            
            myForm.Show();
            prenom.Text = "success";
            // Determine if the form is modal.
            if (myForm.Modal == true)
            {
                // Change borderstyle and make it not a top level window.
                myForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                myForm.TopLevel = false;
            }
        }
        //Inscription d'un nouveau client
        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                Utilisateur utilisateur = new Utilisateur()
                {
                    prenom = prenom.Text,
                    nom = nom.Text,
                    email = email.Text,
                    telephone = telephone.Text,
                    adresse = adresse.Text,
                    login = login.Text,
                    pwd = password.Text,
                    //role=false
                  

                };
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:8181/");
                HttpResponseMessage response = client.PostAsJsonAsync("api/addUsers", utilisateur).Result;
                MessageBox.Show("Inscription avec Success!!!");
                //ShowMyNonModalForm();
                nom.Clear();
                prenom.Clear();
                email.Clear();
                telephone.Clear();
                adresse.Clear();
                login.Clear();
                password.Clear();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK);
            }
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Inscription_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.ShowDialog();

        }
    }
}
