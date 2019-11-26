using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCesarApp
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            //limpar a box de decrypt
            txtBoxDecriptar.Text = string.Empty;

            if (txtBoxAvancar.Text == "")
            {
                MessageBox.Show("Quantidade para avançar não pode ser branco!");
            }
            else
            {
                //Intera todas as letra do texto puro
                for (int i = 0; i < txtBoxEncriptar.Text.Length; i++)

                {
                    //Devolve o código ASCII da letra
                    int ASCII = (int)txtBoxEncriptar.Text[i];

                    //Coloca a chave fixa de posições a mais no número da tabela ASCII
                    int ASCIIC = ASCII + Convert.ToInt32(txtBoxAvancar.Text);

                    //Concatena o texto na caixa de texto do texto crifrado
                    txtBoxDecriptar.Text += Char.ConvertFromUtf32(ASCIIC);
                }
            }               
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            //Limpa a caixa de texto
            txtBox.Text = string.Empty;

            if (txtBoxAvancar.Text == "")
            {
                MessageBox.Show("Quantidade para avançar não pode ser branco!");
            }
            else
            {
                //Intera todas as letras do texto cifrado
                for (int i = 0; i < txtBoxDecriptar.Text.Length; i++)

                {

                    //Devolve o código ASCII da letra
                    int ASCII = (int)txtBoxDecriptar.Text[i];

                    //Coloca a chave fixa de posições a menos no número da tabela ASCII
                    int ASCIIC = ASCII - Convert.ToInt32(txtBoxAvancar.Text);

                    //Concatena o texto na caixa de texto do texto decifrado
                    txtBox.Text += Char.ConvertFromUtf32(ASCIIC);

                }
            }            
        }

        private void btn_ClearAll_Click(object sender, EventArgs e)
        {
            txtBoxEncriptar.Text = string.Empty;
            txtBoxDecriptar.Text = string.Empty;
            txtBox.Text = string.Empty;
            txtBoxAvancar.Text = string.Empty;
        }
    }
}
