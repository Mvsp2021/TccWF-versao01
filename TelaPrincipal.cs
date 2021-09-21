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
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void TelaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            new TelaSair().Show();
            
        }

        private void MenuTelaCadUsuarios_Click(object sender, EventArgs e)
        {
            new TelaCadUsuarios().Show();
            
        }

        private void MenuTelaCadFiliais_Click(object sender, EventArgs e)
        {
            new TelaCadFiliais().Show();
            
        }

        private void MenuSair_Click(object sender, EventArgs e)
        {
            new TelaSair().Show();
            
        }

    }
}
