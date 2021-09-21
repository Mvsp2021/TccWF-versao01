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
    public partial class TelaCadFiliais : Form
    {
        public TelaCadFiliais()
        {
            InitializeComponent();
        }

        private void MenuFiliaisNovo_Click(object sender, EventArgs e)
        {
            new TelaNovoFilial().Show();
            this.Hide();
        }

        private void TelaCadFiliais_FormClosed(object sender, FormClosedEventArgs e)
        {
            new TelaPrincipal().Show();
            this.Hide();
        }
    }
}
