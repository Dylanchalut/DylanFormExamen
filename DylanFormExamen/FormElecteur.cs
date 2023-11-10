using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DylanFormExamen
{
    public partial class FormElecteur : Form
    {
        public FormElecteur()
        {
            InitializeComponent();
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            Electeur el= new Electeur();
            el.NumeroElecteur = textBox_numero.Text;
            el.Circoncription = comboBox_circonscription.Text;
            el.Nom = textBox_nom.Text;
            el.Prenom = textBox_prenom.Text;
            el.Courriel = textBox_courriel.Text;
            if (el.NumeroElecteur == text)
        }

        private void textBox_nom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
