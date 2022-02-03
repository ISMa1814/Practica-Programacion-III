namespace Ejemplo_1_Programación_3
{
    partial class FuncionesFecha
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
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ProcesarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DiaTextBox = new System.Windows.Forms.TextBox();
            this.MesTextBox = new System.Windows.Forms.TextBox();
            this.AnioTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DiaLetraTextBox = new System.Windows.Forms.TextBox();
            this.SumaDiasTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EdadTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker.Location = new System.Drawing.Point(312, 12);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(137, 27);
            this.DateTimePicker.TabIndex = 0;
            // 
            // ProcesarButton
            // 
            this.ProcesarButton.Location = new System.Drawing.Point(559, 13);
            this.ProcesarButton.Name = "ProcesarButton";
            this.ProcesarButton.Size = new System.Drawing.Size(94, 29);
            this.ProcesarButton.TabIndex = 1;
            this.ProcesarButton.Text = "Procesar";
            this.ProcesarButton.UseVisualStyleBackColor = true;
            this.ProcesarButton.Click += new System.EventHandler(this.ProcesarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Día";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Año";
            // 
            // DiaTextBox
            // 
            this.DiaTextBox.Location = new System.Drawing.Point(109, 59);
            this.DiaTextBox.Name = "DiaTextBox";
            this.DiaTextBox.Size = new System.Drawing.Size(125, 27);
            this.DiaTextBox.TabIndex = 5;
            // 
            // MesTextBox
            // 
            this.MesTextBox.Location = new System.Drawing.Point(109, 92);
            this.MesTextBox.Name = "MesTextBox";
            this.MesTextBox.Size = new System.Drawing.Size(125, 27);
            this.MesTextBox.TabIndex = 6;
            // 
            // AnioTextBox
            // 
            this.AnioTextBox.Location = new System.Drawing.Point(109, 125);
            this.AnioTextBox.Name = "AnioTextBox";
            this.AnioTextBox.Size = new System.Drawing.Size(125, 27);
            this.AnioTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Día en Letra";
            // 
            // DiaLetraTextBox
            // 
            this.DiaLetraTextBox.Location = new System.Drawing.Point(109, 158);
            this.DiaLetraTextBox.Name = "DiaLetraTextBox";
            this.DiaLetraTextBox.Size = new System.Drawing.Size(125, 27);
            this.DiaLetraTextBox.TabIndex = 9;
            // 
            // SumaDiasTextBox
            // 
            this.SumaDiasTextBox.Location = new System.Drawing.Point(109, 191);
            this.SumaDiasTextBox.Name = "SumaDiasTextBox";
            this.SumaDiasTextBox.Size = new System.Drawing.Size(125, 27);
            this.SumaDiasTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Suma Días";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Edad";
            // 
            // EdadTextBox
            // 
            this.EdadTextBox.Location = new System.Drawing.Point(109, 228);
            this.EdadTextBox.Name = "EdadTextBox";
            this.EdadTextBox.Size = new System.Drawing.Size(125, 27);
            this.EdadTextBox.TabIndex = 13;
            // 
            // FuncionesFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EdadTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SumaDiasTextBox);
            this.Controls.Add(this.DiaLetraTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AnioTextBox);
            this.Controls.Add(this.MesTextBox);
            this.Controls.Add(this.DiaTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProcesarButton);
            this.Controls.Add(this.DateTimePicker);
            this.Name = "FuncionesFecha";
            this.Text = "FuncionesFecha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker DateTimePicker;
        private Button ProcesarButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox DiaTextBox;
        private TextBox MesTextBox;
        private TextBox AnioTextBox;
        private Label label4;
        private TextBox DiaLetraTextBox;
        private TextBox SumaDiasTextBox;
        private Label label5;
        private Label label6;
        private TextBox EdadTextBox;
    }
}