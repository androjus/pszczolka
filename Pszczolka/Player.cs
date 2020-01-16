using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pszczolka
{
    class Player : Controls
    {
        public int wynik = 0;
        public int ilosc_coinow;
        public bool w_mecie = false;
        Control meta;
        public void UstawCoiny(int n)
        {
            this.ilosc_coinow = n;
        }
        public void Movment(Object Sender, Form form)
        {
            picBox = Sender as PictureBox;
            if (picBox == null)
                return;

            if (wlocie)
            {
                picBox.Top += skok;
            }
            if (wskoku && grawitacja < 0)
            {
                wskoku = false;
            }
            if (wPrawo && picBox.Left < form.Width - picBox.Width - 25)
            {
                picBox.Left += 5;
            }
            if (wLewo && picBox.Left > 1)
            {
                picBox.Left -= 5;
            }
            if (wskoku)
            {
                wlocie = true;
                skok -= 8;
                grawitacja -= 1;
            }
            else
            {
                skok = 8;
            }

            foreach (Control x in form.Controls)
            { 

                if (picBox.Bounds.IntersectsWith(x.Bounds) && !wskoku && x.Tag == "platforma")
                {
                    grawitacja = 6;
                    picBox.Top = x.Top - picBox.Height + 1;
                    wlocie = false;
                    ostatni = x;
                }

                if (picBox.Bounds.IntersectsWith(x.Bounds) && x.Tag == "coin")
                {
                    form.Controls.Remove(x);
                    wynik++;
                }

                if (picBox.Bounds.IntersectsWith(x.Bounds) && x.Tag == "meta")
                {
                    w_mecie = true;
                    meta = x;
                }
                if (meta != null)
                {
                    if (!picBox.Bounds.IntersectsWith(meta.Bounds))
                    {
                        w_mecie = false;
                    }
                }

            }
            if (ostatni != null)
            {
                if (!picBox.Bounds.IntersectsWith(ostatni.Bounds) && !wskoku)
                {
                    wlocie = true;
                }
            }

        }

    }
}
