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
    public partial class Poziom_trzeci : Form
    {
        bool wcisniety = false;
        Player pszczolka = new Player();
        public Poziom_trzeci()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            pbPszczolka.BackColor = Color.Transparent;
            pbPszczolka.Parent = tlo;
            pszczolka.UstawCoiny(6);
        }

        private void Poziom_trzeci_Load(object sender, EventArgs e)
        {

        }

        private void Poziom_trzeci_KeyDown(object sender, KeyEventArgs e)
        {
            pszczolka.ButtonDown(sender, e);
            if (!wcisniety)//zapogieganie zapetlaniu sie animacji, przez co wygladalo, jakby pszczola stala w miejscu
            {
                pbPszczolka.Image = (Image)Properties.Resources.ResourceManager.GetObject(pszczolka.animacja);
                wcisniety = true;
            }
        }

        private void Poziom_trzeci_KeyUp(object sender, KeyEventArgs e)
        {
            pszczolka.ButtonUp(sender, e);
            pbPszczolka.Image = (Image)Properties.Resources.ResourceManager.GetObject(pszczolka.animacja);
            if (wcisniety) wcisniety = false;
        }

        private void glownyTimer_Tick(object sender, EventArgs e)
        {
            pszczolka.Movment(pbPszczolka, this);
            lWynik.Text = "Monety: " + pszczolka.wynik.ToString();
            if (pszczolka.wynik == pszczolka.ilosc_coinow && pszczolka.w_mecie)
            {
                glownyTimer.Stop();
                this.Hide();
                Koniec poziom = new Koniec();
                poziom.Closed += (s, args) => this.Close();
                poziom.Show();
            }
        }
    }
}
