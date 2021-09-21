using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TccWF_versao01
{
    public partial class TelaNovoFilial : Form
    {
        public TelaNovoFilial()
        {
            InitializeComponent();
        }

        private void TelaNovoFilial_FormClosed(object sender, FormClosedEventArgs e)
        {
            new TelaCadFiliais().Show();
            this.Hide();
        }
    }
}
