namespace Ejemplo_1_Programación_3
{
    partial class FuncionesAsincronas
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
            this.HornearPizzaButton = new System.Windows.Forms.Button();
            this.OtrasTareasButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SumarButton = new System.Windows.Forms.Button();
            this.Numero1TextBox = new System.Windows.Forms.TextBox();
            this.Numero2TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HornearPizzaButton
            // 
            this.HornearPizzaButton.Location = new System.Drawing.Point(122, 31);
            this.HornearPizzaButton.Name = "HornearPizzaButton";
            this.HornearPizzaButton.Size = new System.Drawing.Size(147, 57);
            this.HornearPizzaButton.TabIndex = 0;
            this.HornearPizzaButton.Text = "Hornear Pizza";
            this.HornearPizzaButton.UseVisualStyleBackColor = true;
            this.HornearPizzaButton.Click += new System.EventHandler(this.HornearPizzaButton_Click);
            // 
            // OtrasTareasButton
            // 
            this.OtrasTareasButton.Location = new System.Drawing.Point(541, 31);
            this.OtrasTareasButton.Name = "OtrasTareasButton";
            this.OtrasTareasButton.Size = new System.Drawing.Size(131, 57);
            this.OtrasTareasButton.TabIndex = 1;
            this.OtrasTareasButton.Text = "Otras Tareas";
            this.OtrasTareasButton.UseVisualStyleBackColor = true;
            this.OtrasTareasButton.Click += new System.EventHandler(this.OtrasTareasButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(122, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // SumarButton
            // 
            this.SumarButton.Location = new System.Drawing.Point(284, 307);
            this.SumarButton.Name = "SumarButton";
            this.SumarButton.Size = new System.Drawing.Size(94, 29);
            this.SumarButton.TabIndex = 3;
            this.SumarButton.Text = "Sumar";
            this.SumarButton.UseVisualStyleBackColor = true;
            this.SumarButton.Click += new System.EventHandler(this.SumarButton_Click);
            // 
            // Numero1TextBox
            // 
            this.Numero1TextBox.Location = new System.Drawing.Point(122, 284);
            this.Numero1TextBox.Name = "Numero1TextBox";
            this.Numero1TextBox.Size = new System.Drawing.Size(125, 27);
            this.Numero1TextBox.TabIndex = 4;
            // 
            // Numero2TextBox
            // 
            this.Numero2TextBox.Location = new System.Drawing.Point(122, 333);
            this.Numero2TextBox.Name = "Numero2TextBox";
            this.Numero2TextBox.Size = new System.Drawing.Size(125, 27);
            this.Numero2TextBox.TabIndex = 5;
            // 
            // FuncionesAsincronas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Numero2TextBox);
            this.Controls.Add(this.Numero1TextBox);
            this.Controls.Add(this.SumarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OtrasTareasButton);
            this.Controls.Add(this.HornearPizzaButton);
            this.Name = "FuncionesAsincronas";
            this.Text = "FuncionesAsincronas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button HornearPizzaButton;
        private Button OtrasTareasButton;
        private Label label1;
        private Button SumarButton;
        private TextBox Numero1TextBox;
        private TextBox Numero2TextBox;
    }
}