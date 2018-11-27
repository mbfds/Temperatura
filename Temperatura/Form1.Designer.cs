namespace Temperatura
{
    partial class Form1
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
			this.label2 = new System.Windows.Forms.Label();
			this.txtbTemperatura = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtbResultado = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(39, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Conversor de Temperatura";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(26, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Temperatura :";
			// 
			// txtbTemperatura
			// 
			this.txtbTemperatura.Location = new System.Drawing.Point(99, 61);
			this.txtbTemperatura.Name = "txtbTemperatura";
			this.txtbTemperatura.Size = new System.Drawing.Size(100, 20);
			this.txtbTemperatura.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(39, 372);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Resultado : ";
			// 
			// txtbResultado
			// 
			this.txtbResultado.Location = new System.Drawing.Point(109, 369);
			this.txtbResultado.Name = "txtbResultado";
			this.txtbResultado.Size = new System.Drawing.Size(100, 20);
			this.txtbResultado.TabIndex = 10;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(23, 114);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(203, 23);
			this.button1.TabIndex = 11;
			this.button1.Text = "Fahrenheit para Celsius";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(23, 155);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(203, 23);
			this.button2.TabIndex = 12;
			this.button2.Text = "Fahrenheit para Kelvin";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(23, 196);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(203, 23);
			this.button3.TabIndex = 13;
			this.button3.Text = "Kelvin para Fahrenheit";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(23, 242);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(203, 23);
			this.button4.TabIndex = 14;
			this.button4.Text = "Kelvin para Celsius";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(23, 281);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(203, 23);
			this.button5.TabIndex = 15;
			this.button5.Text = "Celsius para Fahrenheit";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(23, 326);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(203, 23);
			this.button6.TabIndex = 16;
			this.button6.Text = "Celsius para Kelvin";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtbResultado);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtbTemperatura);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Conversor de Temperatura";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbTemperatura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbResultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

