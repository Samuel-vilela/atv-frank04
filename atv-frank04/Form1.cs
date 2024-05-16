using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atv_frank04
{
    public partial class Formula_baskara : Form
    {
        public Formula_baskara()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBoxA.Text);
            double b = double.Parse(textBoxB.Text);
            double c = double.Parse(textBoxC.Text);

            double delta = Math.Pow(b, 2) - 4 * a * c;

            labelDelta.Text = delta.ToString("F2");

            if (delta < 0)
            {
                MessageBox.Show("A equação não possui raízes reais.");
                return;
            }

            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            labelX1.Text = x1.ToString("F2");
            labelX2.Text = x2.ToString("F2");
        }

        private void btn_Apagar_Click(object sender, EventArgs e)
        {
            textBoxA.Text = "";
            textBoxB.Text = "";
            textBoxC.Text = "";

            labelDelta.Text = "";
            labelX1.Text = "";
            labelX2.Text = "";
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
