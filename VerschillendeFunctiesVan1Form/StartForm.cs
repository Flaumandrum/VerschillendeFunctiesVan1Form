using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerschillendeFunctiesVan1Form
{
    public partial class StartForm : Form
    {
        private string actie = "";

        public StartForm()
        {
            InitializeComponent();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            actie = "toevoegen";
            VerwerkingsForm verwerken = new VerwerkingsForm();
            verwerken.OpmaakForm(actie);
            Hide();
            verwerken.ShowDialog();
            Show();
        }

        private void btnAanpassen_Click(object sender, EventArgs e)
        {
            actie = "veranderen";
            VerwerkingsForm verwerken = new VerwerkingsForm();
            verwerken.OpmaakForm(actie);
            Hide();
            verwerken.ShowDialog();
            Show();
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            actie = "verwijderen";

            VerwerkingsForm verwerken = new VerwerkingsForm();
            verwerken.OpmaakForm(actie);
            Hide();
            verwerken.ShowDialog();
            Show();
           
        }
    }
}
