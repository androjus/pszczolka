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
        PictureBox picBox = new PictureBox();
        public bool wPrawo = false;
        public bool wLewo = false;
        bool skok = false;
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
            if (e.KeyCode == Keys.Space && !skok)
            {
                skok = true;
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
            if (skok)
            {
                skok = false;
            }
        }
        public void Movment(Object Sender)
        {
            picBox = (PictureBox)Sender;
            if (wPrawo == true)
            {
                picBox.Left += 5;
            }
            if (wLewo == true)
            {
                picBox.Left -= 5;
            }
        }

    }
}
