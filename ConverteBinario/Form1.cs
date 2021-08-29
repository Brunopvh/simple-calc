using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverteBinario
{
    public partial class Form1 : Form
    {
        string[] basesNumericas = new string[2] { "Binario", "Decimal" };
        

        public Form1()
        {
            InitializeComponent();
        }

        private void labelBaseFinal_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBases.Text == "Binário")
            {
                labelBaseAtualDestino.Text = "Decimal";
            }
            else if (comboBoxBases.Text == "Decimal")
            {
                labelBaseAtualDestino.Text = "Binário";
            }
        }

        private void textBoxDestino_TextChanged(object sender, EventArgs e)
        {

        }

        public bool isDec(string num)
        {
            try
            {
                //int num_int = Int32.Parse(num);
                int num_int = Convert.ToInt32(num);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool isBin(string num)
        {
            for (int i=0; i<num.Length; i++)
            {
                if (!num[i].Equals('0') && !num[i].Equals('1'))
                {
                    //MessageBox.Show("Número não é igual 1 ou 0 -> " + num[i], "Alerta !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                    break;
                }
            }

            return true;
        }

        public void convParaBin(string num)
        {
            // Usar o método isBin() para verificar se
            // num pode ser convertido em binário.
            if (!isBin(num))
            {
                MessageBox.Show("Número incorreto." + num, "Alerta !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Converter a string num para inteiro.
            int num_bin;
            try
            {
                num_bin = Convert.ToInt32(num);
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique o preenchimento das informações no formulario ! ", "Alerta !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            textBoxDestino.Text = "Convertido com sucesso." + comboBoxBases.Text;
        }

        public void convParaDec(string num)
        {
            // Usar o método isBin() para verificar se
            // num pode ser convertido em binário.
            if (!isDec(num))
            {
                MessageBox.Show("Número incorreto." + num, "Alerta !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Converter a string num para inteiro.
            int num_dec;
            try
            {
                num_dec = Convert.ToInt32(num);
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique o preenchimento das informações no formulario ! ", "Alerta !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            textBoxDestino.Text = "Convertido com sucesso." + comboBoxBases.Text;
        }

        private void buttonConverter_Click(object sender, EventArgs e)
        {
            // checar qual base está selecionada no COMBO bases.
            if (comboBoxBases.Text == "Binário")
            {
                // Base selecionada é Binário, chamar o método convParaBin
                // e passar como parâmetro o texto digitado pelo usuário 
                // na caixa de texto superior.
                convParaBin(textBoxOrigem.Text);
            }
            else if (comboBoxBases.Text == "Decimal")
            {
                convParaDec(textBoxOrigem.Text);
            }
            else
            {
                convParaBin(textBoxOrigem.Text);
            }
        }
    }
}
