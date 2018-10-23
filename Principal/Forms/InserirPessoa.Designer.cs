using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Principal.Forms
{
    partial class InserirPessoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InserirPessoa));
            this.inputNome = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControlDadosGerais = new DevExpress.XtraEditors.GroupControl();
            this.inputProfissao = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.inputEstadoCivil = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.inputNacionalidade = new DevExpress.XtraEditors.TextEdit();
            this.inputSobrenome = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.inputCPF = new System.Windows.Forms.MaskedTextBox();
            this.inputUFDocumento = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.radioGroupDocumento = new DevExpress.XtraEditors.RadioGroup();
            this.inputOrgaoExpedidor = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.inputNumeroDoc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.inputComplemento = new DevExpress.XtraEditors.TextEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.inputUFEndereco = new DevExpress.XtraEditors.ComboBoxEdit();
            this.inputBairro = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.inputCidade = new DevExpress.XtraEditors.TextEdit();
            this.inputRua = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.inputEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.inputCEP = new System.Windows.Forms.MaskedTextBox();
            this.inputNumero = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.botaoPesquisarCEP = new DevExpress.XtraEditors.SimpleButton();
            this.botaoSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.botaoResetar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.inputNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDadosGerais)).BeginInit();
            this.groupControlDadosGerais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputProfissao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputEstadoCivil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputNacionalidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSobrenome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputUFDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputOrgaoExpedidor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputNumeroDoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputComplemento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputUFEndereco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputBairro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputRua.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputNumero.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // inputNome
            // 
            this.inputNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputNome.Location = new System.Drawing.Point(120, 31);
            this.inputNome.Name = "inputNome";
            this.inputNome.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNome.Properties.Appearance.Options.UseFont = true;
            this.inputNome.Size = new System.Drawing.Size(328, 22);
            this.inputNome.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(13, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 16);
            this.labelControl1.TabIndex = 30;
            this.labelControl1.Text = "Nome";
            // 
            // groupControlDadosGerais
            // 
            this.groupControlDadosGerais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControlDadosGerais.Controls.Add(this.inputProfissao);
            this.groupControlDadosGerais.Controls.Add(this.labelControl5);
            this.groupControlDadosGerais.Controls.Add(this.inputEstadoCivil);
            this.groupControlDadosGerais.Controls.Add(this.labelControl4);
            this.groupControlDadosGerais.Controls.Add(this.inputNacionalidade);
            this.groupControlDadosGerais.Controls.Add(this.inputSobrenome);
            this.groupControlDadosGerais.Controls.Add(this.labelControl3);
            this.groupControlDadosGerais.Controls.Add(this.labelControl2);
            this.groupControlDadosGerais.Controls.Add(this.inputNome);
            this.groupControlDadosGerais.Controls.Add(this.labelControl1);
            this.groupControlDadosGerais.Location = new System.Drawing.Point(12, 12);
            this.groupControlDadosGerais.Name = "groupControlDadosGerais";
            this.groupControlDadosGerais.Size = new System.Drawing.Size(760, 118);
            this.groupControlDadosGerais.TabIndex = 30;
            this.groupControlDadosGerais.Text = "Dados Gerais";
            // 
            // inputProfissao
            // 
            this.inputProfissao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputProfissao.Location = new System.Drawing.Point(120, 83);
            this.inputProfissao.Name = "inputProfissao";
            this.inputProfissao.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputProfissao.Properties.Appearance.Options.UseFont = true;
            this.inputProfissao.Size = new System.Drawing.Size(328, 22);
            this.inputProfissao.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(13, 84);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(57, 16);
            this.labelControl5.TabIndex = 39;
            this.labelControl5.Text = "Profissão";
            // 
            // inputEstadoCivil
            // 
            this.inputEstadoCivil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputEstadoCivil.Location = new System.Drawing.Point(579, 31);
            this.inputEstadoCivil.Name = "inputEstadoCivil";
            this.inputEstadoCivil.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputEstadoCivil.Properties.Appearance.Options.UseFont = true;
            this.inputEstadoCivil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.inputEstadoCivil.Properties.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Casado(a)",
            "Separado(a)",
            "Divorciado(a)",
            "Viúvo(a)"});
            this.inputEstadoCivil.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.inputEstadoCivil.Size = new System.Drawing.Size(167, 22);
            this.inputEstadoCivil.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(476, 32);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(71, 16);
            this.labelControl4.TabIndex = 36;
            this.labelControl4.Text = "Estado Civil";
            // 
            // inputNacionalidade
            // 
            this.inputNacionalidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputNacionalidade.EditValue = "Brasileiro(a)";
            this.inputNacionalidade.Location = new System.Drawing.Point(579, 57);
            this.inputNacionalidade.Name = "inputNacionalidade";
            this.inputNacionalidade.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNacionalidade.Properties.Appearance.Options.UseFont = true;
            this.inputNacionalidade.Size = new System.Drawing.Size(167, 22);
            this.inputNacionalidade.TabIndex = 5;
            // 
            // inputSobrenome
            // 
            this.inputSobrenome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputSobrenome.Location = new System.Drawing.Point(120, 57);
            this.inputSobrenome.Name = "inputSobrenome";
            this.inputSobrenome.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputSobrenome.Properties.Appearance.Options.UseFont = true;
            this.inputSobrenome.Size = new System.Drawing.Size(328, 22);
            this.inputSobrenome.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(476, 61);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(89, 16);
            this.labelControl3.TabIndex = 34;
            this.labelControl3.Text = "Nacionalidade";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(13, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 16);
            this.labelControl2.TabIndex = 32;
            this.labelControl2.Text = "Sobrenome";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.inputCPF);
            this.groupControl1.Controls.Add(this.inputUFDocumento);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.radioGroupDocumento);
            this.groupControl1.Controls.Add(this.inputOrgaoExpedidor);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.inputNumeroDoc);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Location = new System.Drawing.Point(12, 142);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(760, 123);
            this.groupControl1.TabIndex = 31;
            this.groupControl1.Text = "Documento Pessoal";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(165, 88);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(26, 16);
            this.labelControl8.TabIndex = 44;
            this.labelControl8.Text = "CPF";
            // 
            // inputCPF
            // 
            this.inputCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCPF.Location = new System.Drawing.Point(241, 88);
            this.inputCPF.Mask = "000.000.000-00";
            this.inputCPF.Name = "inputCPF";
            this.inputCPF.Size = new System.Drawing.Size(102, 22);
            this.inputCPF.TabIndex = 9;
            // 
            // inputUFDocumento
            // 
            this.inputUFDocumento.Location = new System.Drawing.Point(392, 36);
            this.inputUFDocumento.Name = "inputUFDocumento";
            this.inputUFDocumento.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputUFDocumento.Properties.Appearance.Options.UseFont = true;
            this.inputUFDocumento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.inputUFDocumento.Properties.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.inputUFDocumento.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.inputUFDocumento.Size = new System.Drawing.Size(55, 22);
            this.inputUFDocumento.TabIndex = 10;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(365, 38);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(18, 16);
            this.labelControl6.TabIndex = 41;
            this.labelControl6.Text = "UF";
            // 
            // radioGroupDocumento
            // 
            this.radioGroupDocumento.Location = new System.Drawing.Point(13, 25);
            this.radioGroupDocumento.Name = "radioGroupDocumento";
            this.radioGroupDocumento.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroupDocumento.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGroupDocumento.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroupDocumento.Properties.Appearance.Options.UseFont = true;
            this.radioGroupDocumento.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroupDocumento.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "RG"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Passaporte"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "RNE")});
            this.radioGroupDocumento.Size = new System.Drawing.Size(105, 91);
            this.radioGroupDocumento.TabIndex = 6;
            // 
            // inputOrgaoExpedidor
            // 
            this.inputOrgaoExpedidor.Location = new System.Drawing.Point(241, 34);
            this.inputOrgaoExpedidor.Name = "inputOrgaoExpedidor";
            this.inputOrgaoExpedidor.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputOrgaoExpedidor.Properties.Appearance.Options.UseFont = true;
            this.inputOrgaoExpedidor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.inputOrgaoExpedidor.Properties.Items.AddRange(new object[] {
            "SSP",
            "SPTC",
            "PM",
            "PC",
            "CNT",
            "DIC",
            "DETRAN",
            "CTPS",
            "FGTS",
            "IFP",
            "IPF",
            "IML",
            "MTE",
            "MMA",
            "MAE",
            "MEX",
            "POF",
            "POM",
            "SES",
            "SJS",
            "SJTS"});
            this.inputOrgaoExpedidor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.inputOrgaoExpedidor.Size = new System.Drawing.Size(102, 22);
            this.inputOrgaoExpedidor.TabIndex = 7;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(165, 35);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(70, 16);
            this.labelControl7.TabIndex = 36;
            this.labelControl7.Text = "Órg. Exped.";
            // 
            // inputNumeroDoc
            // 
            this.inputNumeroDoc.Location = new System.Drawing.Point(241, 62);
            this.inputNumeroDoc.Name = "inputNumeroDoc";
            this.inputNumeroDoc.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNumeroDoc.Properties.Appearance.Options.UseFont = true;
            this.inputNumeroDoc.Size = new System.Drawing.Size(102, 22);
            this.inputNumeroDoc.TabIndex = 8;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(165, 63);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(48, 16);
            this.labelControl9.TabIndex = 32;
            this.labelControl9.Text = "Número";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.inputComplemento);
            this.groupControl2.Controls.Add(this.labelControl17);
            this.groupControl2.Controls.Add(this.inputUFEndereco);
            this.groupControl2.Controls.Add(this.inputBairro);
            this.groupControl2.Controls.Add(this.labelControl11);
            this.groupControl2.Controls.Add(this.labelControl16);
            this.groupControl2.Controls.Add(this.inputCidade);
            this.groupControl2.Controls.Add(this.inputRua);
            this.groupControl2.Controls.Add(this.labelControl14);
            this.groupControl2.Controls.Add(this.inputEmail);
            this.groupControl2.Controls.Add(this.labelControl13);
            this.groupControl2.Controls.Add(this.labelControl15);
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Controls.Add(this.inputCEP);
            this.groupControl2.Controls.Add(this.inputNumero);
            this.groupControl2.Controls.Add(this.labelControl12);
            this.groupControl2.Controls.Add(this.botaoPesquisarCEP);
            this.groupControl2.Location = new System.Drawing.Point(12, 276);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(760, 145);
            this.groupControl2.TabIndex = 45;
            this.groupControl2.Text = "Endereço";
            // 
            // inputComplemento
            // 
            this.inputComplemento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputComplemento.Location = new System.Drawing.Point(123, 106);
            this.inputComplemento.Name = "inputComplemento";
            this.inputComplemento.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputComplemento.Properties.Appearance.Options.UseFont = true;
            this.inputComplemento.Size = new System.Drawing.Size(328, 22);
            this.inputComplemento.TabIndex = 14;
            // 
            // labelControl17
            // 
            this.labelControl17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl17.Location = new System.Drawing.Point(16, 107);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(84, 16);
            this.labelControl17.TabIndex = 55;
            this.labelControl17.Text = "Complemento";
            // 
            // inputUFEndereco
            // 
            this.inputUFEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputUFEndereco.Location = new System.Drawing.Point(579, 104);
            this.inputUFEndereco.Name = "inputUFEndereco";
            this.inputUFEndereco.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputUFEndereco.Properties.Appearance.Options.UseFont = true;
            this.inputUFEndereco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.inputUFEndereco.Properties.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.inputUFEndereco.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.inputUFEndereco.Size = new System.Drawing.Size(55, 22);
            this.inputUFEndereco.TabIndex = 19;
            // 
            // inputBairro
            // 
            this.inputBairro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputBairro.Location = new System.Drawing.Point(123, 80);
            this.inputBairro.Name = "inputBairro";
            this.inputBairro.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBairro.Properties.Appearance.Options.UseFont = true;
            this.inputBairro.Size = new System.Drawing.Size(328, 22);
            this.inputBairro.TabIndex = 13;
            // 
            // labelControl11
            // 
            this.labelControl11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Location = new System.Drawing.Point(16, 81);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(36, 16);
            this.labelControl11.TabIndex = 49;
            this.labelControl11.Text = "Bairro";
            // 
            // labelControl16
            // 
            this.labelControl16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Location = new System.Drawing.Point(486, 107);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(18, 16);
            this.labelControl16.TabIndex = 43;
            this.labelControl16.Text = "UF";
            // 
            // inputCidade
            // 
            this.inputCidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputCidade.Location = new System.Drawing.Point(579, 78);
            this.inputCidade.Name = "inputCidade";
            this.inputCidade.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCidade.Properties.Appearance.Options.UseFont = true;
            this.inputCidade.Size = new System.Drawing.Size(167, 22);
            this.inputCidade.TabIndex = 18;
            // 
            // inputRua
            // 
            this.inputRua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputRua.Location = new System.Drawing.Point(123, 53);
            this.inputRua.Name = "inputRua";
            this.inputRua.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputRua.Properties.Appearance.Options.UseFont = true;
            this.inputRua.Size = new System.Drawing.Size(328, 22);
            this.inputRua.TabIndex = 12;
            // 
            // labelControl14
            // 
            this.labelControl14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Location = new System.Drawing.Point(16, 57);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(25, 16);
            this.labelControl14.TabIndex = 46;
            this.labelControl14.Text = "Rua";
            // 
            // inputEmail
            // 
            this.inputEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputEmail.Location = new System.Drawing.Point(123, 28);
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputEmail.Properties.Appearance.Options.UseFont = true;
            this.inputEmail.Size = new System.Drawing.Size(328, 22);
            this.inputEmail.TabIndex = 11;
            // 
            // labelControl13
            // 
            this.labelControl13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Location = new System.Drawing.Point(16, 32);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(38, 16);
            this.labelControl13.TabIndex = 32;
            this.labelControl13.Text = "E-mail";
            // 
            // labelControl15
            // 
            this.labelControl15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Location = new System.Drawing.Point(486, 81);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(44, 16);
            this.labelControl15.TabIndex = 53;
            this.labelControl15.Text = "Cidade";
            // 
            // labelControl10
            // 
            this.labelControl10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(486, 29);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(27, 16);
            this.labelControl10.TabIndex = 44;
            this.labelControl10.Text = "CEP";
            // 
            // inputCEP
            // 
            this.inputCEP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCEP.Location = new System.Drawing.Point(579, 27);
            this.inputCEP.Mask = "00.000-000";
            this.inputCEP.Name = "inputCEP";
            this.inputCEP.Size = new System.Drawing.Size(86, 22);
            this.inputCEP.TabIndex = 15;
            // 
            // inputNumero
            // 
            this.inputNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputNumero.Location = new System.Drawing.Point(579, 54);
            this.inputNumero.Name = "inputNumero";
            this.inputNumero.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNumero.Properties.Appearance.Options.UseFont = true;
            this.inputNumero.Size = new System.Drawing.Size(86, 22);
            this.inputNumero.TabIndex = 17;
            // 
            // labelControl12
            // 
            this.labelControl12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Location = new System.Drawing.Point(486, 56);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(48, 16);
            this.labelControl12.TabIndex = 51;
            this.labelControl12.Text = "Número";
            // 
            // botaoPesquisarCEP
            // 
            this.botaoPesquisarCEP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoPesquisarCEP.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoPesquisarCEP.Appearance.Options.UseFont = true;
            this.botaoPesquisarCEP.Location = new System.Drawing.Point(671, 26);
            this.botaoPesquisarCEP.Name = "botaoPesquisarCEP";
            this.botaoPesquisarCEP.Size = new System.Drawing.Size(75, 23);
            this.botaoPesquisarCEP.TabIndex = 16;
            this.botaoPesquisarCEP.Text = "Pesquisar";
            this.botaoPesquisarCEP.Click += new System.EventHandler(this.botaoPesquisarCEP_Click);
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.botaoSalvar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSalvar.Appearance.Options.UseFont = true;
            this.botaoSalvar.Location = new System.Drawing.Point(12, 434);
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(75, 30);
            this.botaoSalvar.TabIndex = 20;
            this.botaoSalvar.Text = "Salvar";
            this.botaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // botaoResetar
            // 
            this.botaoResetar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoResetar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoResetar.Appearance.Options.UseFont = true;
            this.botaoResetar.Location = new System.Drawing.Point(697, 434);
            this.botaoResetar.Name = "botaoResetar";
            this.botaoResetar.Size = new System.Drawing.Size(75, 30);
            this.botaoResetar.TabIndex = 21;
            this.botaoResetar.Text = "Resetar";
            this.botaoResetar.Click += new System.EventHandler(this.botaoResetar_Click);
            // 
            // InserirPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 476);
            this.Controls.Add(this.botaoResetar);
            this.Controls.Add(this.botaoSalvar);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControlDadosGerais);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 515);
            this.Name = "InserirPessoa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pessoa";
            ((System.ComponentModel.ISupportInitialize)(this.inputNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDadosGerais)).EndInit();
            this.groupControlDadosGerais.ResumeLayout(false);
            this.groupControlDadosGerais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputProfissao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputEstadoCivil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputNacionalidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSobrenome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputUFDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputOrgaoExpedidor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputNumeroDoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputComplemento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputUFEndereco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputBairro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputRua.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputNumero.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit inputNome;
        private DevExpress.XtraEditors.GroupControl groupControlDadosGerais;
        private DevExpress.XtraEditors.TextEdit inputProfissao;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit inputEstadoCivil;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit inputNacionalidade;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit inputSobrenome;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.RadioGroup radioGroupDocumento;
        private DevExpress.XtraEditors.ComboBoxEdit inputOrgaoExpedidor;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit inputNumeroDoc;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private MaskedTextBox inputCPF;
        private DevExpress.XtraEditors.ComboBoxEdit inputUFDocumento;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit inputComplemento;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.ComboBoxEdit inputUFEndereco;
        private DevExpress.XtraEditors.TextEdit inputCidade;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.TextEdit inputNumero;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit inputBairro;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.SimpleButton botaoPesquisarCEP;
        private DevExpress.XtraEditors.TextEdit inputRua;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private MaskedTextBox inputCEP;
        private DevExpress.XtraEditors.TextEdit inputEmail;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.SimpleButton botaoSalvar;
        private DevExpress.XtraEditors.SimpleButton botaoResetar;
    }
}