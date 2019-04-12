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
    public partial class VerwerkingsForm : Form
    {
        public VerwerkingsForm()
        {
            InitializeComponent();
        }

        public void OpmaakForm( string actie)
        {
            if (actie == "toevoegen")
            {
                // enkel de delen zichtbaarmaken die nodig zijn om gegevens in te geven 
                lblSelecteren.Visible = false;
                cmbSelecteren.Visible = false;
                lblIngeven.Visible = true;
                txtIngeven.Visible = true;
                btnActie.Text = "toevoegen";

            }
            else if (actie == "veranderen")
            {
                // vul hier ook de combobox

                // delen zichtbaar maken om te veranderen 
                lblSelecteren.Visible = true;
                cmbSelecteren.Visible = true;
                lblIngeven.Visible = true;
                txtIngeven.Visible = true;
                btnActie.Text = "veranderen";
            }
            else if (actie == "verwijderen")
            {
                // vul hier ook de combobox

                // delen zichtbaar maken te selecteren wie je wil verwijderen 
                lblSelecteren.Visible = true;
                cmbSelecteren.Visible = true;
                lblIngeven.Visible = false;
                txtIngeven.Visible = false;
                btnActie.Text = "verwijderen";
            }
            else
            {

                lblSelecteren.Visible = false;
                cmbSelecteren.Visible = false;
                lblIngeven.Visible = false;
                txtIngeven.Visible = false;
                btnActie.Text = "";


            }



        }

        private void btnActie_Click(object sender, EventArgs e)
        {

            if (btnActie.Text == "toevoegen")
            {
                // roep dan de methodes op uit de business om gegevens toe te voegen 
            }
            else if (btnActie.Text == "veranderen")
            {
                // roep dan de methodes op uit de business om gegevens te veranderen
            }
            else if (btnActie.Text == "verwijderen")
            {
                // roep dan de methodes op uit de business om gegevens te verwijderen
            }

        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
