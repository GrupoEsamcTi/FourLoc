namespace TESTE
{
    partial class frmFilme
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.bttPesq = new System.Windows.Forms.Button();
            this.txtCdBarras = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.mtbPreco = new System.Windows.Forms.MaskedTextBox();
            this.dtpDtAdquirida = new System.Windows.Forms.DateTimePicker();
            this.mtbVlCusto = new System.Windows.Forms.MaskedTextBox();
            this.cbSituacao = new System.Windows.Forms.ComboBox();
            this.mtpTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtpCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dtpDtRetirada = new System.Windows.Forms.DateTimePicker();
            this.dtpDtDevolucao = new System.Windows.Forms.DateTimePicker();
            this.txtAtores = new System.Windows.Forms.TextBox();
            this.txtDiretor = new System.Windows.Forms.TextBox();
            this.bttInserir = new System.Windows.Forms.Button();
            this.bttAtualizar = new System.Windows.Forms.Button();
            this.bttExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.mtbAno = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFoto = new System.Windows.Forms.TextBox();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.CdFilme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdLocacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdDevolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtLocacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtDevolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vl_Locacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vl_Recebido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrMulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recebido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DsTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DsGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DsAno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DsTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtAdquirida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrValorCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DsSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DsAtores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DsDiretor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DsFotoCapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(84, 31);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(45, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // bttPesq
            // 
            this.bttPesq.Location = new System.Drawing.Point(135, 31);
            this.bttPesq.Name = "bttPesq";
            this.bttPesq.Size = new System.Drawing.Size(50, 23);
            this.bttPesq.TabIndex = 1;
            this.bttPesq.Text = "Pesq";
            this.bttPesq.UseVisualStyleBackColor = true;
            this.bttPesq.Click += new System.EventHandler(this.bttPesq_Click);
            // 
            // txtCdBarras
            // 
            this.txtCdBarras.Location = new System.Drawing.Point(274, 31);
            this.txtCdBarras.Name = "txtCdBarras";
            this.txtCdBarras.Size = new System.Drawing.Size(74, 20);
            this.txtCdBarras.TabIndex = 2;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(404, 34);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(202, 20);
            this.txtTitulo.TabIndex = 3;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(80, 79);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(87, 20);
            this.txtGenero.TabIndex = 4;
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "DVD",
            "DVD - Blurey",
            "DVD -HD"});
            this.cbTipo.Location = new System.Drawing.Point(391, 78);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(83, 21);
            this.cbTipo.TabIndex = 62;
            // 
            // mtbPreco
            // 
            this.mtbPreco.Location = new System.Drawing.Point(520, 78);
            this.mtbPreco.Mask = "00,00";
            this.mtbPreco.Name = "mtbPreco";
            this.mtbPreco.Size = new System.Drawing.Size(86, 20);
            this.mtbPreco.TabIndex = 63;
            // 
            // dtpDtAdquirida
            // 
            this.dtpDtAdquirida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtAdquirida.Location = new System.Drawing.Point(121, 124);
            this.dtpDtAdquirida.Name = "dtpDtAdquirida";
            this.dtpDtAdquirida.Size = new System.Drawing.Size(97, 20);
            this.dtpDtAdquirida.TabIndex = 64;
            this.dtpDtAdquirida.Value = new System.DateTime(2020, 11, 7, 13, 56, 23, 0);
            // 
            // mtbVlCusto
            // 
            this.mtbVlCusto.Location = new System.Drawing.Point(321, 127);
            this.mtbVlCusto.Mask = "00,00";
            this.mtbVlCusto.Name = "mtbVlCusto";
            this.mtbVlCusto.Size = new System.Drawing.Size(100, 20);
            this.mtbVlCusto.TabIndex = 65;
            // 
            // cbSituacao
            // 
            this.cbSituacao.FormattingEnabled = true;
            this.cbSituacao.Items.AddRange(new object[] {
            "Disponivel",
            "Locado"});
            this.cbSituacao.Location = new System.Drawing.Point(523, 126);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Size = new System.Drawing.Size(83, 21);
            this.cbSituacao.TabIndex = 66;
            // 
            // mtpTelefone
            // 
            this.mtpTelefone.Location = new System.Drawing.Point(91, 216);
            this.mtpTelefone.Mask = "(00) 0000-0000";
            this.mtpTelefone.Name = "mtpTelefone";
            this.mtpTelefone.Size = new System.Drawing.Size(80, 20);
            this.mtpTelefone.TabIndex = 67;
            // 
            // mtpCelular
            // 
            this.mtpCelular.Location = new System.Drawing.Point(218, 216);
            this.mtpCelular.Mask = "(00) 00000-0000";
            this.mtpCelular.Name = "mtpCelular";
            this.mtpCelular.Size = new System.Drawing.Size(88, 20);
            this.mtpCelular.TabIndex = 68;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(114, 171);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(166, 20);
            this.txtNome.TabIndex = 70;
            // 
            // dtpDtRetirada
            // 
            this.dtpDtRetirada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtRetirada.Location = new System.Drawing.Point(338, 171);
            this.dtpDtRetirada.Name = "dtpDtRetirada";
            this.dtpDtRetirada.Size = new System.Drawing.Size(97, 20);
            this.dtpDtRetirada.TabIndex = 71;
            this.dtpDtRetirada.Value = new System.DateTime(2020, 11, 7, 13, 56, 23, 0);
            // 
            // dtpDtDevolucao
            // 
            this.dtpDtDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtDevolucao.Location = new System.Drawing.Point(509, 171);
            this.dtpDtDevolucao.Name = "dtpDtDevolucao";
            this.dtpDtDevolucao.Size = new System.Drawing.Size(97, 20);
            this.dtpDtDevolucao.TabIndex = 72;
            this.dtpDtDevolucao.Value = new System.DateTime(2020, 11, 7, 13, 56, 23, 0);
            // 
            // txtAtores
            // 
            this.txtAtores.Location = new System.Drawing.Point(349, 216);
            this.txtAtores.Name = "txtAtores";
            this.txtAtores.Size = new System.Drawing.Size(111, 20);
            this.txtAtores.TabIndex = 73;
            // 
            // txtDiretor
            // 
            this.txtDiretor.Location = new System.Drawing.Point(509, 216);
            this.txtDiretor.Name = "txtDiretor";
            this.txtDiretor.Size = new System.Drawing.Size(97, 20);
            this.txtDiretor.TabIndex = 74;
            // 
            // bttInserir
            // 
            this.bttInserir.Location = new System.Drawing.Point(114, 265);
            this.bttInserir.Name = "bttInserir";
            this.bttInserir.Size = new System.Drawing.Size(75, 23);
            this.bttInserir.TabIndex = 75;
            this.bttInserir.Text = "Cadastra";
            this.bttInserir.UseVisualStyleBackColor = true;
            this.bttInserir.Click += new System.EventHandler(this.bttInserir_Click);
            // 
            // bttAtualizar
            // 
            this.bttAtualizar.Location = new System.Drawing.Point(279, 265);
            this.bttAtualizar.Name = "bttAtualizar";
            this.bttAtualizar.Size = new System.Drawing.Size(75, 23);
            this.bttAtualizar.TabIndex = 76;
            this.bttAtualizar.Text = "Atualizar";
            this.bttAtualizar.UseVisualStyleBackColor = true;
            // 
            // bttExcluir
            // 
            this.bttExcluir.Location = new System.Drawing.Point(448, 265);
            this.bttExcluir.Name = "bttExcluir";
            this.bttExcluir.Size = new System.Drawing.Size(75, 23);
            this.bttExcluir.TabIndex = 77;
            this.bttExcluir.Text = "Excluir";
            this.bttExcluir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "Código Barras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Titulo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 81;
            this.label4.Text = "Genero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 82;
            this.label5.Text = "Ano";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 83;
            this.label6.Text = "Tipo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(480, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 84;
            this.label7.Text = "Preço";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 85;
            this.label8.Text = "Data Adquirida";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(239, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 86;
            this.label9.Text = "Valor de Custo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(445, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 87;
            this.label10.Text = "Situação";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 89;
            this.label12.Text = "Nome Cliente";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(283, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 90;
            this.label13.Text = "Data Ret.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(445, 174);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 91;
            this.label14.Text = "Data Dev.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(38, 219);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 92;
            this.label15.Text = "Telefone";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(175, 219);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 93;
            this.label16.Text = "Celular";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(310, 219);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 13);
            this.label17.TabIndex = 94;
            this.label17.Text = "Atores";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(466, 219);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 13);
            this.label19.TabIndex = 96;
            this.label19.Text = "Diretor";
            // 
            // mtbAno
            // 
            this.mtbAno.Location = new System.Drawing.Point(313, 78);
            this.mtbAno.Mask = "0000";
            this.mtbAno.Name = "mtbAno";
            this.mtbAno.Size = new System.Drawing.Size(42, 20);
            this.mtbAno.TabIndex = 98;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(176, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 100;
            this.label11.Text = "Foto";
            // 
            // txtFoto
            // 
            this.txtFoto.Location = new System.Drawing.Point(218, 79);
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.Size = new System.Drawing.Size(50, 20);
            this.txtFoto.TabIndex = 99;
            // 
            // dgvItem
            // 
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CdFilme,
            this.CdGenero,
            this.CdBarras,
            this.CdLocacao,
            this.CdDevolucao,
            this.DtLocacao,
            this.DtDevolucao,
            this.Vl_Locacao,
            this.Vl_Recebido,
            this.NrMulta,
            this.Recebido,
            this.DsTitulo,
            this.DsGenero,
            this.DsAno,
            this.DsTipo,
            this.NrPreco,
            this.DtAdquirida,
            this.NrValorCusto,
            this.DsSituacao,
            this.DsAtores,
            this.DsDiretor,
            this.DsFotoCapa});
            this.dgvItem.Location = new System.Drawing.Point(12, 331);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.Size = new System.Drawing.Size(643, 150);
            this.dgvItem.TabIndex = 101;
            // 
            // CdFilme
            // 
            this.CdFilme.DataPropertyName = "CdFilme";
            this.CdFilme.HeaderText = "Código Filme";
            this.CdFilme.Name = "CdFilme";
            // 
            // CdGenero
            // 
            this.CdGenero.DataPropertyName = "CdGenero";
            this.CdGenero.HeaderText = "Código Gênero";
            this.CdGenero.Name = "CdGenero";
            // 
            // CdBarras
            // 
            this.CdBarras.DataPropertyName = "CdBarras";
            this.CdBarras.HeaderText = "Código Barras";
            this.CdBarras.Name = "CdBarras";
            // 
            // CdLocacao
            // 
            this.CdLocacao.DataPropertyName = "CdLocacao";
            this.CdLocacao.HeaderText = "Código Locação";
            this.CdLocacao.Name = "CdLocacao";
            // 
            // CdDevolucao
            // 
            this.CdDevolucao.DataPropertyName = "CdDevolucao";
            this.CdDevolucao.HeaderText = "Código Devolução";
            this.CdDevolucao.Name = "CdDevolucao";
            // 
            // DtLocacao
            // 
            this.DtLocacao.DataPropertyName = "DtLocacao";
            this.DtLocacao.HeaderText = "Data Locação";
            this.DtLocacao.Name = "DtLocacao";
            // 
            // DtDevolucao
            // 
            this.DtDevolucao.DataPropertyName = "DtDevolucao";
            this.DtDevolucao.HeaderText = "Data Devolução";
            this.DtDevolucao.Name = "DtDevolucao";
            // 
            // Vl_Locacao
            // 
            this.Vl_Locacao.DataPropertyName = "Vl_Locacao";
            this.Vl_Locacao.HeaderText = "Valor Locação";
            this.Vl_Locacao.Name = "Vl_Locacao";
            // 
            // Vl_Recebido
            // 
            this.Vl_Recebido.DataPropertyName = "Vl_Recebido";
            this.Vl_Recebido.HeaderText = "Valor Recebido";
            this.Vl_Recebido.Name = "Vl_Recebido";
            // 
            // NrMulta
            // 
            this.NrMulta.DataPropertyName = "NrMulta";
            this.NrMulta.HeaderText = "Multa";
            this.NrMulta.Name = "NrMulta";
            // 
            // Recebido
            // 
            this.Recebido.DataPropertyName = "Recebido";
            this.Recebido.HeaderText = "Recebido";
            this.Recebido.Name = "Recebido";
            // 
            // DsTitulo
            // 
            this.DsTitulo.DataPropertyName = "DsTitulo";
            this.DsTitulo.HeaderText = "Titulo Filme";
            this.DsTitulo.Name = "DsTitulo";
            // 
            // DsGenero
            // 
            this.DsGenero.DataPropertyName = "DsGenero";
            this.DsGenero.HeaderText = "Gênero";
            this.DsGenero.Name = "DsGenero";
            // 
            // DsAno
            // 
            this.DsAno.DataPropertyName = "DsAno";
            this.DsAno.HeaderText = "Ano Lançamento";
            this.DsAno.Name = "DsAno";
            // 
            // DsTipo
            // 
            this.DsTipo.DataPropertyName = "DsTipo";
            this.DsTipo.HeaderText = "Tipo DVD";
            this.DsTipo.Name = "DsTipo";
            // 
            // NrPreco
            // 
            this.NrPreco.DataPropertyName = "NrPreco";
            this.NrPreco.HeaderText = "Preço Filme";
            this.NrPreco.Name = "NrPreco";
            // 
            // DtAdquirida
            // 
            this.DtAdquirida.DataPropertyName = "VtAquirida";
            this.DtAdquirida.HeaderText = "Data Adquirida ";
            this.DtAdquirida.Name = "DtAdquirida";
            // 
            // NrValorCusto
            // 
            this.NrValorCusto.DataPropertyName = "NrValorCusto";
            this.NrValorCusto.HeaderText = "Valor de Custo";
            this.NrValorCusto.Name = "NrValorCusto";
            // 
            // DsSituacao
            // 
            this.DsSituacao.DataPropertyName = "DsSituacao";
            this.DsSituacao.HeaderText = "Situação";
            this.DsSituacao.Name = "DsSituacao";
            // 
            // DsAtores
            // 
            this.DsAtores.DataPropertyName = "DsAtores";
            this.DsAtores.HeaderText = "Atores";
            this.DsAtores.Name = "DsAtores";
            // 
            // DsDiretor
            // 
            this.DsDiretor.DataPropertyName = "DsDiretor";
            this.DsDiretor.HeaderText = "Diretor";
            this.DsDiretor.Name = "DsDiretor";
            // 
            // DsFotoCapa
            // 
            this.DsFotoCapa.DataPropertyName = "DsFotoCapa";
            this.DsFotoCapa.HeaderText = "Capa";
            this.DsFotoCapa.Name = "DsFotoCapa";
            // 
            // frmFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 517);
            this.Controls.Add(this.dgvItem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtFoto);
            this.Controls.Add(this.mtbAno);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttExcluir);
            this.Controls.Add(this.bttAtualizar);
            this.Controls.Add(this.bttInserir);
            this.Controls.Add(this.txtDiretor);
            this.Controls.Add(this.txtAtores);
            this.Controls.Add(this.dtpDtDevolucao);
            this.Controls.Add(this.dtpDtRetirada);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.mtpCelular);
            this.Controls.Add(this.mtpTelefone);
            this.Controls.Add(this.cbSituacao);
            this.Controls.Add(this.mtbVlCusto);
            this.Controls.Add(this.dtpDtAdquirida);
            this.Controls.Add(this.mtbPreco);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtCdBarras);
            this.Controls.Add(this.bttPesq);
            this.Controls.Add(this.txtCodigo);
            this.Name = "frmFilme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Filmes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button bttPesq;
        private System.Windows.Forms.TextBox txtCdBarras;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.MaskedTextBox mtbPreco;
        private System.Windows.Forms.DateTimePicker dtpDtAdquirida;
        private System.Windows.Forms.MaskedTextBox mtbVlCusto;
        private System.Windows.Forms.ComboBox cbSituacao;
        private System.Windows.Forms.MaskedTextBox mtpTelefone;
        private System.Windows.Forms.MaskedTextBox mtpCelular;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker dtpDtRetirada;
        private System.Windows.Forms.DateTimePicker dtpDtDevolucao;
        private System.Windows.Forms.TextBox txtAtores;
        private System.Windows.Forms.TextBox txtDiretor;
        private System.Windows.Forms.Button bttInserir;
        private System.Windows.Forms.Button bttAtualizar;
        private System.Windows.Forms.Button bttExcluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.MaskedTextBox mtbAno;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFoto;
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdFilme;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdLocacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdDevolucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtLocacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtDevolucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vl_Locacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vl_Recebido;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrMulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recebido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DsTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DsGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn DsAno;
        private System.Windows.Forms.DataGridViewTextBoxColumn DsTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtAdquirida;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrValorCusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DsSituacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DsAtores;
        private System.Windows.Forms.DataGridViewTextBoxColumn DsDiretor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DsFotoCapa;
    }
}