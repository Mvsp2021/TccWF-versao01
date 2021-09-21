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
    public partial class TelaCadUsuarios : Form
    {
        public TelaCadUsuarios()
        {
            InitializeComponent();
        }

        private void TelaCadUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            new TelaPrincipal().Show();
            this.Hide();
        }

        private void MenuUsuariosNovo_Click(object sender, EventArgs e)
        {
            new TelaNovoUsuario().Show();
            this.Hide();
        }
    }
}
