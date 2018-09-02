namespace ProgramaBalcao
{
    partial class FormBalcao
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
            this.BtnTerminar = new System.Windows.Forms.Button();
            this.ListaBalcao = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnTerminar
            // 
            this.BtnTerminar.Location = new System.Drawing.Point(12, 273);
            this.BtnTerminar.Name = "BtnTerminar";
            this.BtnTerminar.Size = new System.Drawing.Size(350, 57);
            this.BtnTerminar.TabIndex = 0;
            this.BtnTerminar.Text = "Terminar";
            this.BtnTerminar.UseVisualStyleBackColor = true;
            this.BtnTerminar.Click += new System.EventHandler(this.BtnTerminar_Click);
            // 
            // ListaBalcao
            // 
            this.ListaBalcao.FormattingEnabled = true;
            this.ListaBalcao.Location = new System.Drawing.Point(12, 17);
            this.ListaBalcao.Name = "ListaBalcao";
            this.ListaBalcao.Size = new System.Drawing.Size(349, 238);
            this.ListaBalcao.TabIndex = 1;
            // 
            // FormBalcao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 342);
            this.Controls.Add(this.ListaBalcao);
            this.Controls.Add(this.BtnTerminar);
            this.Name = "FormBalcao";
            this.Text = "Balcão";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBalcao_FormClosed);
            this.Load += new System.EventHandler(this.FormBalcao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnTerminar;
        private System.Windows.Forms.ListBox ListaBalcao;
    }
}

