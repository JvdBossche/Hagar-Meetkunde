using MeetkundeLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetkundeGUI
{
    public partial class MeetkundeForm : Form
    {
        public MeetkundeForm()
        {
            InitializeComponent();
        }

        private void toevoegenRechthoek_Click(object sender, EventArgs e)
        {
            //Rechthoek rh = new Rechthoek(naamVeld.Text, double.Parse(lengteVeld.Text), double.Parse(breedteVeld.Text));
            //figurenLijst.Items.Add(rh.ToString());
            
            //figurenLijst.Items.Add(new Rechthoek(naamVeld.Text, double.Parse(lengteVeld.Text), double.Parse(breedteVeld.Text)).ToString());
            
            double l, b;
            try
            {
                l = double.Parse(lengteVeld.Text);
            }
            catch {
                l = 1;
            }

            //if (double.TryParse(breedteVeld.Text, out b)) { } else { b = 1; }
            b = (double.TryParse(breedteVeld.Text, out b)) ? b : 1;
            
            //figurenLijst.Items.Add(new Rechthoek(naamVeld.Text, l, b).ToString());
            figurenLijst.Items.Add(new Rechthoek(naamVeld.Text, l, b));
        }

        private void toevoegenCirkel_Click(object sender, EventArgs e)
        {

        }

        private void toevoegenParallellogram_Click(object sender, EventArgs e)
        {

        }
    }
}
