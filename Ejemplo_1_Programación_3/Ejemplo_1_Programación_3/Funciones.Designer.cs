namespace Ejemplo_1_Programación_3
{
    partial class Funciones
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SumarButton = new System.Windows.Forms.Button();
            this.Numero1TextBox = new System.Windows.Forms.TextBox();
            this.Numero2TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ResultadoTextBox = new System.Windows.Forms.TextBox();
            this.MostrarMensajeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SumarButton
            // 
            this.SumarButton.Location = new System.Drawing.Point(638, 103);
            this.SumarButton.Name = "SumarButton";
            this.SumarButton.Size = new System.Drawing.Size(94, 29);
            this.SumarButton.TabIndex = 1;
            this.SumarButton.Text = "Sumar";
            this.SumarButton.UseVisualStyleBackColor = true;
            this.SumarButton.Click += new System.EventHandler(this.SumarButton_Click);
            // 
            // Numero1TextBox
            // 
            this.Numero1TextBox.Location = new System.Drawing.Point(371, 96);
            this.Numero1TextBox.Name = "Numero1TextBox";
            this.Numero1TextBox.Size = new System.Drawing.Size(125, 27);
            this.Numero1TextBox.TabIndex = 2;
            // 
            // Numero2TextBox
            // 
            this.Numero2TextBox.Location = new System.Drawing.Point(371, 185);
            this.Numero2TextBox.Name = "Numero2TextBox";
            this.Numero2TextBox.Size = new System.Drawing.Size(125, 27);
            this.Numero2TextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Número 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Número 2";
            // 
            // ResultadoTextBox
            // 
            this.ResultadoTextBox.Location = new System.Drawing.Point(517, 275);
            this.ResultadoTextBox.Name = "ResultadoTextBox";
            this.ResultadoTextBox.Size = new System.Drawing.Size(125, 27);
            this.ResultadoTextBox.TabIndex = 6;
            // 
            // MostrarMensajeButton
            // 
            this.MostrarMensajeButton.Location = new System.Drawing.Point(638, 155);
            this.MostrarMensajeButton.Name = "MostrarMensajeButton";
            this.MostrarMensajeButton.Size = new System.Drawing.Size(94, 29);
            this.MostrarMensajeButton.TabIndex = 7;
            this.MostrarMensajeButton.Text = "Mensaje";
            this.MostrarMensajeButton.UseVisualStyleBackColor = true;
            this.MostrarMensajeButton.Click += new System.EventHandler(this.MostrarMensajeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MostrarMensajeButton);
            this.Controls.Add(this.ResultadoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Numero2TextBox);
            this.Controls.Add(this.Numero1TextBox);
            this.Controls.Add(this.SumarButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button SumarButton;
        private TextBox Numero1TextBox;
        private TextBox Numero2TextBox;
        private Label label1;
        private Label label2;
        private TextBox ResultadoTextBox;
        private Button MostrarMensajeButton;
    }
}