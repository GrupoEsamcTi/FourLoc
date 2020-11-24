namespace TESTE
{
    partial class TESTE
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
            this.bttTeste = new System.Windows.Forms.Button();
            this.txtTeste = new System.Windows.Forms.TextBox();
            this.bttMostrar = new System.Windows.Forms.Button();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // bttTeste
            // 
            this.bttTeste.Location = new System.Drawing.Point(255, 157);
            this.bttTeste.Name = "bttTeste";
            this.bttTeste.Size = new System.Drawing.Size(75, 23);
            this.bttTeste.TabIndex = 0;
            this.bttTeste.Text = "Teste";
            this.bttTeste.UseVisualStyleBackColor = true;
            this.bttTeste.Click += new System.EventHandler(this.bttTeste_Click);
            // 
            // txtTeste
            // 
            this.txtTeste.Location = new System.Drawing.Point(243, 119);
            this.txtTeste.Name = "txtTeste";
            this.txtTeste.Size = new System.Drawing.Size(100, 20);
            this.txtTeste.TabIndex = 1;
            // 
            // bttMostrar
            // 
            this.bttMostrar.Location = new System.Drawing.Point(383, 157);
            this.bttMostrar.Name = "bttMostrar";
            this.bttMostrar.Size = new System.Drawing.Size(75, 23);
            this.bttMostrar.TabIndex = 2;
            this.bttMostrar.Text = "Ver imagem";
            this.bttMostrar.UseVisualStyleBackColor = true;
            this.bttMostrar.Click += new System.EventHandler(this.bttMostrar_Click);
            // 
            // pbImagem
            // 
            this.pbImagem.Location = new System.Drawing.Point(357, 12);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(153, 136);
            this.pbImagem.TabIndex = 3;
            this.pbImagem.TabStop = false;
            // 
            // TESTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbImagem);
            this.Controls.Add(this.bttMostrar);
            this.Controls.Add(this.txtTeste);
            this.Controls.Add(this.bttTeste);
            this.Name = "TESTE";
            this.Text = "TESTE";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttTeste;
        private System.Windows.Forms.TextBox txtTeste;
        private System.Windows.Forms.Button bttMostrar;
        private System.Windows.Forms.PictureBox pbImagem;
    }
}