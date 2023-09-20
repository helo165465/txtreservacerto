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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            if (cb_cardapio.Text == "Baunilha")
            {
                lb_resultado.Text = "R$ 10,00";

            }
            if (cb_cardapio.Text == "Chocolate")
            {
                lb_resultado.Text = "R$ 15,00";
            }

            if (cb_cardapio.Text == "Ovomaltine")
            {
                lb_resultado.Text = "R$ 20,00";
            }

            if (cb_cardapio.Text == "Morango")
            {
                lb_resultado.Text = "R$ 10,00";
            }

            if (cb_cardapio.Text == "Maracujá")
            {
                lb_resultado.Text = "R$ 12,00";
            }

            if (cb_cardapio.Text == "Flocos")
            {
                lb_resultado.Text = "R$ 18,00";
            }

            if (cb_cardapio.Text == "Torta Alemã")
            {
                lb_resultado.Text = "R$ 20,00";
            }
            

            DateTime h = DateTime.Now;
        

            string caminho = @"C:\Users\2022102020021\Desktop\saborc.txt";

    
                using (StreamWriter sw = new StreamWriter(caminho))//imprime no documento de texto
                {

                    MessageBox.Show(cb_cardapio.Text);
                    sw.WriteLine(cb_cardapio.Text);
                 

                    if (cb_cardapio.Text == "Baunilha")
                    {
                        lb_resultado.Text = "R$ 10,00";
                        sw.WriteLine("R$ 10,00");
                    }

                    if (cb_cardapio.Text == "Chocolate")
                    {
                        lb_resultado.Text = "R$ 15,00";
                        sw.WriteLine("R$ 15,00");

                    }

                    if (cb_cardapio.Text == "Ovomaltine")
                    {
                        lb_resultado.Text = "R$ 20,00";
                        sw.WriteLine("R$ 20,00");

                    }

                    if (cb_cardapio.Text == "Morango")
                    {
                        lb_resultado.Text = "R$ 10,00";
                        sw.WriteLine("R$ 10,00");

                    }

                    if (cb_cardapio.Text == "Maracujá")
                    {
                        lb_resultado.Text = "R$ 12,00";
                        sw.WriteLine("R$ 12,00");

                    }

                    if (cb_cardapio.Text == "Flocos")
                    {
                        lb_resultado.Text = "R$ 18,00";
                        sw.WriteLine("R$ 18,00");
                    }

                    if (cb_cardapio.Text == "Torta Alemã")
                    {
                        lb_resultado.Text = "R$ 20,00";
                        sw.WriteLine("R$ 20,00");

                    }
                    sw.WriteLine(h.ToString("HH:mm:ss"));
                }
        


    }
    }
}
