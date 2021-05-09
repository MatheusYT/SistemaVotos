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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            labelCAND1.Text = Class1.CANDIDATO1;
            labelCAND2.Text = Class1.CANDIDATO2;
            labelCAND3.Text = Class1.CANDIDATO3;
            labelCAND4.Text = Class1.CANDIDATO4;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void cadastrarCandidatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form TELAcandidatos = new FormCANDIDATOS();
            TELAcandidatos.Show();
            Class1.MG = 0;
            Class1.SP = 0;
            Class1.RJ = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBoxESTADO.Text == "" || textBoxVOT.Text == "")
            {
                MessageBox.Show("preencha todos os campos");
            }
            else
            {



                // VOTOS NUMEROS //
                if (textBoxVOT.Text == "1")
                {
                    Class1.VOTOS1 = Class1.VOTOS1 + 1;
                }
                else
                {
                    if (textBoxVOT.Text == "2")
                        Class1.VOTOS2 = Class1.VOTOS2 + 1;
                }
                if (textBoxVOT.Text == "3")
                {
                    Class1.VOTOS3 = Class1.VOTOS3 + 1;
                }
                else
                {
                    if (textBoxVOT.Text == "4")
                        Class1.VOTOS4 = Class1.VOTOS4 + 1;
                }
                labelVOTO1.Text = Convert.ToString(Class1.VOTOS1);
                labelVOTO2.Text = Convert.ToString(Class1.VOTOS2);
                labelVOTO3.Text = Convert.ToString(Class1.VOTOS3);
                labelVOTO4.Text = Convert.ToString(Class1.VOTOS4);
                Class1.VOTOS = Class1.VOTOS + 1;
                // TERMINA VOTOS NUMEROS//

                // Calculo porcentagem homem mulher
                if (radioButtonHOMEM.Checked)
                {
                    Class1.VOTOSH = Class1.VOTOSH + 1;
                }

                if (radioButtonMULHER.Checked)
                {
                    Class1.VOTOSM = Class1.VOTOSM + 1;
                }

                labelHOMEM.Text = Convert.ToString((Class1.VOTOSH * 100) / Class1.VOTOS) + ("%");
                labelMULHER.Text = Convert.ToString((Class1.VOTOSM * 100) / Class1.VOTOS) + ("%");
                // termina calculo porcentagem homem mulher

                if (comboBoxESTADO.Text == "São Paulo")
                {
                    Class1.SP = Class1.SP + 1;
                }
                if (comboBoxESTADO.Text == "Rio de Janeiro")
                {
                    Class1.RJ = Class1.RJ + 1;
                }
                if (comboBoxESTADO.Text == "Minas Gerais")
                {
                    Class1.MG = Class1.MG + 1;
                }

                labelRJ.Text = Convert.ToString(Class1.RJ);
                labelMG.Text = Convert.ToString(Class1.MG);
                labelSP.Text = Convert.ToString(Class1.SP);




                // VENCEDOR COM QUANTOS VOTOS VVV
                if (Class1.VOTOS1 > Class1.VOTOS2)
                {
                    labelVENCEDOR.Text = ("Candidato 1 é o vencedor");
                }
                else
                {
                    labelVENCEDOR.Text = ("Candidato 2 é o vencedor");
                }
                if (Class1.VOTOS3 > Class1.VOTOS4)
                {
                    labelVENCEDOR.Text = ("Candidato 3 é o vencedor");
                }
                else
                {
                    labelVENCEDOR.Text = ("Candidato 4 é o vencedor");
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

