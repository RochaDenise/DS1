namespace exercicios
{
    partial class Exer3
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
            this.lblValor1 = new System.Windows.Forms.Label();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.lblValor3 = new System.Windows.Forms.Label();
            this.txbValor1 = new System.Windows.Forms.TextBox();
            this.txbValor3 = new System.Windows.Forms.TextBox();
            this.txbValor2 = new System.Windows.Forms.TextBox();
            this.btnResul = new System.Windows.Forms.Button();
            this.lblResul = new System.Windows.Forms.Label();
            this.lblTirulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Location = new System.Drawing.Point(24, 62);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(40, 13);
            this.lblValor1.TabIndex = 0;
            this.lblValor1.Text = "Valor 1";
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Location = new System.Drawing.Point(132, 62);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(40, 13);
            this.lblValor2.TabIndex = 1;
            this.lblValor2.Text = "Valor 2";
            // 
            // lblValor3
            // 
            this.lblValor3.AutoSize = true;
            this.lblValor3.Location = new System.Drawing.Point(242, 58);
            this.lblValor3.Name = "lblValor3";
            this.lblValor3.Size = new System.Drawing.Size(40, 13);
            this.lblValor3.TabIndex = 2;
            this.lblValor3.Text = "Valor 3";
            // 
            // txbValor1
            // 
            this.txbValor1.Location = new System.Drawing.Point(70, 55);
            this.txbValor1.Name = "txbValor1";
            this.txbValor1.Size = new System.Drawing.Size(40, 20);
            this.txbValor1.TabIndex = 3;
            // 
            // txbValor3
            // 
            this.txbValor3.Location = new System.Drawing.Point(301, 55);
            this.txbValor3.Name = "txbValor3";
            this.txbValor3.Size = new System.Drawing.Size(44, 20);
            this.txbValor3.TabIndex = 4;
            // 
            // txbValor2
            // 
            this.txbValor2.Location = new System.Drawing.Point(178, 55);
            this.txbValor2.Name = "txbValor2";
            this.txbValor2.Size = new System.Drawing.Size(40, 20);
            this.txbValor2.TabIndex = 5;
            // 
            // btnResul
            // 
            this.btnResul.Location = new System.Drawing.Point(135, 110);
            this.btnResul.Name = "btnResul";
            this.btnResul.Size = new System.Drawing.Size(99, 32);
            this.btnResul.TabIndex = 6;
            this.btnResul.Text = "Classificar";
            this.btnResul.UseVisualStyleBackColor = true;
            this.btnResul.Click += new System.EventHandler(this.btnResul_Click);
            // 
            // lblResul
            // 
            this.lblResul.AutoSize = true;
            this.lblResul.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResul.Location = new System.Drawing.Point(157, 145);
            this.lblResul.Name = "lblResul";
            this.lblResul.Size = new System.Drawing.Size(0, 18);
            this.lblResul.TabIndex = 7;
            // 
            // lblTirulo
            // 
            this.lblTirulo.AutoSize = true;
            this.lblTirulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTirulo.Location = new System.Drawing.Point(67, 18);
            this.lblTirulo.Name = "lblTirulo";
            this.lblTirulo.Size = new System.Drawing.Size(220, 18);
            this.lblTirulo.TabIndex = 8;
            this.lblTirulo.Text = "Digite os lados do Triângulo";
            // 
            // Exer3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 188);
            this.Controls.Add(this.lblTirulo);
            this.Controls.Add(this.lblResul);
            this.Controls.Add(this.btnResul);
            this.Controls.Add(this.txbValor2);
            this.Controls.Add(this.txbValor3);
            this.Controls.Add(this.txbValor1);
            this.Controls.Add(this.lblValor3);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.lblValor1);
            this.Name = "Exer3";
            this.Text = "Exercicio 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.Label lblValor3;
        private System.Windows.Forms.TextBox txbValor1;
        private System.Windows.Forms.TextBox txbValor3;
        private System.Windows.Forms.TextBox txbValor2;
        private System.Windows.Forms.Button btnResul;
        private System.Windows.Forms.Label lblResul;
        private System.Windows.Forms.Label lblTirulo;
    }
}