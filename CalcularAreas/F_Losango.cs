using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularAreas
{
    public partial class F_Losango : Form
    {
        public F_Losango()
        {
            InitializeComponent();
        }

        decimal valor1 = 0, valor2 = 0;

        private void txtValorDM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtValorD.Text != "" || txtValorDM.Text != "")
            {
                valor1 = Convert.ToDecimal(txtValorD.Text);
                valor2 = Convert.ToDecimal(txtValorDM.Text);
                txtValorD.Text = "";
                txtValorDM.Text = "";
                txtResult.Text = Convert.ToString((valor1 * valor2) / 2);
            }
            else
            {
                txtResult.Text = "";
            }
        }

        private void txtValorD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

    }
}
