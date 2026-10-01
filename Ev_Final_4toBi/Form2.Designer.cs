namespace Ev_Final_4toBi
{
    partial class Form2
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
            this.textVar1 = new System.Windows.Forms.TextBox();
            this.textVar2 = new System.Windows.Forms.TextBox();
            this.BtnPotencia = new System.Windows.Forms.Button();
            this.BtnSuma = new System.Windows.Forms.Button();
            this.BtnDivision = new System.Windows.Forms.Button();
            this.BtnProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textVar1
            // 
            this.textVar1.Location = new System.Drawing.Point(283, 99);
            this.textVar1.Name = "textVar1";
            this.textVar1.Size = new System.Drawing.Size(100, 20);
            this.textVar1.TabIndex = 0;
            // 
            // textVar2
            // 
            this.textVar2.Location = new System.Drawing.Point(283, 145);
            this.textVar2.Name = "textVar2";
            this.textVar2.Size = new System.Drawing.Size(100, 20);
            this.textVar2.TabIndex = 1;
            // 
            // BtnPotencia
            // 
            this.BtnPotencia.BackColor = System.Drawing.Color.Blue;
            this.BtnPotencia.Location = new System.Drawing.Point(299, 183);
            this.BtnPotencia.Name = "BtnPotencia";
            this.BtnPotencia.Size = new System.Drawing.Size(75, 23);
            this.BtnPotencia.TabIndex = 2;
            this.BtnPotencia.Text = "Potencia";
            this.BtnPotencia.UseVisualStyleBackColor = false;
            this.BtnPotencia.Click += new System.EventHandler(this.BtnPotencia_Click);
            // 
            // BtnSuma
            // 
            this.BtnSuma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnSuma.Location = new System.Drawing.Point(190, 122);
            this.BtnSuma.Name = "BtnSuma";
            this.BtnSuma.Size = new System.Drawing.Size(75, 23);
            this.BtnSuma.TabIndex = 3;
            this.BtnSuma.Text = "Suma";
            this.BtnSuma.UseVisualStyleBackColor = false;
            this.BtnSuma.Click += new System.EventHandler(this.BtnSuma_Click);
            // 
            // BtnDivision
            // 
            this.BtnDivision.BackColor = System.Drawing.Color.Cyan;
            this.BtnDivision.Location = new System.Drawing.Point(402, 122);
            this.BtnDivision.Name = "BtnDivision";
            this.BtnDivision.Size = new System.Drawing.Size(75, 23);
            this.BtnDivision.TabIndex = 4;
            this.BtnDivision.Text = "Division";
            this.BtnDivision.UseVisualStyleBackColor = false;
            this.BtnDivision.Click += new System.EventHandler(this.BtnDivision_Click);
            // 
            // BtnProducto
            // 
            this.BtnProducto.BackColor = System.Drawing.Color.Yellow;
            this.BtnProducto.Location = new System.Drawing.Point(299, 60);
            this.BtnProducto.Name = "BtnProducto";
            this.BtnProducto.Size = new System.Drawing.Size(75, 23);
            this.BtnProducto.TabIndex = 5;
            this.BtnProducto.Text = "Producto";
            this.BtnProducto.UseVisualStyleBackColor = false;
            this.BtnProducto.Click += new System.EventHandler(this.BtnProducto_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnProducto);
            this.Controls.Add(this.BtnDivision);
            this.Controls.Add(this.BtnSuma);
            this.Controls.Add(this.BtnPotencia);
            this.Controls.Add(this.textVar2);
            this.Controls.Add(this.textVar1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textVar1;
        private System.Windows.Forms.TextBox textVar2;
        private System.Windows.Forms.Button BtnPotencia;
        private System.Windows.Forms.Button BtnSuma;
        private System.Windows.Forms.Button BtnDivision;
        private System.Windows.Forms.Button BtnProducto;
    }
}