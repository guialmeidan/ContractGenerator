namespace Principal.Forms
{
    partial class ConsultaOpportunity
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
            this.nomeCompleto = new System.Windows.Forms.Label();
            this.inputTNID = new System.Windows.Forms.TextBox();
            this.groupBoxBusca = new System.Windows.Forms.GroupBox();
            this.botaoBuscar = new System.Windows.Forms.Button();
            this.groupBoxGeral = new System.Windows.Forms.GroupBox();
            this.tabControlDescricao = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.richTextBoxDescricaoCargo = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBoxAtividadesPrincipais = new System.Windows.Forms.RichTextBox();
            this.groupBoxBeneficio = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxComputador = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxAlimentacaoFimDeSemana = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxAlimentacao = new System.Windows.Forms.TextBox();
            this.textBoxSalario = new System.Windows.Forms.TextBox();
            this.textBoxAcomodacaoCoberta = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxAcomodacaoProvida = new System.Windows.Forms.TextBox();
            this.groupBoxInformacaoGeral = new System.Windows.Forms.GroupBox();
            this.textBoxLocalizacaoEspecifica = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTrabalhaSabado = new System.Windows.Forms.TextBox();
            this.textBoxCargaHorariaSemanal = new System.Windows.Forms.TextBox();
            this.textBoxCargaHorariaDiaria = new System.Windows.Forms.TextBox();
            this.textBoxCidadeDestino = new System.Windows.Forms.TextBox();
            this.textBoxDuracao = new System.Windows.Forms.TextBox();
            this.textBoxDataFim = new System.Windows.Forms.TextBox();
            this.textBoxDataInicio = new System.Windows.Forms.TextBox();
            this.textBoxPais = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBoxBusca.SuspendLayout();
            this.groupBoxGeral.SuspendLayout();
            this.tabControlDescricao.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxBeneficio.SuspendLayout();
            this.groupBoxInformacaoGeral.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeCompleto
            // 
            this.nomeCompleto.AutoSize = true;
            this.nomeCompleto.BackColor = System.Drawing.Color.Transparent;
            this.nomeCompleto.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeCompleto.Location = new System.Drawing.Point(6, 16);
            this.nomeCompleto.Name = "nomeCompleto";
            this.nomeCompleto.Size = new System.Drawing.Size(22, 17);
            this.nomeCompleto.TabIndex = 33;
            this.nomeCompleto.Text = "ID";
            // 
            // inputTNID
            // 
            this.inputTNID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.inputTNID.Location = new System.Drawing.Point(34, 12);
            this.inputTNID.Name = "inputTNID";
            this.inputTNID.Size = new System.Drawing.Size(115, 24);
            this.inputTNID.TabIndex = 32;
            // 
            // groupBoxBusca
            // 
            this.groupBoxBusca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBusca.Controls.Add(this.botaoBuscar);
            this.groupBoxBusca.Controls.Add(this.inputTNID);
            this.groupBoxBusca.Controls.Add(this.nomeCompleto);
            this.groupBoxBusca.Location = new System.Drawing.Point(12, 12);
            this.groupBoxBusca.Name = "groupBoxBusca";
            this.groupBoxBusca.Size = new System.Drawing.Size(760, 44);
            this.groupBoxBusca.TabIndex = 34;
            this.groupBoxBusca.TabStop = false;
            // 
            // botaoBuscar
            // 
            this.botaoBuscar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoBuscar.Location = new System.Drawing.Point(155, 10);
            this.botaoBuscar.Name = "botaoBuscar";
            this.botaoBuscar.Size = new System.Drawing.Size(89, 28);
            this.botaoBuscar.TabIndex = 35;
            this.botaoBuscar.Text = "Buscar";
            this.botaoBuscar.UseVisualStyleBackColor = true;
            this.botaoBuscar.Click += new System.EventHandler(this.botaoBuscar_Click);
            // 
            // groupBoxGeral
            // 
            this.groupBoxGeral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGeral.Controls.Add(this.tabControlDescricao);
            this.groupBoxGeral.Controls.Add(this.groupBoxBeneficio);
            this.groupBoxGeral.Controls.Add(this.groupBoxInformacaoGeral);
            this.groupBoxGeral.Location = new System.Drawing.Point(12, 62);
            this.groupBoxGeral.Name = "groupBoxGeral";
            this.groupBoxGeral.Size = new System.Drawing.Size(756, 687);
            this.groupBoxGeral.TabIndex = 35;
            this.groupBoxGeral.TabStop = false;
            this.groupBoxGeral.Text = "Resultado";
            // 
            // tabControlDescricao
            // 
            this.tabControlDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlDescricao.Controls.Add(this.tabPage1);
            this.tabControlDescricao.Controls.Add(this.tabPage2);
            this.tabControlDescricao.Location = new System.Drawing.Point(9, 361);
            this.tabControlDescricao.Name = "tabControlDescricao";
            this.tabControlDescricao.SelectedIndex = 0;
            this.tabControlDescricao.Size = new System.Drawing.Size(731, 163);
            this.tabControlDescricao.TabIndex = 55;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitterControl1);
            this.tabPage1.Controls.Add(this.richTextBoxDescricaoCargo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(723, 137);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Descrição do Cargo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(3, 3);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 131);
            this.splitterControl1.TabIndex = 55;
            this.splitterControl1.TabStop = false;
            // 
            // richTextBoxDescricaoCargo
            // 
            this.richTextBoxDescricaoCargo.AcceptsTab = true;
            this.richTextBoxDescricaoCargo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxDescricaoCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDescricaoCargo.Location = new System.Drawing.Point(6, 6);
            this.richTextBoxDescricaoCargo.Name = "richTextBoxDescricaoCargo";
            this.richTextBoxDescricaoCargo.ReadOnly = true;
            this.richTextBoxDescricaoCargo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxDescricaoCargo.Size = new System.Drawing.Size(711, 125);
            this.richTextBoxDescricaoCargo.TabIndex = 54;
            this.richTextBoxDescricaoCargo.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBoxAtividadesPrincipais);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(723, 137);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Principais Atividades";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBoxAtividadesPrincipais
            // 
            this.richTextBoxAtividadesPrincipais.AcceptsTab = true;
            this.richTextBoxAtividadesPrincipais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxAtividadesPrincipais.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxAtividadesPrincipais.Location = new System.Drawing.Point(6, 6);
            this.richTextBoxAtividadesPrincipais.Name = "richTextBoxAtividadesPrincipais";
            this.richTextBoxAtividadesPrincipais.ReadOnly = true;
            this.richTextBoxAtividadesPrincipais.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxAtividadesPrincipais.Size = new System.Drawing.Size(711, 125);
            this.richTextBoxAtividadesPrincipais.TabIndex = 55;
            this.richTextBoxAtividadesPrincipais.Text = "";
            // 
            // groupBoxBeneficio
            // 
            this.groupBoxBeneficio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBeneficio.Controls.Add(this.label12);
            this.groupBoxBeneficio.Controls.Add(this.textBoxComputador);
            this.groupBoxBeneficio.Controls.Add(this.label14);
            this.groupBoxBeneficio.Controls.Add(this.label13);
            this.groupBoxBeneficio.Controls.Add(this.label15);
            this.groupBoxBeneficio.Controls.Add(this.textBoxAlimentacaoFimDeSemana);
            this.groupBoxBeneficio.Controls.Add(this.label11);
            this.groupBoxBeneficio.Controls.Add(this.textBoxAlimentacao);
            this.groupBoxBeneficio.Controls.Add(this.textBoxSalario);
            this.groupBoxBeneficio.Controls.Add(this.textBoxAcomodacaoCoberta);
            this.groupBoxBeneficio.Controls.Add(this.label16);
            this.groupBoxBeneficio.Controls.Add(this.textBoxAcomodacaoProvida);
            this.groupBoxBeneficio.Location = new System.Drawing.Point(9, 218);
            this.groupBoxBeneficio.Name = "groupBoxBeneficio";
            this.groupBoxBeneficio.Size = new System.Drawing.Size(731, 137);
            this.groupBoxBeneficio.TabIndex = 52;
            this.groupBoxBeneficio.TabStop = false;
            this.groupBoxBeneficio.Text = "Benefícios";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(340, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 17);
            this.label12.TabIndex = 46;
            this.label12.Text = "Computador";
            // 
            // textBoxComputador
            // 
            this.textBoxComputador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxComputador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxComputador.Location = new System.Drawing.Point(514, 79);
            this.textBoxComputador.Name = "textBoxComputador";
            this.textBoxComputador.ReadOnly = true;
            this.textBoxComputador.Size = new System.Drawing.Size(207, 24);
            this.textBoxComputador.TabIndex = 57;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(340, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(168, 17);
            this.label14.TabIndex = 48;
            this.label14.Text = "Alim. no Fim de Semana";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(340, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 17);
            this.label13.TabIndex = 47;
            this.label13.Text = "Alimentação";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(7, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 17);
            this.label15.TabIndex = 50;
            this.label15.Text = "Acom. Provida";
            // 
            // textBoxAlimentacaoFimDeSemana
            // 
            this.textBoxAlimentacaoFimDeSemana.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAlimentacaoFimDeSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxAlimentacaoFimDeSemana.Location = new System.Drawing.Point(514, 49);
            this.textBoxAlimentacaoFimDeSemana.Name = "textBoxAlimentacaoFimDeSemana";
            this.textBoxAlimentacaoFimDeSemana.ReadOnly = true;
            this.textBoxAlimentacaoFimDeSemana.Size = new System.Drawing.Size(207, 24);
            this.textBoxAlimentacaoFimDeSemana.TabIndex = 56;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 17);
            this.label11.TabIndex = 45;
            this.label11.Text = "Salário";
            // 
            // textBoxAlimentacao
            // 
            this.textBoxAlimentacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAlimentacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxAlimentacao.Location = new System.Drawing.Point(514, 19);
            this.textBoxAlimentacao.Name = "textBoxAlimentacao";
            this.textBoxAlimentacao.ReadOnly = true;
            this.textBoxAlimentacao.Size = new System.Drawing.Size(207, 24);
            this.textBoxAlimentacao.TabIndex = 55;
            // 
            // textBoxSalario
            // 
            this.textBoxSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxSalario.Location = new System.Drawing.Point(127, 79);
            this.textBoxSalario.Name = "textBoxSalario";
            this.textBoxSalario.ReadOnly = true;
            this.textBoxSalario.Size = new System.Drawing.Size(207, 24);
            this.textBoxSalario.TabIndex = 54;
            // 
            // textBoxAcomodacaoCoberta
            // 
            this.textBoxAcomodacaoCoberta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxAcomodacaoCoberta.Location = new System.Drawing.Point(127, 49);
            this.textBoxAcomodacaoCoberta.Name = "textBoxAcomodacaoCoberta";
            this.textBoxAcomodacaoCoberta.ReadOnly = true;
            this.textBoxAcomodacaoCoberta.Size = new System.Drawing.Size(207, 24);
            this.textBoxAcomodacaoCoberta.TabIndex = 53;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(7, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 17);
            this.label16.TabIndex = 49;
            this.label16.Text = "Acom. Coberta";
            // 
            // textBoxAcomodacaoProvida
            // 
            this.textBoxAcomodacaoProvida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxAcomodacaoProvida.Location = new System.Drawing.Point(127, 19);
            this.textBoxAcomodacaoProvida.Name = "textBoxAcomodacaoProvida";
            this.textBoxAcomodacaoProvida.ReadOnly = true;
            this.textBoxAcomodacaoProvida.Size = new System.Drawing.Size(207, 24);
            this.textBoxAcomodacaoProvida.TabIndex = 52;
            // 
            // groupBoxInformacaoGeral
            // 
            this.groupBoxInformacaoGeral.Controls.Add(this.textBoxLocalizacaoEspecifica);
            this.groupBoxInformacaoGeral.Controls.Add(this.label1);
            this.groupBoxInformacaoGeral.Controls.Add(this.textBoxTrabalhaSabado);
            this.groupBoxInformacaoGeral.Controls.Add(this.textBoxCargaHorariaSemanal);
            this.groupBoxInformacaoGeral.Controls.Add(this.textBoxCargaHorariaDiaria);
            this.groupBoxInformacaoGeral.Controls.Add(this.textBoxCidadeDestino);
            this.groupBoxInformacaoGeral.Controls.Add(this.textBoxDuracao);
            this.groupBoxInformacaoGeral.Controls.Add(this.textBoxDataFim);
            this.groupBoxInformacaoGeral.Controls.Add(this.textBoxDataInicio);
            this.groupBoxInformacaoGeral.Controls.Add(this.textBoxPais);
            this.groupBoxInformacaoGeral.Controls.Add(this.label2);
            this.groupBoxInformacaoGeral.Controls.Add(this.label3);
            this.groupBoxInformacaoGeral.Controls.Add(this.label4);
            this.groupBoxInformacaoGeral.Controls.Add(this.label5);
            this.groupBoxInformacaoGeral.Controls.Add(this.label6);
            this.groupBoxInformacaoGeral.Controls.Add(this.label7);
            this.groupBoxInformacaoGeral.Controls.Add(this.label8);
            this.groupBoxInformacaoGeral.Controls.Add(this.label10);
            this.groupBoxInformacaoGeral.Location = new System.Drawing.Point(9, 31);
            this.groupBoxInformacaoGeral.Name = "groupBoxInformacaoGeral";
            this.groupBoxInformacaoGeral.Size = new System.Drawing.Size(731, 181);
            this.groupBoxInformacaoGeral.TabIndex = 51;
            this.groupBoxInformacaoGeral.TabStop = false;
            this.groupBoxInformacaoGeral.Text = "Informações Gerais";
            // 
            // textBoxLocalizacaoEspecifica
            // 
            this.textBoxLocalizacaoEspecifica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLocalizacaoEspecifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxLocalizacaoEspecifica.Location = new System.Drawing.Point(127, 148);
            this.textBoxLocalizacaoEspecifica.Name = "textBoxLocalizacaoEspecifica";
            this.textBoxLocalizacaoEspecifica.ReadOnly = true;
            this.textBoxLocalizacaoEspecifica.Size = new System.Drawing.Size(594, 24);
            this.textBoxLocalizacaoEspecifica.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Localização";
            // 
            // textBoxTrabalhaSabado
            // 
            this.textBoxTrabalhaSabado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTrabalhaSabado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxTrabalhaSabado.Location = new System.Drawing.Point(514, 117);
            this.textBoxTrabalhaSabado.Name = "textBoxTrabalhaSabado";
            this.textBoxTrabalhaSabado.ReadOnly = true;
            this.textBoxTrabalhaSabado.Size = new System.Drawing.Size(207, 24);
            this.textBoxTrabalhaSabado.TabIndex = 52;
            // 
            // textBoxCargaHorariaSemanal
            // 
            this.textBoxCargaHorariaSemanal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCargaHorariaSemanal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxCargaHorariaSemanal.Location = new System.Drawing.Point(514, 87);
            this.textBoxCargaHorariaSemanal.Name = "textBoxCargaHorariaSemanal";
            this.textBoxCargaHorariaSemanal.ReadOnly = true;
            this.textBoxCargaHorariaSemanal.Size = new System.Drawing.Size(207, 24);
            this.textBoxCargaHorariaSemanal.TabIndex = 51;
            // 
            // textBoxCargaHorariaDiaria
            // 
            this.textBoxCargaHorariaDiaria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCargaHorariaDiaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxCargaHorariaDiaria.Location = new System.Drawing.Point(514, 57);
            this.textBoxCargaHorariaDiaria.Name = "textBoxCargaHorariaDiaria";
            this.textBoxCargaHorariaDiaria.ReadOnly = true;
            this.textBoxCargaHorariaDiaria.Size = new System.Drawing.Size(207, 24);
            this.textBoxCargaHorariaDiaria.TabIndex = 50;
            // 
            // textBoxCidadeDestino
            // 
            this.textBoxCidadeDestino.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCidadeDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxCidadeDestino.Location = new System.Drawing.Point(514, 24);
            this.textBoxCidadeDestino.Name = "textBoxCidadeDestino";
            this.textBoxCidadeDestino.ReadOnly = true;
            this.textBoxCidadeDestino.Size = new System.Drawing.Size(207, 24);
            this.textBoxCidadeDestino.TabIndex = 49;
            // 
            // textBoxDuracao
            // 
            this.textBoxDuracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxDuracao.Location = new System.Drawing.Point(127, 114);
            this.textBoxDuracao.Name = "textBoxDuracao";
            this.textBoxDuracao.ReadOnly = true;
            this.textBoxDuracao.Size = new System.Drawing.Size(207, 24);
            this.textBoxDuracao.TabIndex = 47;
            // 
            // textBoxDataFim
            // 
            this.textBoxDataFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxDataFim.Location = new System.Drawing.Point(127, 84);
            this.textBoxDataFim.Name = "textBoxDataFim";
            this.textBoxDataFim.ReadOnly = true;
            this.textBoxDataFim.Size = new System.Drawing.Size(207, 24);
            this.textBoxDataFim.TabIndex = 46;
            // 
            // textBoxDataInicio
            // 
            this.textBoxDataInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxDataInicio.Location = new System.Drawing.Point(127, 54);
            this.textBoxDataInicio.Name = "textBoxDataInicio";
            this.textBoxDataInicio.ReadOnly = true;
            this.textBoxDataInicio.Size = new System.Drawing.Size(207, 24);
            this.textBoxDataInicio.TabIndex = 45;
            // 
            // textBoxPais
            // 
            this.textBoxPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxPais.Location = new System.Drawing.Point(127, 24);
            this.textBoxPais.Name = "textBoxPais";
            this.textBoxPais.ReadOnly = true;
            this.textBoxPais.Size = new System.Drawing.Size(207, 24);
            this.textBoxPais.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "País de Destino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(340, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Cidade de Destino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Data de Início";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Data de Fim";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(340, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "CH Diária";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(340, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 17);
            this.label7.TabIndex = 41;
            this.label7.Text = "Trabalho aos Sábados";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(340, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 42;
            this.label8.Text = "CH Semanal";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 17);
            this.label10.TabIndex = 44;
            this.label10.Text = "Duração (EXPA)";
            // 
            // ConsultaOpportunity
            // 
            this.AcceptButton = this.botaoBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.groupBoxGeral);
            this.Controls.Add(this.groupBoxBusca);
            this.Name = "ConsultaOpportunity";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consultar TN ID";
            this.groupBoxBusca.ResumeLayout(false);
            this.groupBoxBusca.PerformLayout();
            this.groupBoxGeral.ResumeLayout(false);
            this.tabControlDescricao.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBoxBeneficio.ResumeLayout(false);
            this.groupBoxBeneficio.PerformLayout();
            this.groupBoxInformacaoGeral.ResumeLayout(false);
            this.groupBoxInformacaoGeral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label nomeCompleto;
        private System.Windows.Forms.TextBox inputTNID;
        private System.Windows.Forms.GroupBox groupBoxBusca;
        private System.Windows.Forms.Button botaoBuscar;
        private System.Windows.Forms.GroupBox groupBoxGeral;
        private System.Windows.Forms.GroupBox groupBoxBeneficio;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBoxInformacaoGeral;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabControl tabControlDescricao;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBoxDescricaoCargo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBoxAtividadesPrincipais;
        private System.Windows.Forms.TextBox textBoxComputador;
        private System.Windows.Forms.TextBox textBoxAlimentacaoFimDeSemana;
        private System.Windows.Forms.TextBox textBoxAlimentacao;
        private System.Windows.Forms.TextBox textBoxSalario;
        private System.Windows.Forms.TextBox textBoxAcomodacaoCoberta;
        private System.Windows.Forms.TextBox textBoxAcomodacaoProvida;
        private System.Windows.Forms.TextBox textBoxTrabalhaSabado;
        private System.Windows.Forms.TextBox textBoxCargaHorariaSemanal;
        private System.Windows.Forms.TextBox textBoxCargaHorariaDiaria;
        private System.Windows.Forms.TextBox textBoxCidadeDestino;
        private System.Windows.Forms.TextBox textBoxDuracao;
        private System.Windows.Forms.TextBox textBoxDataFim;
        private System.Windows.Forms.TextBox textBoxDataInicio;
        private System.Windows.Forms.TextBox textBoxPais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLocalizacaoEspecifica;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
    }
}