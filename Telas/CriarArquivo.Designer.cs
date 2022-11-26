
namespace Telas
{
    partial class CriarArquivo
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
            this.TabelaPalavras = new System.Windows.Forms.DataGridView();
            this.SalvarTabela = new System.Windows.Forms.Button();
            this.labelPalavra = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaPalavras)).BeginInit();
            this.SuspendLayout();
            // 
            // CampoTexto
            // 
            this.CampoTexto.Location = new System.Drawing.Point(45, 50);
            this.CampoTexto.Name = "CampoTexto";
            this.CampoTexto.Size = new System.Drawing.Size(885, 148);
            this.CampoTexto.TabIndex = 0;
            this.CampoTexto.Text = "";
            this.CampoTexto.TextChanged += new System.EventHandler(this.CampoTexto_TextChanged);
            // 
            // BtnVerificar
            // 
            this.BtnVerificar.Location = new System.Drawing.Point(936, 102);
            this.BtnVerificar.Name = "BtnVerificar";
            this.BtnVerificar.Size = new System.Drawing.Size(138, 44);
            this.BtnVerificar.TabIndex = 1;
            this.BtnVerificar.Text = "Verificar";
            this.BtnVerificar.UseVisualStyleBackColor = true;
            this.BtnVerificar.Click += new System.EventHandler(this.Verificar);
            // 
            // TabelaPalavras
            // 
            this.TabelaPalavras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaPalavras.Location = new System.Drawing.Point(45, 288);
            this.TabelaPalavras.Name = "TabelaPalavras";
            this.TabelaPalavras.Size = new System.Drawing.Size(885, 150);
            this.TabelaPalavras.TabIndex = 3;
            this.TabelaPalavras.Visible = false;
            // 
            // SalvarTabela
            // 
            this.SalvarTabela.Location = new System.Drawing.Point(936, 327);
            this.SalvarTabela.Name = "SalvarTabela";
            this.SalvarTabela.Size = new System.Drawing.Size(138, 65);
            this.SalvarTabela.TabIndex = 4;
            this.SalvarTabela.Text = "Salvar";
            this.SalvarTabela.UseVisualStyleBackColor = true;
            this.SalvarTabela.Click += new System.EventHandler(this.SalvarTabelaDicionario);
            // 
            // labelPalavra
            // 
            this.labelPalavra.AutoSize = true;
            this.labelPalavra.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPalavra.Location = new System.Drawing.Point(40, 256);
            this.labelPalavra.Name = "labelPalavra";
            this.labelPalavra.Size = new System.Drawing.Size(313, 29);
            this.labelPalavra.TabIndex = 50;
            this.labelPalavra.Text = "Salva palavras no dicionario";
            this.labelPalavra.Visible = false;
            this.labelPalavra.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 29);
            this.label2.TabIndex = 51;
            this.label2.Text = "Escrever texto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CriarArquivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPalavra);
            this.Controls.Add(this.SalvarTabela);
            this.Controls.Add(this.TabelaPalavras);
            this.Controls.Add(this.BtnVerificar);
            this.Controls.Add(this.CampoTexto);
            this.Name = "CriarArquivo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabelaPalavras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox CampoTexto;
        private System.Windows.Forms.Button BtnVerificar;
        private System.Windows.Forms.DataGridView TabelaPalavras;
        private System.Windows.Forms.Button SalvarTabela;
        private System.Windows.Forms.Label labelPalavra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

