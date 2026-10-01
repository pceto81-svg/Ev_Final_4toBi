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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text == "Daniel" && textContrasena.Text == "11")
            {
                this.Hide();
                Form2 app = new Form2();
                app.Show();
            }
            else
            {
                MessageBox.Show("Datos o datos incorrectos");
            }
        }
    }
}
