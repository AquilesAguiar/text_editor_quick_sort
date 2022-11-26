namespace Telas
{
    partial class TelaPrincipal
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
            this.BtnArquivo = new System.Windows.Forms.Button();
            this.BtnCria = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // BtnArquivo
            // 
            this.BtnArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnArquivo.Location = new System.Drawing.Point(12, 274);
            this.BtnArquivo.Name = "BtnArquivo";
            this.BtnArquivo.Size = new System.Drawing.Size(620, 89);
            this.BtnArquivo.TabIndex = 0;
            this.BtnArquivo.Text = "Carregar Arquivo";
            this.BtnArquivo.UseVisualStyleBackColor = true;
            this.BtnArquivo.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnCria
            // 
            this.BtnCria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCria.Location = new System.Drawing.Point(12, 69);
            this.BtnCria.Name = "BtnCria";
            this.BtnCria.Size = new System.Drawing.Size(620, 89);
            this.BtnCria.TabIndex = 1;
            this.BtnCria.Text = "Criar Arquivo";
            this.BtnCria.UseVisualStyleBackColor = true;
            this.BtnCria.Click += new System.EventHandler(this.BtnTexto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.BtnCria);
            this.Controls.Add(this.BtnArquivo);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnArquivo;
        private System.Windows.Forms.Button BtnCria;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}