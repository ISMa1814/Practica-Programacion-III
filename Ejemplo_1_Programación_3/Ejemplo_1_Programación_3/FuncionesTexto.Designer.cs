namespace Ejemplo_1_Programación_3
{
    partial class FuncionesTexto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProcesarButton = new System.Windows.Forms.Button();
            this.CadenaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LongitudTextBox = new System.Windows.Forms.TextBox();
            this.PrimerCaracterTextBox = new System.Windows.Forms.TextBox();
            this.UltimoCaracterTextBox = new System.Windows.Forms.TextBox();
            this.MayusculaTextBox = new System.Windows.Forms.TextBox();
            this.MinusculaTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ProcesarButton
            // 
            this.ProcesarButton.Location = new System.Drawing.Point(661, 45);
            this.ProcesarButton.Name = "ProcesarButton";
            this.ProcesarButton.Size = new System.Drawing.Size(94, 29);
            this.ProcesarButton.TabIndex = 0;
            this.ProcesarButton.Text = "Procesar";
            this.ProcesarButton.UseVisualStyleBackColor = true;
            this.ProcesarButton.Click += new System.EventHandler(this.ProcesarButton_Click);
            // 
            // CadenaTextBox
            // 
            this.CadenaTextBox.Location = new System.Drawing.Point(139, 12);
            this.CadenaTextBox.Name = "CadenaTextBox";
            this.CadenaTextBox.Size = new System.Drawing.Size(524, 27);
            this.CadenaTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Longitud";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Primer Caracter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ultimo Caracter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mayucula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Minuscula";
            // 
            // LongitudTextBox
            // 
            this.LongitudTextBox.Location = new System.Drawing.Point(139, 66);
            this.LongitudTextBox.Name = "LongitudTextBox";
            this.LongitudTextBox.Size = new System.Drawing.Size(125, 27);
            this.LongitudTextBox.TabIndex = 7;
            // 
            // PrimerCaracterTextBox
            // 
            this.PrimerCaracterTextBox.Location = new System.Drawing.Point(139, 109);
            this.PrimerCaracterTextBox.Name = "PrimerCaracterTextBox";
            this.PrimerCaracterTextBox.Size = new System.Drawing.Size(125, 27);
            this.PrimerCaracterTextBox.TabIndex = 8;
            // 
            // UltimoCaracterTextBox
            // 
            this.UltimoCaracterTextBox.Location = new System.Drawing.Point(139, 165);
            this.UltimoCaracterTextBox.Name = "UltimoCaracterTextBox";
            this.UltimoCaracterTextBox.Size = new System.Drawing.Size(125, 27);
            this.UltimoCaracterTextBox.TabIndex = 9;
            // 
            // MayusculaTextBox
            // 
            this.MayusculaTextBox.Location = new System.Drawing.Point(139, 219);
            this.MayusculaTextBox.Name = "MayusculaTextBox";
            this.MayusculaTextBox.Size = new System.Drawing.Size(125, 27);
            this.MayusculaTextBox.TabIndex = 10;
            // 
            // MinusculaTextBox
            // 
            this.MinusculaTextBox.Location = new System.Drawing.Point(139, 276);
            this.MinusculaTextBox.Name = "MinusculaTextBox";
            this.MinusculaTextBox.Size = new System.Drawing.Size(125, 27);
            this.MinusculaTextBox.TabIndex = 11;
            // 
            // FuncionesTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MinusculaTextBox);
            this.Controls.Add(this.MayusculaTextBox);
            this.Controls.Add(this.UltimoCaracterTextBox);
            this.Controls.Add(this.PrimerCaracterTextBox);
            this.Controls.Add(this.LongitudTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CadenaTextBox);
            this.Controls.Add(this.ProcesarButton);
            this.Name = "FuncionesTexto";
            this.Text = "FuncionesTexto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ProcesarButton;
        private TextBox CadenaTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox LongitudTextBox;
        private TextBox PrimerCaracterTextBox;
        private TextBox UltimoCaracterTextBox;
        private TextBox MayusculaTextBox;
        private TextBox MinusculaTextBox;
    }
}