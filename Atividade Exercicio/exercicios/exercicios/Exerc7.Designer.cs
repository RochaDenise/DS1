namespace exercicios
{
    partial class Exerc7
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txbNum = new System.Windows.Forms.TextBox();
            this.txbResul = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(203, 18);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Digite o número de anos: ";
            // 
            // txbNum
            // 
            this.txbNum.Location = new System.Drawing.Point(15, 54);
            this.txbNum.Name = "txbNum";
            this.txbNum.Size = new System.Drawing.Size(200, 20);
            this.txbNum.TabIndex = 1;
            // 
            // txbResul
            // 
            this.txbResul.Location = new System.Drawing.Point(36, 135);
            this.txbResul.Multiline = true;
            this.txbResul.Name = "txbResul";
            this.txbResul.Size = new System.Drawing.Size(202, 79);
            this.txbResul.TabIndex = 2;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(51, 92);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(164, 25);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Exerc7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txbResul);
            this.Controls.Add(this.txbNum);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Exerc7";
            this.Text = "Exerc7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txbNum;
        private System.Windows.Forms.TextBox txbResul;
        private System.Windows.Forms.Button btnCalc;
    }
}