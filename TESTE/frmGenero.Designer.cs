﻿namespace TESTE
{
    partial class frmGenero
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
            this.bttPesq = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttAtualizar = new System.Windows.Forms.Button();
            this.bttExcluir = new System.Windows.Forms.Button();
            this.bttCad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttPesq
            // 
            this.bttPesq.Location = new System.Drawing.Point(136, 29);
            this.bttPesq.Name = "bttPesq";
            this.bttPesq.Size = new System.Drawing.Size(57, 23);
            this.bttPesq.TabIndex = 105;
            this.bttPesq.Text = "Pesq";
            this.bttPesq.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 104;
            this.label2.Text = "Gênero:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(250, 31);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(242, 20);
            this.txtNome.TabIndex = 103;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(94, 31);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(36, 20);
            this.txtCodigo.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 101;
            this.label1.Text = "Código:";
            // 
            // bttAtualizar
            // 
            this.bttAtualizar.Location = new System.Drawing.Point(368, 75);
            this.bttAtualizar.Name = "bttAtualizar";
            this.bttAtualizar.Size = new System.Drawing.Size(75, 23);
            this.bttAtualizar.TabIndex = 108;
            this.bttAtualizar.Text = "Atualizar";
            this.bttAtualizar.UseVisualStyleBackColor = true;
            // 
            // bttExcluir
            // 
            this.bttExcluir.Location = new System.Drawing.Point(243, 75);
            this.bttExcluir.Name = "bttExcluir";
            this.bttExcluir.Size = new System.Drawing.Size(75, 23);
            this.bttExcluir.TabIndex = 107;
            this.bttExcluir.Text = "Excluir";
            this.bttExcluir.UseVisualStyleBackColor = true;
            // 
            // bttCad
            // 
            this.bttCad.Location = new System.Drawing.Point(117, 75);
            this.bttCad.Name = "bttCad";
            this.bttCad.Size = new System.Drawing.Size(75, 23);
            this.bttCad.TabIndex = 106;
            this.bttCad.Text = "Cadastrar";
            this.bttCad.UseVisualStyleBackColor = true;
            // 
            // frmGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 115);
            this.Controls.Add(this.bttAtualizar);
            this.Controls.Add(this.bttExcluir);
            this.Controls.Add(this.bttCad);
            this.Controls.Add(this.bttPesq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Name = "frmGenero";
            this.Text = "Registro Gênero";
            this.Load += new System.EventHandler(this.frmGenero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttPesq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttAtualizar;
        private System.Windows.Forms.Button bttExcluir;
        private System.Windows.Forms.Button bttCad;
    }
}