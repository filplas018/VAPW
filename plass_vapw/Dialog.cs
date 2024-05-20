using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plass_vapw
{
    public partial class Dialog : Form
    {
        public bool UseTimer { get { return TimerButton.Checked; } }

        public Dialog()
        {
            InitializeComponent();
        }
    }
}