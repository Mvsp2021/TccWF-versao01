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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            new TelaPrincipal().Show();
            this.Hide();
        }

 

        private void btnSobre_Click(object sender, EventArgs e)
        {
            new Sobre().Show();
           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            new TelaSairInicial().Show();
        }
    }
}
