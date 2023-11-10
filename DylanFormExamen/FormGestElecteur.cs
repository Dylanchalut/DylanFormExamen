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
    public partial class FormGestElecteur : Form
    {
        public FormGestElecteur()
        {
            InitializeComponent();
        }

        private void électionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormElection fenfant = new FormElection();
            fenfant.MdiParent = this;
            fenfant.Show();
        }

        private void électeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormElecteur Eenfant = new FormElecteur();
            Eenfant.MdiParent = this;
            Eenfant.Show();
        }

        private void listeÉlecteurToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
