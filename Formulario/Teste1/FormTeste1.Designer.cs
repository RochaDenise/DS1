namespace Teste1
{
    partial class FormTeste1
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txbnome = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txbcpf = new System.Windows.Forms.TextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.txbrg = new System.Windows.Forms.TextBox();
            this.btnCads = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 13);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txbnome
            // 
            this.txbnome.Location = new System.Drawing.Point(57, 10);
            this.txbnome.Name = "txbnome";
            this.txbnome.Size = new System.Drawing.Size(179, 20);
            this.txbnome.TabIndex = 1;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(13, 53);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(30, 13);
            this.lblCpf.TabIndex = 2;
            this.lblCpf.Text = "CPF:";
            // 
            // txbcpf
            // 
            this.txbcpf.Location = new System.Drawing.Point(57, 45);
            this.txbcpf.Name = "txbcpf";
            this.txbcpf.Size = new System.Drawing.Size(179, 20);
            this.txbcpf.TabIndex = 3;
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(16, 87);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(26, 13);
            this.lblRg.TabIndex = 4;
            this.lblRg.Text = "RG:";
            // 
            // txbrg
            // 
            this.txbrg.Location = new System.Drawing.Point(57, 79);
            this.txbrg.Name = "txbrg";
            this.txbrg.Size = new System.Drawing.Size(179, 20);
            this.txbrg.TabIndex = 5;
            // 
            // btnCads
            // 
            this.btnCads.Location = new System.Drawing.Point(57, 155);
            this.btnCads.Name = "btnCads";
            this.btnCads.Size = new System.Drawing.Size(193, 35);
            this.btnCads.TabIndex = 6;
            this.btnCads.Text = "Cadastrar";
            this.btnCads.UseVisualStyleBackColor = true;
            this.btnCads.Click += new System.EventHandler(this.btnCads_Click);
            // 
            // FormTeste1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 254);
            this.Controls.Add(this.btnCads);
            this.Controls.Add(this.txbrg);
            this.Controls.Add(this.lblRg);
            this.Controls.Add(this.txbcpf);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.txbnome);
            this.Controls.Add(this.lblNome);
            this.Name = "FormTeste1";
            this.Text = "Cadastro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTeste1_FormClosing_1);
            this.Load += new System.EventHandler(this.FormTeste1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbnome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txbcpf;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.TextBox txbrg;
        private System.Windows.Forms.Button btnCads;
    }
}