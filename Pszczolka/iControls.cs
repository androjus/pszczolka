using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pszczolka
{
    interface iControls
    {
        void ButtonDown(object sender, KeyEventArgs e);
        void ButtonUp(object sender, KeyEventArgs e);
    }
}
