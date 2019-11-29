using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pszczolka
{
    public partial class Poziom_pierwszy : Form
    {
        Player pszczolka = new Player();
        public Poziom_pierwszy()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Poziom_pierwszy_Load(object sender, EventArgs e)
        {

        }

        private void Poziom_pierwszy_KeyDown(object sender, KeyEventArgs e)
        {
            pszczolka.ButtonDown(sender, e);
            pbPszczolka.Image = (Image)Properties.Resources.ResourceManager.GetObject(pszczolka.animacja);
        }

        private void Poziom_pierwszy_KeyUp(object sender, KeyEventArgs e)
        {
            pszczolka.ButtonUp(sender, e);
            pbPszczolka.Image = (Image)Properties.Resources.ResourceManager.GetObject(pszczolka.animacja);
        }
    }
}
