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
    public partial class TelaSair : Form
    {
        public TelaSair()
        {
            InitializeComponent();
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Obrigado por usar o nosso sistema.");
            Application.Exit();
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            new TelaPrincipal().Show();
            this.Hide();
        }
    }
}
