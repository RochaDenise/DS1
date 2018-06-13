namespace exercicios
{
    partial class Exer6
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
            this.lblNum = new System.Windows.Forms.Label();
            this.txbNum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txbResul2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(92, 20);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(100, 23);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "Número: ";
            // 
            // txbNum
            // 
            this.txbNum.Location = new System.Drawing.Point(79, 55);
            this.txbNum.Name = "txbNum";
            this.txbNum.Size = new System.Drawing.Size(113, 20);
            this.txbNum.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbResul2
            // 
            this.txbResul2.Location = new System.Drawing.Point(12, 131);
            this.txbResul2.Multiline = true;
            this.txbResul2.Name = "txbResul2";
            this.txbResul2.Size = new System.Drawing.Size(254, 79);
            this.txbResul2.TabIndex = 3;
            // 
            // Exer6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 222);
            this.Controls.Add(this.txbResul2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbNum);
            this.Controls.Add(this.lblNum);
            this.Name = "Exer6";
            this.Text = "Exercicio 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txbNum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbResul2;
    }
}