using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pszczolka
{
    class Controls:iControls
    {
        protected PictureBox picBox = new PictureBox();
        protected bool wPrawo = false;
        protected bool wLewo = false;
        protected bool wskoku = false;
        protected bool wlocie = false;
        protected int skok = 8;
        protected int grawitacja = 6;
        protected Control ostatni;
        public string animacja = "prawa_s";
        public void ButtonDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                wPrawo = true;
                animacja = "prawa";
            }
            if (e.KeyCode == Keys.A)
            {
                wLewo = true;
                animacja = "lewa";
            }
            if (e.KeyCode == Keys.Space && !wskoku)
            {
                wskoku = true;
            }

        }
        public void ButtonUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                wPrawo = false;
                animacja = "prawa_s";
            }
            if (e.KeyCode == Keys.A)
            {
                wLewo = false;
                animacja = "lewa_s";
            }
            if (wskoku)
            {
                wskoku = false;
            }
        }

    }
}
