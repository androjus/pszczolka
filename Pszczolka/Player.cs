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
        public void Movment(Object Sender, Form form, int screenWidth)
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
            if (wPrawo && picBox.Left < screenWidth - picBox.Width - 25)
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
                if (x.Tag != "platforma")
                    continue;

                if (picBox.Bounds.IntersectsWith(x.Bounds) && !wskoku)
                {
                    grawitacja = 6;
                    picBox.Top = x.Top - picBox.Height + 1;
                    wlocie = false;
                    ostatni = x;
                }


            }


            //foreach (Control x in elementy)
            //{
            //    if (picBox.Bounds.IntersectsWith(x.Bounds) && !wskoku)
            //    {
            //        grawitacja = 6;
            //        picBox.Top = x.Top - picBox.Height + 1;
            //        wlocie = false;
            //        ostatni = x;
            //    }

            //}
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
