namespace Sorveteriatxt3
{
    partial class Form3
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cb_cardapio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_resultado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(172, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cardápio:";
            // 
            // cb_cardapio
            // 
            this.cb_cardapio.FormattingEnabled = true;
            this.cb_cardapio.Items.AddRange(new object[] {
            "Baunilha",
            "Chocolate",
            "Ovomaltine",
            "Morango",
            "Maracujá",
            "Flocos",
            "Torta Alemã"});
            this.cb_cardapio.Location = new System.Drawing.Point(170, 208);
            this.cb_cardapio.Name = "cb_cardapio";
            this.cb_cardapio.Size = new System.Drawing.Size(181, 21);
            this.cb_cardapio.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(197, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor: ";
            // 
            // lb_resultado
            // 
            this.lb_resultado.AutoSize = true;
            this.lb_resultado.BackColor = System.Drawing.Color.Transparent;
            this.lb_resultado.Location = new System.Drawing.Point(261, 286);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(55, 13);
            this.lb_resultado.TabIndex = 3;
            this.lb_resultado.Text = "Resultado";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Comprar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sorveteriatxt3.Properties.Resources.cardapio1;
            this.ClientSize = new System.Drawing.Size(500, 491);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_resultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_cardapio);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_cardapio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_resultado;
        private System.Windows.Forms.Button button1;
    }
}

