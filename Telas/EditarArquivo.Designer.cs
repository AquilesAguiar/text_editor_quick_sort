namespace Telas
{
    partial class EditarArquivo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SalvarTabela = new System.Windows.Forms.Button();
            this.TabelaPalavras = new System.Windows.Forms.DataGridView();
            this.BtnVerificar = new System.Windows.Forms.Button();
            this.CampoTexto = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaPalavras)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 29);
            this.label2.TabIndex = 58;
            this.label2.Text = "Editar Arquivo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 29);
            this.label1.TabIndex = 57;
            this.label1.Text = "Salva palavras no dicionario";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(908, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 44);
            this.button1.TabIndex = 56;
            this.button1.Text = "Carregar Arquivo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SalvarTabela
            // 
            this.SalvarTabela.Location = new System.Drawing.Point(908, 318);
            this.SalvarTabela.Name = "SalvarTabela";
            this.SalvarTabela.Size = new System.Drawing.Size(138, 65);
            this.SalvarTabela.TabIndex = 55;
            this.SalvarTabela.Text = "Salvar";
            this.SalvarTabela.UseVisualStyleBackColor = true;
            // 
            // TabelaPalavras
            // 
            this.TabelaPalavras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaPalavras.Location = new System.Drawing.Point(17, 279);
            this.TabelaPalavras.Name = "TabelaPalavras";
            this.TabelaPalavras.Size = new System.Drawing.Size(885, 150);
            this.TabelaPalavras.TabIndex = 54;
            this.TabelaPalavras.Visible = false;
            // 
            // BtnVerificar
            // 
            this.BtnVerificar.Location = new System.Drawing.Point(908, 41);
            this.BtnVerificar.Name = "BtnVerificar";
            this.BtnVerificar.Size = new System.Drawing.Size(138, 44);
            this.BtnVerificar.TabIndex = 53;
            this.BtnVerificar.Text = "Verificar";
            this.BtnVerificar.UseVisualStyleBackColor = true;
            // 
            // CampoTexto
            // 
            this.CampoTexto.Location = new System.Drawing.Point(17, 41);
            this.CampoTexto.Name = "CampoTexto";
            this.CampoTexto.Size = new System.Drawing.Size(885, 148);
            this.CampoTexto.TabIndex = 52;
            this.CampoTexto.Text = "";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SalvarTabela);
            this.Controls.Add(this.TabelaPalavras);
            this.Controls.Add(this.BtnVerificar);
            this.Controls.Add(this.CampoTexto);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.TabelaPalavras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SalvarTabela;
        private System.Windows.Forms.DataGridView TabelaPalavras;
        private System.Windows.Forms.Button BtnVerificar;
        private System.Windows.Forms.RichTextBox CampoTexto;
    }
}