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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
           
                Form2 conexao = new Form2();
                this.Visible = false;
                conexao.ShowDialog();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 conexao = new Form3();
            this.Visible = false;
            conexao.ShowDialog();
        }
    }
}
