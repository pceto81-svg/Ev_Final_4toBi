using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ev_Final_4toBi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            Byte Num1 = Byte. Parse (textVar1.Text);
            Byte Num2 = Byte.Parse(textVar2.Text);
            int Producto = Num1 * Num2;
            MessageBox.Show("El Resultado es: " + Producto);
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            Byte Num1 = Byte.Parse(textVar1.Text);
            Byte Num2 = Byte.Parse(textVar2.Text);
            int Suma = Num1 + Num2;
            MessageBox.Show("El Resultado es: " + Suma);
        }

        private void BtnPotencia_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(textVar1.Text); 
            int Num2 = int.Parse(textVar2.Text);
            int Potencia = 1; 
            int J = 0; 
            while (J != Num2) 
            { 
                Potencia = Potencia * Num1; 
                J++; 
            } 
            MessageBox.Show("El R// es" + Potencia);
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            float Num1 = float.Parse(textVar1.Text);
            float Num2 = float.Parse(textVar2.Text);
            if (Num2 > 0)
            { 
                float Division = Num1 / Num2;
                MessageBox.Show("El R// es " + Division);
            }
            else
            {
                MessageBox.Show("No se puede dividir entre 0");
            }
        }
    }
}
