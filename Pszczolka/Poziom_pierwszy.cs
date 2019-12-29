﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Pszczolka
{
    public partial class Poziom_pierwszy : Form
    {
        bool wcisniety = false;
        Player pszczolka = new Player();
        List<Control> elementy = new List<Control>();
        public Poziom_pierwszy()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            pbPszczolka.BackColor = Color.Transparent;
            pbUl.BackColor = Color.Transparent;
            pbPszczolka.Parent = tlo;
            pbUl.Parent = tlo;
            elementy.Add(platforma1);
            elementy.Add(platforma2);
            elementy.Add(platforma3);
            elementy.Add(platforma4);
            elementy.Add(platforma5);
            elementy.Add(platforma6);
            elementy.Add(platforma7);
        }

        private void Poziom_pierwszy_Load(object sender, EventArgs e)
        {

        }

        private void Poziom_pierwszy_KeyDown(object sender, KeyEventArgs e)
        {
            pszczolka.ButtonDown(sender, e);
            if (!wcisniety)//zapogieganie zapetlaniu sie animacji, przez co wygladalo, jakby pszczola stala w miejscu
            {
                pbPszczolka.Image = (Image)Properties.Resources.ResourceManager.GetObject(pszczolka.animacja);
                wcisniety = true;
            }
        }

        private void Poziom_pierwszy_KeyUp(object sender, KeyEventArgs e)
        {
            pszczolka.ButtonUp(sender, e);
            pbPszczolka.Image = (Image)Properties.Resources.ResourceManager.GetObject(pszczolka.animacja);
            if (wcisniety) wcisniety = false;
        }

        private void glownyTimer_Tick(object sender, EventArgs e)
        {
            pszczolka.Movment(pbPszczolka,elementy,this.Width);
        }

    }
}
