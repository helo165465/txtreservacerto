using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorveteriatxt3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                if (tx_senhacadas.Text == tx_confcadas.Text)
                {
                    MessageBox.Show("Seu cadastro foi um sucesso!");
                    Form2 conexao = new Form2();
                    this.Visible = false;
                    conexao.ShowDialog();

                }

                else
                {
                    MessageBox.Show("As senhas digitadas são diferentes, por favor tente novamente!");
                    tx_senhacadas.Clear();
                    tx_confcadas.Clear();
                }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 conexao = new Form3();
            this.Visible = false;
            conexao.ShowDialog();
        }
    }
}
