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
    public partial class F_Quadrado : Form
    {
        public F_Quadrado()
        {
            InitializeComponent();
        }

        decimal valor1 = 0;

        private void txtValorL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtValorL.Text != "")
            {
                valor1 = Convert.ToDecimal(txtValorL.Text);
                txtValorL.Text = "";
                txtResult.Text = Convert.ToString(valor1 * valor1);
            }
            else
            {
                txtResult.Text = "";
            }
        }
    }
}
