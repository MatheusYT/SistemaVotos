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
    public partial class FormCANDIDATOS : Form
    {
        public FormCANDIDATOS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1.CANDIDATO1 = textBoxCAD1.Text;
            Class1.CANDIDATO2 = textBoxCAD2.Text;
            Class1.CANDIDATO3 = textBoxCAD3.Text;
            Class1.CANDIDATO4 = textBoxCAD4.Text;

            


            MessageBox.Show("Candidatos Cadastrados Com Sucesso");
            this.Hide();

            Form TELAvotos = new Form2();
            TELAvotos.Show();

            TELAvotos.Closed += (s, args) => this.Close();


        }
    }
}
