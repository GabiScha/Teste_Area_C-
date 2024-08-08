using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcule_Click(object sender, EventArgs e)
        {

            double res = 0;
            double raio = Double.Parse(txtraio.Text);


            res = Math.PI * raio * raio;

            lblresultado.Text = ("O ressultado é : " + res);


        }
    }
}
