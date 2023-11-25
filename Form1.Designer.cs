namespace WfaProjetoFinal
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
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbIdade = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.lbIdade = new System.Windows.Forms.Label();
            this.btInserirCliente = new System.Windows.Forms.Button();
            this.btExibirCliente = new System.Windows.Forms.Button();
            this.btAtualizarCliente = new System.Windows.Forms.Button();
            this.btExcluirCliente = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.lbCidade = new System.Windows.Forms.Label();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dGVCarro = new System.Windows.Forms.DataGridView();
            this.btExcluirCarro = new System.Windows.Forms.Button();
            this.btInserirCarro = new System.Windows.Forms.Button();
            this.btAtualizarCarro = new System.Windows.Forms.Button();
            this.btExibirCarro = new System.Windows.Forms.Button();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.tbAno = new System.Windows.Forms.TextBox();
            this.tbPlaca = new System.Windows.Forms.TextBox();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.lbValor = new System.Windows.Forms.Label();
            this.lbAno = new System.Windows.Forms.Label();
            this.lbPlaca = new System.Windows.Forms.Label();
            this.lbModelo = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btExcluirSeguro = new System.Windows.Forms.Button();
            this.btRelatorio = new System.Windows.Forms.Button();
            this.btAtualizar2 = new System.Windows.Forms.Button();
            this.gbCotacoesRelatorio = new System.Windows.Forms.GroupBox();
            this.dGVSeguro = new System.Windows.Forms.DataGridView();
            this.lbCotacao2 = new System.Windows.Forms.Label();
            this.lbSeguradora2 = new System.Windows.Forms.Label();
            this.lbCotacao1 = new System.Windows.Forms.Label();
            this.lbSeguradora1 = new System.Windows.Forms.Label();
            this.btContratarSeguro2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btContratarSeguro1 = new System.Windows.Forms.Button();
            this.lbCotacao = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbCobertura = new System.Windows.Forms.RadioButton();
            this.rbProtecao = new System.Windows.Forms.RadioButton();
            this.btCotacao = new System.Windows.Forms.Button();
            this.tbPlacaSeguro = new System.Windows.Forms.TextBox();
            this.lbPlacaSeguro = new System.Windows.Forms.Label();
            this.lbCPFSeguro = new System.Windows.Forms.Label();
            this.mtbCPFSeguro = new System.Windows.Forms.MaskedTextBox();
            this.lbSeguroTipo = new System.Windows.Forms.Label();
            this.btAtualizar1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCarro)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.gbCotacoesRelatorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSeguro)).BeginInit();
            this.SuspendLayout();
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(172, 60);
            this.mtbCPF.Mask = "000,000,000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(194, 22);
            this.mtbCPF.TabIndex = 0;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(172, 17);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(194, 22);
            this.tbNome.TabIndex = 1;
            // 
            // tbIdade
            // 
            this.tbIdade.Location = new System.Drawing.Point(172, 102);
            this.tbIdade.Name = "tbIdade";
            this.tbIdade.Size = new System.Drawing.Size(193, 22);
            this.tbIdade.TabIndex = 2;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(41, 17);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(44, 16);
            this.lbNome.TabIndex = 3;
            this.lbNome.Text = "Nome";
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Location = new System.Drawing.Point(41, 60);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(33, 16);
            this.lbCPF.TabIndex = 4;
            this.lbCPF.Text = "CPF";
            // 
            // lbIdade
            // 
            this.lbIdade.AutoSize = true;
            this.lbIdade.Location = new System.Drawing.Point(41, 108);
            this.lbIdade.Name = "lbIdade";
            this.lbIdade.Size = new System.Drawing.Size(42, 16);
            this.lbIdade.TabIndex = 5;
            this.lbIdade.Text = "Idade";
            // 
            // btInserirCliente
            // 
            this.btInserirCliente.Location = new System.Drawing.Point(398, 179);
            this.btInserirCliente.Name = "btInserirCliente";
            this.btInserirCliente.Size = new System.Drawing.Size(65, 24);
            this.btInserirCliente.TabIndex = 6;
            this.btInserirCliente.Text = "Inserir";
            this.btInserirCliente.UseVisualStyleBackColor = true;
            this.btInserirCliente.Click += new System.EventHandler(this.btInserirCliente_Click);
            // 
            // btExibirCliente
            // 
            this.btExibirCliente.Location = new System.Drawing.Point(494, 179);
            this.btExibirCliente.Name = "btExibirCliente";
            this.btExibirCliente.Size = new System.Drawing.Size(65, 24);
            this.btExibirCliente.TabIndex = 7;
            this.btExibirCliente.Text = "Exibir";
            this.btExibirCliente.UseVisualStyleBackColor = true;
            this.btExibirCliente.Click += new System.EventHandler(this.btExibirCliente_Click);
            // 
            // btAtualizarCliente
            // 
            this.btAtualizarCliente.Location = new System.Drawing.Point(592, 179);
            this.btAtualizarCliente.Name = "btAtualizarCliente";
            this.btAtualizarCliente.Size = new System.Drawing.Size(75, 24);
            this.btAtualizarCliente.TabIndex = 8;
            this.btAtualizarCliente.Text = "Atualizar";
            this.btAtualizarCliente.UseVisualStyleBackColor = true;
            this.btAtualizarCliente.Click += new System.EventHandler(this.btAtualizarCliente_Click);
            // 
            // btExcluirCliente
            // 
            this.btExcluirCliente.Location = new System.Drawing.Point(691, 179);
            this.btExcluirCliente.Name = "btExcluirCliente";
            this.btExcluirCliente.Size = new System.Drawing.Size(65, 24);
            this.btExcluirCliente.TabIndex = 9;
            this.btExcluirCliente.Text = "Excluir";
            this.btExcluirCliente.UseVisualStyleBackColor = true;
            this.btExcluirCliente.Click += new System.EventHandler(this.btExcluirCliente_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(806, 586);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dGV);
            this.tabPage1.Controls.Add(this.lbCidade);
            this.tabPage1.Controls.Add(this.tbCidade);
            this.tabPage1.Controls.Add(this.btExcluirCliente);
            this.tabPage1.Controls.Add(this.lbIdade);
            this.tabPage1.Controls.Add(this.btInserirCliente);
            this.tabPage1.Controls.Add(this.lbCPF);
            this.tabPage1.Controls.Add(this.btAtualizarCliente);
            this.tabPage1.Controls.Add(this.lbNome);
            this.tabPage1.Controls.Add(this.btExibirCliente);
            this.tabPage1.Controls.Add(this.tbIdade);
            this.tabPage1.Controls.Add(this.tbNome);
            this.tabPage1.Controls.Add(this.mtbCPF);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(798, 557);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cliente";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dGV
            // 
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.Location = new System.Drawing.Point(22, 257);
            this.dGV.Name = "dGV";
            this.dGV.RowHeadersWidth = 51;
            this.dGV.RowTemplate.Height = 24;
            this.dGV.Size = new System.Drawing.Size(742, 275);
            this.dGV.TabIndex = 12;
            this.dGV.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGV_CellMouseDoubleClick);
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Location = new System.Drawing.Point(41, 157);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(51, 16);
            this.lbCidade.TabIndex = 11;
            this.lbCidade.Text = "Cidade";
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(172, 151);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(193, 22);
            this.tbCidade.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dGVCarro);
            this.tabPage2.Controls.Add(this.btExcluirCarro);
            this.tabPage2.Controls.Add(this.btInserirCarro);
            this.tabPage2.Controls.Add(this.btAtualizarCarro);
            this.tabPage2.Controls.Add(this.btExibirCarro);
            this.tabPage2.Controls.Add(this.tbValor);
            this.tabPage2.Controls.Add(this.tbAno);
            this.tabPage2.Controls.Add(this.tbPlaca);
            this.tabPage2.Controls.Add(this.tbModelo);
            this.tabPage2.Controls.Add(this.lbValor);
            this.tabPage2.Controls.Add(this.lbAno);
            this.tabPage2.Controls.Add(this.lbPlaca);
            this.tabPage2.Controls.Add(this.lbModelo);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(798, 557);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Carro";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dGVCarro
            // 
            this.dGVCarro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCarro.Location = new System.Drawing.Point(64, 256);
            this.dGVCarro.Name = "dGVCarro";
            this.dGVCarro.RowHeadersWidth = 51;
            this.dGVCarro.RowTemplate.Height = 24;
            this.dGVCarro.Size = new System.Drawing.Size(686, 261);
            this.dGVCarro.TabIndex = 14;
            this.dGVCarro.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGVCarro_CellMouseDoubleClick);
            // 
            // btExcluirCarro
            // 
            this.btExcluirCarro.Location = new System.Drawing.Point(685, 170);
            this.btExcluirCarro.Name = "btExcluirCarro";
            this.btExcluirCarro.Size = new System.Drawing.Size(65, 24);
            this.btExcluirCarro.TabIndex = 13;
            this.btExcluirCarro.Text = "Excluir";
            this.btExcluirCarro.UseVisualStyleBackColor = true;
            this.btExcluirCarro.Click += new System.EventHandler(this.btExcluirCarro_Click);
            // 
            // btInserirCarro
            // 
            this.btInserirCarro.Location = new System.Drawing.Point(392, 170);
            this.btInserirCarro.Name = "btInserirCarro";
            this.btInserirCarro.Size = new System.Drawing.Size(65, 24);
            this.btInserirCarro.TabIndex = 10;
            this.btInserirCarro.Text = "Inserir";
            this.btInserirCarro.UseVisualStyleBackColor = true;
            this.btInserirCarro.Click += new System.EventHandler(this.btInserirCarro_Click);
            // 
            // btAtualizarCarro
            // 
            this.btAtualizarCarro.Location = new System.Drawing.Point(586, 170);
            this.btAtualizarCarro.Name = "btAtualizarCarro";
            this.btAtualizarCarro.Size = new System.Drawing.Size(75, 24);
            this.btAtualizarCarro.TabIndex = 12;
            this.btAtualizarCarro.Text = "Atualizar";
            this.btAtualizarCarro.UseVisualStyleBackColor = true;
            this.btAtualizarCarro.Click += new System.EventHandler(this.btAtualizarCarro_Click);
            // 
            // btExibirCarro
            // 
            this.btExibirCarro.Location = new System.Drawing.Point(488, 170);
            this.btExibirCarro.Name = "btExibirCarro";
            this.btExibirCarro.Size = new System.Drawing.Size(65, 24);
            this.btExibirCarro.TabIndex = 11;
            this.btExibirCarro.Text = "Exibir";
            this.btExibirCarro.UseVisualStyleBackColor = true;
            this.btExibirCarro.Click += new System.EventHandler(this.btExibirCarro_Click);
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(148, 170);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(194, 22);
            this.tbValor.TabIndex = 7;
            // 
            // tbAno
            // 
            this.tbAno.Location = new System.Drawing.Point(148, 111);
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(194, 22);
            this.tbAno.TabIndex = 6;
            // 
            // tbPlaca
            // 
            this.tbPlaca.Location = new System.Drawing.Point(148, 61);
            this.tbPlaca.Name = "tbPlaca";
            this.tbPlaca.Size = new System.Drawing.Size(194, 22);
            this.tbPlaca.TabIndex = 5;
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(148, 18);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(194, 22);
            this.tbModelo.TabIndex = 4;
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(61, 170);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(39, 16);
            this.lbValor.TabIndex = 3;
            this.lbValor.Text = "Valor";
            // 
            // lbAno
            // 
            this.lbAno.AutoSize = true;
            this.lbAno.Location = new System.Drawing.Point(61, 114);
            this.lbAno.Name = "lbAno";
            this.lbAno.Size = new System.Drawing.Size(31, 16);
            this.lbAno.TabIndex = 2;
            this.lbAno.Text = "Ano";
            // 
            // lbPlaca
            // 
            this.lbPlaca.AutoSize = true;
            this.lbPlaca.Location = new System.Drawing.Point(61, 61);
            this.lbPlaca.Name = "lbPlaca";
            this.lbPlaca.Size = new System.Drawing.Size(42, 16);
            this.lbPlaca.TabIndex = 1;
            this.lbPlaca.Text = "Placa";
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Location = new System.Drawing.Point(61, 17);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(53, 16);
            this.lbModelo.TabIndex = 0;
            this.lbModelo.Text = "Modelo";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.btExcluirSeguro);
            this.tabPage3.Controls.Add(this.btRelatorio);
            this.tabPage3.Controls.Add(this.gbCotacoesRelatorio);
            this.tabPage3.Controls.Add(this.rbCobertura);
            this.tabPage3.Controls.Add(this.rbProtecao);
            this.tabPage3.Controls.Add(this.btCotacao);
            this.tabPage3.Controls.Add(this.tbPlacaSeguro);
            this.tabPage3.Controls.Add(this.lbPlacaSeguro);
            this.tabPage3.Controls.Add(this.lbCPFSeguro);
            this.tabPage3.Controls.Add(this.mtbCPFSeguro);
            this.tabPage3.Controls.Add(this.lbSeguroTipo);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(798, 557);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Seguro";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "label3";
            // 
            // btExcluirSeguro
            // 
            this.btExcluirSeguro.Location = new System.Drawing.Point(339, 131);
            this.btExcluirSeguro.Name = "btExcluirSeguro";
            this.btExcluirSeguro.Size = new System.Drawing.Size(145, 41);
            this.btExcluirSeguro.TabIndex = 24;
            this.btExcluirSeguro.Text = "Excluir Contrato";
            this.btExcluirSeguro.UseVisualStyleBackColor = true;
            this.btExcluirSeguro.Click += new System.EventHandler(this.btExcluirSeguro_Click);
            // 
            // btRelatorio
            // 
            this.btRelatorio.Location = new System.Drawing.Point(339, 495);
            this.btRelatorio.Name = "btRelatorio";
            this.btRelatorio.Size = new System.Drawing.Size(145, 41);
            this.btRelatorio.TabIndex = 23;
            this.btRelatorio.Text = "Exibir Relatório";
            this.btRelatorio.UseVisualStyleBackColor = true;
            this.btRelatorio.Click += new System.EventHandler(this.btRelatorio_Click);
            // 
            // btAtualizar2
            // 
            this.btAtualizar2.Location = new System.Drawing.Point(482, 212);
            this.btAtualizar2.Name = "btAtualizar2";
            this.btAtualizar2.Size = new System.Drawing.Size(147, 41);
            this.btAtualizar2.TabIndex = 25;
            this.btAtualizar2.Text = "Atualizar Contrato";
            this.btAtualizar2.UseVisualStyleBackColor = true;
            this.btAtualizar2.Click += new System.EventHandler(this.btAtualizar2_Click);
            // 
            // gbCotacoesRelatorio
            // 
            this.gbCotacoesRelatorio.Controls.Add(this.dGVSeguro);
            this.gbCotacoesRelatorio.Controls.Add(this.btAtualizar1);
            this.gbCotacoesRelatorio.Controls.Add(this.lbCotacao2);
            this.gbCotacoesRelatorio.Controls.Add(this.lbSeguradora2);
            this.gbCotacoesRelatorio.Controls.Add(this.lbCotacao1);
            this.gbCotacoesRelatorio.Controls.Add(this.btAtualizar2);
            this.gbCotacoesRelatorio.Controls.Add(this.lbSeguradora1);
            this.gbCotacoesRelatorio.Controls.Add(this.btContratarSeguro2);
            this.gbCotacoesRelatorio.Controls.Add(this.label1);
            this.gbCotacoesRelatorio.Controls.Add(this.label2);
            this.gbCotacoesRelatorio.Controls.Add(this.btContratarSeguro1);
            this.gbCotacoesRelatorio.Controls.Add(this.lbCotacao);
            this.gbCotacoesRelatorio.Controls.Add(this.label5);
            this.gbCotacoesRelatorio.Location = new System.Drawing.Point(42, 190);
            this.gbCotacoesRelatorio.Name = "gbCotacoesRelatorio";
            this.gbCotacoesRelatorio.Size = new System.Drawing.Size(696, 279);
            this.gbCotacoesRelatorio.TabIndex = 22;
            this.gbCotacoesRelatorio.TabStop = false;
            this.gbCotacoesRelatorio.Text = "Cotações";
            // 
            // dGVSeguro
            // 
            this.dGVSeguro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVSeguro.Location = new System.Drawing.Point(17, 33);
            this.dGVSeguro.Name = "dGVSeguro";
            this.dGVSeguro.RowHeadersWidth = 51;
            this.dGVSeguro.RowTemplate.Height = 24;
            this.dGVSeguro.Size = new System.Drawing.Size(653, 220);
            this.dGVSeguro.TabIndex = 26;
            this.dGVSeguro.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGVSeguro_CellMouseDoubleClick);
            // 
            // lbCotacao2
            // 
            this.lbCotacao2.AutoSize = true;
            this.lbCotacao2.Location = new System.Drawing.Point(260, 205);
            this.lbCotacao2.Name = "lbCotacao2";
            this.lbCotacao2.Size = new System.Drawing.Size(44, 16);
            this.lbCotacao2.TabIndex = 25;
            this.lbCotacao2.Text = "label8";
            // 
            // lbSeguradora2
            // 
            this.lbSeguradora2.AutoSize = true;
            this.lbSeguradora2.Location = new System.Drawing.Point(260, 178);
            this.lbSeguradora2.Name = "lbSeguradora2";
            this.lbSeguradora2.Size = new System.Drawing.Size(44, 16);
            this.lbSeguradora2.TabIndex = 24;
            this.lbSeguradora2.Text = "label7";
            // 
            // lbCotacao1
            // 
            this.lbCotacao1.AutoSize = true;
            this.lbCotacao1.Location = new System.Drawing.Point(260, 85);
            this.lbCotacao1.Name = "lbCotacao1";
            this.lbCotacao1.Size = new System.Drawing.Size(44, 16);
            this.lbCotacao1.TabIndex = 23;
            this.lbCotacao1.Text = "label6";
            // 
            // lbSeguradora1
            // 
            this.lbSeguradora1.AutoSize = true;
            this.lbSeguradora1.Location = new System.Drawing.Point(260, 52);
            this.lbSeguradora1.Name = "lbSeguradora1";
            this.lbSeguradora1.Size = new System.Drawing.Size(44, 16);
            this.lbSeguradora1.TabIndex = 22;
            this.lbSeguradora1.Text = "label4";
            // 
            // btContratarSeguro2
            // 
            this.btContratarSeguro2.Location = new System.Drawing.Point(471, 166);
            this.btContratarSeguro2.Name = "btContratarSeguro2";
            this.btContratarSeguro2.Size = new System.Drawing.Size(181, 41);
            this.btContratarSeguro2.TabIndex = 21;
            this.btContratarSeguro2.Text = "Contratar seguro";
            this.btContratarSeguro2.UseVisualStyleBackColor = true;
            this.btContratarSeguro2.Click += new System.EventHandler(this.btContratarSeguro2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cotação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Seguradora";
            // 
            // btContratarSeguro1
            // 
            this.btContratarSeguro1.Location = new System.Drawing.Point(463, 39);
            this.btContratarSeguro1.Name = "btContratarSeguro1";
            this.btContratarSeguro1.Size = new System.Drawing.Size(189, 40);
            this.btContratarSeguro1.TabIndex = 16;
            this.btContratarSeguro1.Text = "Contratar seguro";
            this.btContratarSeguro1.UseVisualStyleBackColor = true;
            this.btContratarSeguro1.Click += new System.EventHandler(this.btContratarSeguro1_Click);
            // 
            // lbCotacao
            // 
            this.lbCotacao.AutoSize = true;
            this.lbCotacao.Location = new System.Drawing.Point(83, 85);
            this.lbCotacao.Name = "lbCotacao";
            this.lbCotacao.Size = new System.Drawing.Size(58, 16);
            this.lbCotacao.TabIndex = 6;
            this.lbCotacao.Text = "Cotação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Seguradora";
            // 
            // rbCobertura
            // 
            this.rbCobertura.AutoSize = true;
            this.rbCobertura.Location = new System.Drawing.Point(418, 89);
            this.rbCobertura.Name = "rbCobertura";
            this.rbCobertura.Size = new System.Drawing.Size(148, 20);
            this.rbCobertura.TabIndex = 15;
            this.rbCobertura.TabStop = true;
            this.rbCobertura.Text = "Cobertura Completa";
            this.rbCobertura.UseVisualStyleBackColor = true;
            // 
            // rbProtecao
            // 
            this.rbProtecao.AutoSize = true;
            this.rbProtecao.Location = new System.Drawing.Point(211, 89);
            this.rbProtecao.Name = "rbProtecao";
            this.rbProtecao.Size = new System.Drawing.Size(135, 20);
            this.rbProtecao.TabIndex = 14;
            this.rbProtecao.TabStop = true;
            this.rbProtecao.Text = "Proteção Veicular";
            this.rbProtecao.UseVisualStyleBackColor = true;
            // 
            // btCotacao
            // 
            this.btCotacao.Location = new System.Drawing.Point(99, 131);
            this.btCotacao.Name = "btCotacao";
            this.btCotacao.Size = new System.Drawing.Size(145, 41);
            this.btCotacao.TabIndex = 13;
            this.btCotacao.Text = "Realizar Cotação";
            this.btCotacao.UseVisualStyleBackColor = true;
            this.btCotacao.Click += new System.EventHandler(this.btCotacao_Click);
            // 
            // tbPlacaSeguro
            // 
            this.tbPlacaSeguro.Location = new System.Drawing.Point(538, 24);
            this.tbPlacaSeguro.Name = "tbPlacaSeguro";
            this.tbPlacaSeguro.Size = new System.Drawing.Size(194, 22);
            this.tbPlacaSeguro.TabIndex = 12;
            // 
            // lbPlacaSeguro
            // 
            this.lbPlacaSeguro.AutoSize = true;
            this.lbPlacaSeguro.Location = new System.Drawing.Point(415, 24);
            this.lbPlacaSeguro.Name = "lbPlacaSeguro";
            this.lbPlacaSeguro.Size = new System.Drawing.Size(42, 16);
            this.lbPlacaSeguro.TabIndex = 11;
            this.lbPlacaSeguro.Text = "Placa";
            // 
            // lbCPFSeguro
            // 
            this.lbCPFSeguro.AutoSize = true;
            this.lbCPFSeguro.Location = new System.Drawing.Point(47, 24);
            this.lbCPFSeguro.Name = "lbCPFSeguro";
            this.lbCPFSeguro.Size = new System.Drawing.Size(33, 16);
            this.lbCPFSeguro.TabIndex = 10;
            this.lbCPFSeguro.Text = "CPF";
            // 
            // mtbCPFSeguro
            // 
            this.mtbCPFSeguro.Location = new System.Drawing.Point(178, 24);
            this.mtbCPFSeguro.Mask = "000,000,000-00";
            this.mtbCPFSeguro.Name = "mtbCPFSeguro";
            this.mtbCPFSeguro.Size = new System.Drawing.Size(194, 22);
            this.mtbCPFSeguro.TabIndex = 9;
            // 
            // lbSeguroTipo
            // 
            this.lbSeguroTipo.AutoSize = true;
            this.lbSeguroTipo.Location = new System.Drawing.Point(47, 93);
            this.lbSeguroTipo.Name = "lbSeguroTipo";
            this.lbSeguroTipo.Size = new System.Drawing.Size(101, 16);
            this.lbSeguroTipo.TabIndex = 5;
            this.lbSeguroTipo.Text = "Tipo do Seguro";
            // 
            // btAtualizar1
            // 
            this.btAtualizar1.Location = new System.Drawing.Point(482, 85);
            this.btAtualizar1.Name = "btAtualizar1";
            this.btAtualizar1.Size = new System.Drawing.Size(147, 41);
            this.btAtualizar1.TabIndex = 27;
            this.btAtualizar1.Text = "Atualizar Contrato";
            this.btAtualizar1.UseVisualStyleBackColor = true;
            this.btAtualizar1.Click += new System.EventHandler(this.btAtualizar1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 586);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCarro)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.gbCotacoesRelatorio.ResumeLayout(false);
            this.gbCotacoesRelatorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSeguro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbIdade;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.Label lbIdade;
        private System.Windows.Forms.Button btInserirCliente;
        private System.Windows.Forms.Button btExibirCliente;
        private System.Windows.Forms.Button btAtualizarCliente;
        private System.Windows.Forms.Button btExcluirCliente;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.Label lbPlaca;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.TextBox tbAno;
        private System.Windows.Forms.TextBox tbPlaca;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.Label lbCotacao;
        private System.Windows.Forms.Label lbSeguroTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.Button btExcluirCarro;
        private System.Windows.Forms.Button btInserirCarro;
        private System.Windows.Forms.Button btAtualizarCarro;
        private System.Windows.Forms.Button btExibirCarro;
        private System.Windows.Forms.DataGridView dGVCarro;
        private System.Windows.Forms.TextBox tbPlacaSeguro;
        private System.Windows.Forms.Label lbPlacaSeguro;
        private System.Windows.Forms.Label lbCPFSeguro;
        private System.Windows.Forms.MaskedTextBox mtbCPFSeguro;
        private System.Windows.Forms.Button btCotacao;
        private System.Windows.Forms.Button btContratarSeguro2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btContratarSeguro1;
        private System.Windows.Forms.RadioButton rbCobertura;
        private System.Windows.Forms.RadioButton rbProtecao;
        private System.Windows.Forms.GroupBox gbCotacoesRelatorio;
        private System.Windows.Forms.Button btRelatorio;
        private System.Windows.Forms.Button btExcluirSeguro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCotacao1;
        private System.Windows.Forms.Label lbSeguradora1;
        private System.Windows.Forms.Label lbCotacao2;
        private System.Windows.Forms.Label lbSeguradora2;
        private System.Windows.Forms.DataGridView dGVSeguro;
        private System.Windows.Forms.Button btAtualizar2;
        private System.Windows.Forms.Button btAtualizar1;
    }
}

