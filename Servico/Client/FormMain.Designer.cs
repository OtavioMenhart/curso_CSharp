namespace Client
{
    partial class Cliente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.btnInvocarWCF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(45, 31);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(220, 20);
            this.txtMensagem.TabIndex = 0;
            this.txtMensagem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnInvocarWCF
            // 
            this.btnInvocarWCF.Location = new System.Drawing.Point(45, 78);
            this.btnInvocarWCF.Name = "btnInvocarWCF";
            this.btnInvocarWCF.Size = new System.Drawing.Size(111, 23);
            this.btnInvocarWCF.TabIndex = 1;
            this.btnInvocarWCF.Text = "Invocar Serviço";
            this.btnInvocarWCF.UseVisualStyleBackColor = true;
            this.btnInvocarWCF.Click += new System.EventHandler(this.btnInvocarWCF_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 168);
            this.Controls.Add(this.btnInvocarWCF);
            this.Controls.Add(this.txtMensagem);
            this.Name = "Cliente";
            this.Text = "Cliente - WCF";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Button btnInvocarWCF;
    }
}

