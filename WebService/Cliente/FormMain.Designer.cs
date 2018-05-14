namespace Cliente
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnInvocarWebService = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(57, 41);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(231, 20);
            this.txtResult.TabIndex = 0;
            // 
            // btnInvocarWebService
            // 
            this.btnInvocarWebService.Location = new System.Drawing.Point(57, 83);
            this.btnInvocarWebService.Name = "btnInvocarWebService";
            this.btnInvocarWebService.Size = new System.Drawing.Size(75, 23);
            this.btnInvocarWebService.TabIndex = 1;
            this.btnInvocarWebService.Text = "Invocar";
            this.btnInvocarWebService.UseVisualStyleBackColor = true;
            this.btnInvocarWebService.Click += new System.EventHandler(this.btnInvocarWebService_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(304, 159);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 367);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnInvocarWebService);
            this.Controls.Add(this.txtResult);
            this.Name = "FormMain";
            this.Text = "Cliente Web Service";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnInvocarWebService;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

