namespace cliente_s4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Palindromo = new System.Windows.Forms.RadioButton();
            this.Mayusculas = new System.Windows.Forms.RadioButton();
            this.Grados = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE (en minúsculas)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(259, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(391, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Palindromo
            // 
            this.Palindromo.AutoSize = true;
            this.Palindromo.Location = new System.Drawing.Point(259, 149);
            this.Palindromo.Name = "Palindromo";
            this.Palindromo.Size = new System.Drawing.Size(294, 24);
            this.Palindromo.TabIndex = 2;
            this.Palindromo.TabStop = true;
            this.Palindromo.Text = "Díme si mi nombre es palíndromo (1/)";
            this.Palindromo.UseVisualStyleBackColor = true;
            // 
            // Mayusculas
            // 
            this.Mayusculas.AutoSize = true;
            this.Mayusculas.Location = new System.Drawing.Point(259, 196);
            this.Mayusculas.Name = "Mayusculas";
            this.Mayusculas.Size = new System.Drawing.Size(272, 24);
            this.Mayusculas.TabIndex = 3;
            this.Mayusculas.TabStop = true;
            this.Mayusculas.Text = "Pon mi nombre en mayúsculas(2/)";
            this.Mayusculas.UseVisualStyleBackColor = true;
            this.Mayusculas.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Grados
            // 
            this.Grados.AutoSize = true;
            this.Grados.Location = new System.Drawing.Point(259, 302);
            this.Grados.Name = "Grados";
            this.Grados.Size = new System.Drawing.Size(121, 24);
            this.Grados.TabIndex = 4;
            this.Grados.TabStop = true;
            this.Grados.Text = "ºC --> ºK (3/)";
            this.Grados.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Temperatura (ºC)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(212, 252);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(438, 26);
            this.textBox2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 46);
            this.button1.TabIndex = 7;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Grados);
            this.Controls.Add(this.Mayusculas);
            this.Controls.Add(this.Palindromo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton Palindromo;
        private System.Windows.Forms.RadioButton Mayusculas;
        private System.Windows.Forms.RadioButton Grados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}

