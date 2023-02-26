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
    public partial class F_Triangulo : Form
    {
        public F_Triangulo()
        {
            InitializeComponent();
        }

        decimal valor1 = 0, valor2 = 0;

        private void txtValorB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtValorA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtValorB.Text != "" || txtValorA.Text != "")
            {
                valor1 = Convert.ToDecimal(txtValorB.Text);
                valor2 = Convert.ToDecimal(txtValorA.Text);
                txtValorB.Text = "";
                txtValorA.Text = "";
                txtResult.Text = Convert.ToString((valor1 * valor2)/2);
            }
            else
            {
                txtResult.Text = "";
            }
        }
    }
}
