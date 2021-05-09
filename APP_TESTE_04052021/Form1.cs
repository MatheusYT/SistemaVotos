using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_TESTE_04052021
{
    public partial class Form1 : Form
    {
        string login;
        string senha;

        public Form1()
        {
            InitializeComponent();
            login = "matheus";
            senha = "matheus123";
            Class1.CANDIDATO1 = "";
            Class1.CANDIDATO2 = "";
            Class1.CANDIDATO3 = "";
            Class1.CANDIDATO4 = "";
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxLOGIN.Text == login && textBoxSENHA.Text == senha)
            {
                this.Hide();
                Form TELAcandidatos = new FormCANDIDATOS();
                TELAcandidatos.Closed += (s, args) => this.Close();
                TELAcandidatos.Show();

            }
            else
            {
                MessageBox.Show("Usuario ou senha incorreto");
            }
        }
    }
}
