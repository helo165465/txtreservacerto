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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form5 conexao = new Form5();
            this.Visible = false;
            conexao.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 conexao = new Form4();
            this.Visible = false;
            conexao.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
