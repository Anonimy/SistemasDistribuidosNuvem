namespace SistemaGarcom
{
    partial class Form
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
            this.listaCardapio = new System.Windows.Forms.ListBox();
            this.listaPedidos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputMesa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaCardapio
            // 
            this.listaCardapio.FormattingEnabled = true;
            this.listaCardapio.Location = new System.Drawing.Point(12, 96);
            this.listaCardapio.Name = "listaCardapio";
            this.listaCardapio.Size = new System.Drawing.Size(173, 277);
            this.listaCardapio.TabIndex = 0;
            this.listaCardapio.DoubleClick += new System.EventHandler(this.listaCardapio_DoubleClick);
            // 
            // listaPedidos
            // 
            this.listaPedidos.FormattingEnabled = true;
            this.listaPedidos.Location = new System.Drawing.Point(205, 96);
            this.listaPedidos.Name = "listaPedidos";
            this.listaPedidos.Size = new System.Drawing.Size(180, 277);
            this.listaPedidos.TabIndex = 1;
            this.listaPedidos.DoubleClick += new System.EventHandler(this.listaPedidos_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cardápio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pedidos";
            // 
            // inputMesa
            // 
            this.inputMesa.Location = new System.Drawing.Point(54, 34);
            this.inputMesa.Name = "inputMesa";
            this.inputMesa.Size = new System.Drawing.Size(131, 20);
            this.inputMesa.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mesa:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(205, 31);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(180, 25);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 384);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputMesa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaPedidos);
            this.Controls.Add(this.listaCardapio);
            this.Name = "Form";
            this.Text = "Garçom";
            this.Load += new System.EventHandler(this.form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listaCardapio;
        private System.Windows.Forms.ListBox listaPedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputMesa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnviar;
    }
}

