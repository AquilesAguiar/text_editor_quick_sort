
namespace Telas
{
    partial class Form1
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
            this.CampoTexto = new System.Windows.Forms.RichTextBox();
            this.BtnVerificar = new System.Windows.Forms.Button();
            this.PalavrasComum = new System.Windows.Forms.Label();
            this.TabelaPalavras = new System.Windows.Forms.DataGridView();
            this.SalvarTabela = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaPalavras)).BeginInit();
            this.SuspendLayout();
            // 
            // CampoTexto
            // 
            this.CampoTexto.Location = new System.Drawing.Point(68, 12);
            this.CampoTexto.Name = "CampoTexto";
            this.CampoTexto.Size = new System.Drawing.Size(341, 96);
            this.CampoTexto.TabIndex = 0;
            this.CampoTexto.Text = "";
            // 
            // BtnVerificar
            // 
            this.BtnVerificar.Location = new System.Drawing.Point(334, 114);
            this.BtnVerificar.Name = "BtnVerificar";
            this.BtnVerificar.Size = new System.Drawing.Size(75, 23);
            this.BtnVerificar.TabIndex = 1;
            this.BtnVerificar.Text = "Verificar";
            this.BtnVerificar.UseVisualStyleBackColor = true;
            this.BtnVerificar.Click += new System.EventHandler(this.Verificar);
            // 
            // PalavrasComum
            // 
            this.PalavrasComum.AutoSize = true;
            this.PalavrasComum.Location = new System.Drawing.Point(509, 90);
            this.PalavrasComum.Name = "PalavrasComum";
            this.PalavrasComum.Size = new System.Drawing.Size(0, 13);
            this.PalavrasComum.TabIndex = 2;
            this.PalavrasComum.Click += new System.EventHandler(this.PalavrasComum_Click);
            // 
            // TabelaPalavras
            // 
            this.TabelaPalavras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaPalavras.Location = new System.Drawing.Point(68, 239);
            this.TabelaPalavras.Name = "TabelaPalavras";
            this.TabelaPalavras.Size = new System.Drawing.Size(441, 150);
            this.TabelaPalavras.TabIndex = 3;
            this.TabelaPalavras.Visible = false;
            // 
            // SalvarTabela
            // 
            this.SalvarTabela.Location = new System.Drawing.Point(434, 395);
            this.SalvarTabela.Name = "SalvarTabela";
            this.SalvarTabela.Size = new System.Drawing.Size(75, 23);
            this.SalvarTabela.TabIndex = 4;
            this.SalvarTabela.Text = "Salvar";
            this.SalvarTabela.UseVisualStyleBackColor = true;
            this.SalvarTabela.Click += new System.EventHandler(this.SalvarTabelaDicionario);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SalvarTabela);
            this.Controls.Add(this.TabelaPalavras);
            this.Controls.Add(this.PalavrasComum);
            this.Controls.Add(this.BtnVerificar);
            this.Controls.Add(this.CampoTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TabelaPalavras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox CampoTexto;
        private System.Windows.Forms.Button BtnVerificar;
        private System.Windows.Forms.Label PalavrasComum;
        private System.Windows.Forms.DataGridView TabelaPalavras;
        private System.Windows.Forms.Button SalvarTabela;
    }
}

