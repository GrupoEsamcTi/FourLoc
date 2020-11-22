namespace TESTE
{
    partial class frmCadastroCliente
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
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.dtpDtNasc = new System.Windows.Forms.DateTimePicker();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mtbCel = new System.Windows.Forms.MaskedTextBox();
            this.mtbTel = new System.Windows.Forms.MaskedTextBox();
            this.mtbCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbRG = new System.Windows.Forms.MaskedTextBox();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttCad = new System.Windows.Forms.Button();
            this.bttExcluir = new System.Windows.Forms.Button();
            this.bttAtualizar = new System.Windows.Forms.Button();
            this.bttPesq = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Solteiro",
            "Casada",
            "Divorciado"});
            this.cbEstado.Location = new System.Drawing.Point(421, 64);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(83, 21);
            this.cbEstado.TabIndex = 61;
            // 
            // dtpDtNasc
            // 
            this.dtpDtNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtNasc.Location = new System.Drawing.Point(116, 65);
            this.dtpDtNasc.Name = "dtpDtNasc";
            this.dtpDtNasc.Size = new System.Drawing.Size(97, 20);
            this.dtpDtNasc.TabIndex = 43;
            this.dtpDtNasc.Value = new System.DateTime(2020, 11, 7, 13, 56, 23, 0);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(418, 235);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(83, 20);
            this.txtStatus.TabIndex = 60;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(93, 196);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(411, 20);
            this.txtEmail.TabIndex = 59;
            // 
            // mtbCel
            // 
            this.mtbCel.Location = new System.Drawing.Point(255, 235);
            this.mtbCel.Mask = "(00) 00000-0000";
            this.mtbCel.Name = "mtbCel";
            this.mtbCel.Size = new System.Drawing.Size(100, 20);
            this.mtbCel.TabIndex = 58;
            // 
            // mtbTel
            // 
            this.mtbTel.Location = new System.Drawing.Point(101, 235);
            this.mtbTel.Mask = "(00) 0000-0000";
            this.mtbTel.Name = "mtbTel";
            this.mtbTel.Size = new System.Drawing.Size(100, 20);
            this.mtbTel.TabIndex = 57;
            // 
            // mtbCEP
            // 
            this.mtbCEP.Location = new System.Drawing.Point(409, 156);
            this.mtbCEP.Mask = "00000-000";
            this.mtbCEP.Name = "mtbCEP";
            this.mtbCEP.Size = new System.Drawing.Size(95, 20);
            this.mtbCEP.TabIndex = 56;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(297, 156);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(54, 20);
            this.txtEstado.TabIndex = 55;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(107, 156);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(135, 20);
            this.txtEndereco.TabIndex = 54;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(421, 115);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(83, 20);
            this.txtCidade.TabIndex = 53;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(207, 238);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 52;
            this.label15.Text = "Celular:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(49, 238);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 51;
            this.label14.Text = "Telefone:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(49, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 50;
            this.label13.Text = "E-mail:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(372, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "Status:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(248, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "Estado:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(372, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Cidade:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Endereço:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(372, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "CEP:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "CPF:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "RG:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Estado Civil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Sexo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Data Nasc.";
            // 
            // mtbRG
            // 
            this.mtbRG.Location = new System.Drawing.Point(85, 115);
            this.mtbRG.Mask = "00.000.000-0";
            this.mtbRG.Name = "mtbRG";
            this.mtbRG.Size = new System.Drawing.Size(100, 20);
            this.mtbRG.TabIndex = 38;
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(251, 115);
            this.mtbCPF.Mask = "000.000.000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(100, 20);
            this.mtbCPF.TabIndex = 37;
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Location = new System.Drawing.Point(265, 82);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbFeminino.TabIndex = 36;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Checked = true;
            this.rbMasculino.Location = new System.Drawing.Point(265, 59);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 35;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(251, 23);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(253, 20);
            this.txtNome.TabIndex = 33;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(102, 23);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(36, 20);
            this.txtCodigo.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Código:";
            // 
            // bttCad
            // 
            this.bttCad.Location = new System.Drawing.Point(126, 273);
            this.bttCad.Name = "bttCad";
            this.bttCad.Size = new System.Drawing.Size(75, 23);
            this.bttCad.TabIndex = 62;
            this.bttCad.Text = "Cadastrar";
            this.bttCad.UseVisualStyleBackColor = true;
            this.bttCad.Click += new System.EventHandler(this.bttCad_Click);
            // 
            // bttExcluir
            // 
            this.bttExcluir.Location = new System.Drawing.Point(231, 273);
            this.bttExcluir.Name = "bttExcluir";
            this.bttExcluir.Size = new System.Drawing.Size(75, 23);
            this.bttExcluir.TabIndex = 63;
            this.bttExcluir.Text = "Excluir";
            this.bttExcluir.UseVisualStyleBackColor = true;
            // 
            // bttAtualizar
            // 
            this.bttAtualizar.Location = new System.Drawing.Point(340, 273);
            this.bttAtualizar.Name = "bttAtualizar";
            this.bttAtualizar.Size = new System.Drawing.Size(75, 23);
            this.bttAtualizar.TabIndex = 64;
            this.bttAtualizar.Text = "Atualizar";
            this.bttAtualizar.UseVisualStyleBackColor = true;
            this.bttAtualizar.Click += new System.EventHandler(this.bttAtualizar_Click);
            // 
            // bttPesq
            // 
            this.bttPesq.Location = new System.Drawing.Point(144, 21);
            this.bttPesq.Name = "bttPesq";
            this.bttPesq.Size = new System.Drawing.Size(57, 23);
            this.bttPesq.TabIndex = 65;
            this.bttPesq.Text = "Pesq";
            this.bttPesq.UseVisualStyleBackColor = true;
            this.bttPesq.Click += new System.EventHandler(this.bttPesq_Click);
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 308);
            this.Controls.Add(this.bttPesq);
            this.Controls.Add(this.bttAtualizar);
            this.Controls.Add(this.bttExcluir);
            this.Controls.Add(this.bttCad);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.dtpDtNasc);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.mtbCel);
            this.Controls.Add(this.mtbTel);
            this.Controls.Add(this.mtbCEP);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtbRG);
            this.Controls.Add(this.mtbCPF);
            this.Controls.Add(this.rbFeminino);
            this.Controls.Add(this.rbMasculino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Name = "frmCadastroCliente";
            this.Text = "Cadastro Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.DateTimePicker dtpDtNasc;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mtbCel;
        private System.Windows.Forms.MaskedTextBox mtbTel;
        private System.Windows.Forms.MaskedTextBox mtbCEP;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbRG;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttCad;
        private System.Windows.Forms.Button bttExcluir;
        private System.Windows.Forms.Button bttAtualizar;
        private System.Windows.Forms.Button bttPesq;
    }
}