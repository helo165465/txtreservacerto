namespace Sorveteriatxt3
{
    partial class Form4
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_nomecadas = new System.Windows.Forms.TextBox();
            this.tx_emailcadas = new System.Windows.Forms.TextBox();
            this.tx_senhacadas = new System.Windows.Forms.TextBox();
            this.tx_confcadas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(97, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Senha: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(114, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Confirmar senha: ";
            // 
            // tx_nomecadas
            // 
            this.tx_nomecadas.Location = new System.Drawing.Point(230, 142);
            this.tx_nomecadas.Name = "tx_nomecadas";
            this.tx_nomecadas.Size = new System.Drawing.Size(205, 20);
            this.tx_nomecadas.TabIndex = 11;
            // 
            // tx_emailcadas
            // 
            this.tx_emailcadas.Location = new System.Drawing.Point(230, 185);
            this.tx_emailcadas.Name = "tx_emailcadas";
            this.tx_emailcadas.Size = new System.Drawing.Size(205, 20);
            this.tx_emailcadas.TabIndex = 12;
            // 
            // tx_senhacadas
            // 
            this.tx_senhacadas.Location = new System.Drawing.Point(230, 223);
            this.tx_senhacadas.Name = "tx_senhacadas";
            this.tx_senhacadas.Size = new System.Drawing.Size(148, 20);
            this.tx_senhacadas.TabIndex = 14;
            // 
            // tx_confcadas
            // 
            this.tx_confcadas.Location = new System.Drawing.Point(230, 262);
            this.tx_confcadas.Name = "tx_confcadas";
            this.tx_confcadas.Size = new System.Drawing.Size(148, 20);
            this.tx_confcadas.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(186, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 39);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cadastro";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sorveteriatxt3.Properties.Resources.cardapio1;
            this.ClientSize = new System.Drawing.Size(500, 491);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx_confcadas);
            this.Controls.Add(this.tx_senhacadas);
            this.Controls.Add(this.tx_emailcadas);
            this.Controls.Add(this.tx_nomecadas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tx_nomecadas;
        private System.Windows.Forms.TextBox tx_emailcadas;
        private System.Windows.Forms.TextBox tx_senhacadas;
        private System.Windows.Forms.TextBox tx_confcadas;
        private System.Windows.Forms.Label label3;
    }
}

