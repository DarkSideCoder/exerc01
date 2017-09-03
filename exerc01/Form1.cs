using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exerc01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //String mcs = "Seja Bem Vindo";
            //MessageBox.Show(mcs);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btEntrada_Click(object sender, EventArgs e)
        {
            saudacao();
        }

        public void saudacao()
        {
            String name;
            String msgsaudar = "Seja Bem Vindo ";
            name = cxEntrada01.Text;
            MessageBox.Show(msgsaudar + name, "Mensagem ",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);
        }
    }
}
