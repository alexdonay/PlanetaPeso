using System;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace PlanetaPeso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private const Double MERCURIO = .37;
        private const Double VENUS = .88;
        private const Double MARTE = .38;
        private const Double JUPTER = 2.64;
        private const Double SATURNO = 1.15;
        private const Double URANO = 1.17;
        private Double coeficiente = 1;
        string planeta = "";
        private void btCalcula_Click(object sender, EventArgs e)
        {


            if (txPesoTerra.Text == "")
            {
                MessageBox.Show("Valor incorreto");
            }
            else if (rbJupter.Checked)
            {

                coeficiente = JUPTER;
                planeta = "Jupter";
            }
            else if (rbSaturno.Checked)
            {
                coeficiente = SATURNO;
                planeta = "Saturno";
            }
            else if (rbMarte.Checked)
            {
                coeficiente = MARTE;
                planeta = "Marte";
            }
            else if (rbMercurio.Checked)
            {
                coeficiente = MERCURIO;
                planeta = "Mercúrio";
            }
            else if (rbUrano.Checked)
            {
                coeficiente = URANO;
                planeta = "Urano";
            }
            else if (rbVenus.Checked)
            {
                coeficiente = VENUS;
                planeta = "Vênus";
            }
            if(coeficiente != 1)
            {
                double valor = 0;
                double.TryParse(txPesoTerra.Text,out valor);
                MessageBox.Show($"No planeta {planeta} o peso seria de : {(valor * coeficiente):N2} kg");
            }
        }

        private void txPesoTerra_KeyPress(object sender, KeyPressEventArgs e)
        {
            char decimalSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != decimalSeparator && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            // Permite apenas um separador decimal
            if (e.KeyChar == decimalSeparator && ((TextBox)sender).Text.Contains(decimalSeparator))
            {
                e.Handled = true;
            }
        }
    }
}
