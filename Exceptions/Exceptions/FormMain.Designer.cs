namespace Exceptions
{
    partial class FormMain
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
            this.btnInvocar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnInvocar
            // 
            this.btnInvocar.Location = new System.Drawing.Point(12, 12);
            this.btnInvocar.Name = "btnInvocar";
            this.btnInvocar.Size = new System.Drawing.Size(75, 23);
            this.btnInvocar.TabIndex = 0;
            this.btnInvocar.Text = "Invocar";
            this.btnInvocar.UseVisualStyleBackColor = true;
            this.btnInvocar.Click += new System.EventHandler(this.btnInvocar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(620, 264);
            this.listBox1.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 346);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnInvocar);
            this.Name = "FormMain";
            this.Text = "Exceptions";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInvocar;
        private System.Windows.Forms.ListBox listBox1;
    }
}

