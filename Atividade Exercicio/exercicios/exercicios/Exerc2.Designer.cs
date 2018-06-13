namespace exercicios
{
    partial class Exer2
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
            this.lblV1 = new System.Windows.Forms.Label();
            this.txbNum = new System.Windows.Forms.TextBox();
            this.btnResul = new System.Windows.Forms.Button();
            this.lblResul = new System.Windows.Forms.Label();
            this.txbResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblV1
            // 
            this.lblV1.AutoSize = true;
            this.lblV1.Location = new System.Drawing.Point(25, 28);
            this.lblV1.Name = "lblV1";
            this.lblV1.Size = new System.Drawing.Size(43, 13);
            this.lblV1.TabIndex = 0;
            this.lblV1.Text = "Valor 1:";
            // 
            // txbNum
            // 
            this.txbNum.Location = new System.Drawing.Point(89, 25);
            this.txbNum.Name = "txbNum";
            this.txbNum.Size = new System.Drawing.Size(153, 20);
            this.txbNum.TabIndex = 1;
            // 
            // btnResul
            // 
            this.btnResul.Location = new System.Drawing.Point(63, 95);
            this.btnResul.Name = "btnResul";
            this.btnResul.Size = new System.Drawing.Size(125, 37);
            this.btnResul.TabIndex = 2;
            this.btnResul.Text = "Resultado";
            this.btnResul.UseVisualStyleBackColor = true;
            this.btnResul.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResul
            // 
            this.lblResul.AutoSize = true;
            this.lblResul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResul.Location = new System.Drawing.Point(70, 173);
            this.lblResul.Name = "lblResul";
            this.lblResul.Size = new System.Drawing.Size(0, 16);
            this.lblResul.TabIndex = 3;
            // 
            // txbResultado
            // 
            this.txbResultado.Location = new System.Drawing.Point(28, 173);
            this.txbResultado.Name = "txbResultado";
            this.txbResultado.Size = new System.Drawing.Size(100, 20);
            this.txbResultado.TabIndex = 4;
            // 
            // Exer2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 228);
            this.Controls.Add(this.txbResultado);
            this.Controls.Add(this.lblResul);
            this.Controls.Add(this.btnResul);
            this.Controls.Add(this.txbNum);
            this.Controls.Add(this.lblV1);
            this.Name = "Exer2";
            this.Text = "Exercicio 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblV1;
        private System.Windows.Forms.TextBox txbNum;
        private System.Windows.Forms.Button btnResul;
        private System.Windows.Forms.Label lblResul;
        private System.Windows.Forms.TextBox txbResultado;
    }
}