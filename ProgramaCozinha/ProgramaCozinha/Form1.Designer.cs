namespace ProgramaCozinha
{
    partial class FormCozinha
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
            this.ListaChegada = new System.Windows.Forms.ListBox();
            this.ListaSaida = new System.Windows.Forms.ListBox();
            this.BtnPronto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListaChegada
            // 
            this.ListaChegada.FormattingEnabled = true;
            this.ListaChegada.Location = new System.Drawing.Point(12, 12);
            this.ListaChegada.Name = "ListaChegada";
            this.ListaChegada.Size = new System.Drawing.Size(176, 303);
            this.ListaChegada.TabIndex = 0;
            this.ListaChegada.DoubleClick += new System.EventHandler(this.ListaChegada_DoubleClick);
            // 
            // ListaSaida
            // 
            this.ListaSaida.FormattingEnabled = true;
            this.ListaSaida.Location = new System.Drawing.Point(204, 12);
            this.ListaSaida.Name = "ListaSaida";
            this.ListaSaida.Size = new System.Drawing.Size(177, 303);
            this.ListaSaida.TabIndex = 1;
            this.ListaSaida.DoubleClick += new System.EventHandler(this.ListaSaida_DoubleClick);
            // 
            // BtnPronto
            // 
            this.BtnPronto.Location = new System.Drawing.Point(12, 322);
            this.BtnPronto.Name = "BtnPronto";
            this.BtnPronto.Size = new System.Drawing.Size(369, 48);
            this.BtnPronto.TabIndex = 2;
            this.BtnPronto.Text = "Pronto";
            this.BtnPronto.UseVisualStyleBackColor = true;
            this.BtnPronto.Click += new System.EventHandler(this.BtnPronto_Click);
            // 
            // FormCozinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 382);
            this.Controls.Add(this.BtnPronto);
            this.Controls.Add(this.ListaSaida);
            this.Controls.Add(this.ListaChegada);
            this.Name = "FormCozinha";
            this.Text = "Cozinha";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCozinha_FormClosed);
            this.Load += new System.EventHandler(this.FormCozinha_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListaChegada;
        private System.Windows.Forms.ListBox ListaSaida;
        private System.Windows.Forms.Button BtnPronto;
    }
}

