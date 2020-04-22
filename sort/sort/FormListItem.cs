using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sort
{
    class FormListItem
    {
        private PictureBox pb;
        private TextBox tb;
        public PictureBox Pb
        {
            get
            {
                return pb;
            }
        }
        public TextBox Tb
        {
            get
            {
                return tb;
            }
        }

        public FormListItem(PictureBox _pb, TextBox _tb)
        {
            pb = _pb;
            tb = _tb;
        }
    }
}
