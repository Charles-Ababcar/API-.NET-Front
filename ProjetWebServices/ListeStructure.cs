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
namespace ProjetWebServices
{
    public partial class ListeStructure : Form
    {
        public ListeStructure()
        {
            InitializeComponent();
        }

        private void getAll_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8181/");
            HttpResponseMessage response = client.GetAsync("api/allStructure").Result;
            var str = response.Content.ReadFromJsonAsync<IEnumerable<Structure>>().Result;
            dataGridView1.DataSource = str;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }
        private void allStructure()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8181/");
            HttpResponseMessage response = client.GetAsync("api/allStructure").Result;
            var str = response.Content.ReadFromJsonAsync<IEnumerable<Structure>>().Result;
            dataGridView1.DataSource = str;
        }
        private void ListeStructure_Load(object sender, EventArgs e)
        {
            if(!this.IsAccessible)
            {
                this.allStructure();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.ShowDialog();
        }
    }
}
