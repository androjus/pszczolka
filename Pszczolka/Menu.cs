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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                this.Hide();
                Poziom_pierwszy poziom = new Poziom_pierwszy();
                poziom.Closed += (s, args) => this.Close();// set scecond form as main and close first
                poziom.Show();
            }
        }

    }
}
