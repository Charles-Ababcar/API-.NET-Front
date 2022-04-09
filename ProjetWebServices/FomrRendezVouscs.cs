using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Json;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Threading;
using System.Net;
namespace ProjetWebServices
{

public partial class FomrRendezVouscs : Form
{
        public String structure;
        public FomrRendezVouscs()
    {
        InitializeComponent();
            //this.structure = structure;
            hopitalCombox.Location = new Point(293, 310);
        hopitalCombox.Size = new Size(200, 300);
        hopitalCombox.Font = new Font(FontFamily.GenericSerif, 15);
        hopitalCombox.DropDownStyle = ComboBoxStyle.DropDownList;
        hopitalCombox.BackColor = Color.LightGreen;
        comboBox_rv.Location = new Point(293, 236);
        comboBox_rv.Size = new Size(100, 100);
        comboBox_rv.Font = new Font(FontFamily.GenericMonospace, 15);
        comboBox_rv.DropDownStyle = ComboBoxStyle.DropDownList;
        download();
        comboBox_rv.Items.Add("test");
        comboBox_rv.Items.Add("vaccin");
        //downloadUtilisateur();

    }

   

        private async void button1_Click(object sender, EventArgs e)
    {
     

    Structure str = new Structure();
    str.idStructure = int.Parse(hopitalCombox.Text.Split(' ')[0]);
    Utilisateur uti = new Utilisateur(202);
     uti.id = int.Parse(hopitalCombox.Text.Split(' ')[1]);
    var Libelle = libelle.Text;
  //  var DateRv = DateTime.Parse(dateTimePicker.Text);
    var Type = (string)comboBox_rv.SelectedItem;
            Rendezvous rv = new Rendezvous(Libelle, DateTime.Parse(dateTimePicker.Text), Type, str,uti) ;
            Console.WriteLine("OBJET ID:::::::::::::: " + rv.structure.idStructure);
            Console.WriteLine("OBJET ID:::::::::::::: " + rv.utilisateur.id);
            var response = await  ServiceAPI.Create(rv);
    if (response != null)
    {
        MessageBox.Show("Votre rendez vous a été prise en compte");
                this.Hide();
      }
    else
    {
        MessageBox.Show("la prise du rendez vous est impossible");
    }
        //  structure = hopitalCombox.SelectedItem,


    }
   
    //Fonction qui permet de choisir un combobox
    private async void download()
    {
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri("http://localhost:8181/");
        HttpResponseMessage respons = client.GetAsync("api/allStructure").Result;
        List<Structure> structures = await respons.Content.ReadFromJsonAsync<List<Structure>>();
        Console.WriteLine(structures);
        foreach (Structure structure in structures)
        {

            hopitalCombox.Items.Add(structure.nom + " " +structure.idStructure);
            Console.WriteLine(structure.nom);

        }
    }


    private async void downloadUtilisateur()
    {
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri("http://localhost:8181/");
        HttpResponseMessage respons = client.GetAsync("api/users").Result;
        List<Utilisateur> u= await respons.Content.ReadFromJsonAsync<List<Utilisateur>>();
        Console.WriteLine(u);
        foreach (Utilisateur users in u)
        {

            hopitalCombox.Items.Add(users.id+ " " + users.prenom);
            Console.WriteLine(users.id);

        }
    }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.ShowDialog();
        }
    }
    


}
