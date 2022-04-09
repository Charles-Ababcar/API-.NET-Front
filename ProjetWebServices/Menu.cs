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
    public partial class Menu : Form
    {
        private Form currentChildForm;

        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListeStructure s = new ListeStructure();
             s.ShowDialog();
           // OpenChildForm(new ListeStructure());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AjoutStructure ajoutStructure = new AjoutStructure();
            ajoutStructure.ShowDialog();
           // OpenChildForm(new AjoutStructure());
        }

        private void global_vue_Click(object sender, EventArgs e)
        {
           VueGlobalMap ve = new VueGlobalMap();
            ve.ShowDialog();
           // OpenChildForm(new VueGlobalMap());
        }

        private void rendezVous_Click(object sender, EventArgs e)
        {
             //FomrRendezVouscs fr = new FomrRendezVouscs();
           // fr.ShowDialog();
            OpenChildForm(new FomrRendezVouscs());
        }
        private void OpenChildForm(Form childForm)
        {
            //Open only from
            if (currentChildForm !=null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
           // mbox.Text = childForm.Text;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_maxed.Visible = false;
            btn_max.Location = btn_max.Location;
            
        }

        private void btn_maxed_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_max.Visible = false;
            btn_maxed.Location = btn_max.Location;
            btn_maxed.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contact_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Contact());
        }
    }



}