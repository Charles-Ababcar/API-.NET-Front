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
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void btn_retour_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu m = new Menu();
            m.ShowDialog();
        }
    }
}
