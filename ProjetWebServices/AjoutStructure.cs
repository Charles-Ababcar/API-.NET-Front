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

namespace ProjetWebServices
{

    public partial class AjoutStructure : Form
    {

        static HttpClient client = new HttpClient();
        public AjoutStructure()
        {
            InitializeComponent();
        }

        public object JsonConvert { get; private set; }


        //1ere Methode Save Structure
        public static async Task<string> PostURI(Uri u, HttpContent c)
        {

            var response = string.Empty;
            using (var client = new HttpClient())
            {
                HttpResponseMessage result = await client.PostAsync(u, c);
                if (result.IsSuccessStatusCode)
                {
                    response = result.StatusCode.ToString();
                }

            }
            return response;

        }
        //  2eme Methode post structure
        public static async Task<string> Post(string nom, string adresse,
            string contact, string capacite, int nbrdoseVaccin, int nbre_place)
        {

            var inputData = new Dictionary<string, string>
                {
                 {"nom",nom},
                 {"adresse",adresse },
                  {"contact",contact },
                {"capacite",capacite }

,
                };
            var input = new FormUrlEncodedContent(inputData);
            using (HttpClient client = new HttpClient())
            {

                using HttpResponseMessage res = await client.PostAsync("http://localhost:8181/api/add", input);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                using (HttpContent content = res.Content)
                {
                    string data = await content.ReadAsStringAsync();
                    //var myContent = JsonConvert.SerializeObject(data);
                    if (data != null)
                    {
                        return data;
                    }
                }

            }
            return string.Empty;
        }


        ///Methopde pour la prise en Compte des structures de santées
        private async void btn_structure_Click(object sender, EventArgs e)
        {


            try
            {
                Structure str = new Structure()
                {

                    nom = nom_structure.Text,
                    adresse = adresse.Text,
                    contact = contact.Text,
                    capacite = capacite.Text,
                    nombredoses = int.Parse(nbrdoseVaccin.Text),
                    nbresplaces = int.Parse(nbre_places.Text)
                };
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:8181/");
                HttpResponseMessage response = client.PostAsJsonAsync("api/addStructure", str).Result;
                MessageBox.Show("Enregistrement avec Success!!!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          //  idStructure.Text= dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            nom_structure.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            adresse.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            contact.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            capacite.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            nbrdoseVaccin.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            nbre_places.Text= dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        
        //Methode pour la recuperation des la liste des tous les structures de santées
        private void allStructure()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8181/");
            HttpResponseMessage response = client.GetAsync("api/allStructure").Result;
            var str = response.Content.ReadFromJsonAsync<IEnumerable<Structure>>().Result;
            dataGridView1.DataSource = str;
        }
        private void AjoutStructure_Load(object sender, EventArgs e)
        {
            if (!this.IsAccessible)
                allStructure();
        }

        private void nom_structure_TextChanged(object sender, EventArgs e)
        {
            nom_structure.BackColor = Color.White;
            StringBuilder sb = new StringBuilder();

            foreach (char c in nom_structure.Text)
            {
                if (Char.IsDigit(c))
                    sb.Append(c);
            }
        }

        private void adresse_TextChanged(object sender, EventArgs e)
        {
            adresse.BackColor = Color.White;
            StringBuilder sb = new StringBuilder();

            foreach (char c in adresse.Text)
            {
                if (Char.IsDigit(c))
                    sb.Append(c);

            }
        }

        private void capacite_TextChanged(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in capacite.Text)
            {
                if (Char.IsDigit(c))
                    sb.Append(c);

            }
        }

        private void contact_TextChanged(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in contact.Text)
            {
                if (Char.IsDigit(c))
                    sb.Append(c);

            }
        }

        private void nbrdoseVaccin_TextChanged(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in nbrdoseVaccin.Text)
            {
                if (Char.IsDigit(c))
                    sb.Append(c);

            }
        }

        private void nbre_places_TextChanged(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in nbre_places.Text)
            {
                if (Char.IsDigit(c))
                    sb.Append(c);

            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            ///Modification
            static async Task<Structure> UpdateStructureAsync(Structure structure)
            {
                client.BaseAddress = new Uri("http://localhost:8181/");
                HttpResponseMessage response = await client.PutAsJsonAsync(
                    "api/modifierStructure/{id}", structure);
                response.EnsureSuccessStatusCode();

                // Deserialize the updated product from the response body.
                structure = await response.Content.ReadAsAsync<Structure>();
                return structure;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.ShowDialog();
        }
    }
}