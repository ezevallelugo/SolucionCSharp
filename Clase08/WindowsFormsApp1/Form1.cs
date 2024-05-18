using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Controles";
            TextBox textBox = new TextBox();
            textBox.Text = "Mi textbox";
            textBox.Location = new Point(5, 59);
            textBox.TabIndex = 0;
            this.Controls.Add(textBox);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SegundoFormulario segundoFormulario = new SegundoFormulario();
            segundoFormulario.Show();
        }

        private void btnMensaje_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este mensaje se autodestruira");
        }

        private void btnOtroMensaje_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje","Informe",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
        }
    }
}
