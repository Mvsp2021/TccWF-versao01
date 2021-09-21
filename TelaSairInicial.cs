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
    public partial class TelaSairInicial : Form
    {
        public TelaSairInicial()
        {
            InitializeComponent();
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Obrigado por utilizar nosso sistema.");
            Application.Exit();
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            new TelaInicial().Show();
        }
    }
}
