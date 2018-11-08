namespace Principal.Forms
{
    partial class Escritorio
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
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.inputCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.groupControlDadosGerais = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.inputLCP = new DevExpress.XtraEditors.ButtonEdit();
            this.inputNome = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
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
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.inputCEP = new System.Windows.Forms.MaskedTextBox();
            this.inputNumero = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.botaoPesquisarCEP = new DevExpress.XtraEditors.SimpleButton();
            this.botaoSalvar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDadosGerais)).BeginInit();
            this.groupControlDadosGerais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputLCP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputComplemento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputUFEndereco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputBairro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputRua.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputNumero.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(475, 62);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(35, 16);
            this.labelControl8.TabIndex = 46;
            this.labelControl8.Text = "CNPJ";
            // 
            // inputCNPJ
            // 
            this.inputCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCNPJ.Location = new System.Drawing.Point(531, 59);
            this.inputCNPJ.Mask = "00.000.000/0000-00";
            this.inputCNPJ.Name = "inputCNPJ";
            this.inputCNPJ.Size = new System.Drawing.Size(135, 22);
            this.inputCNPJ.TabIndex = 3;
            // 
            // groupControlDadosGerais
            // 
            this.groupControlDadosGerais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControlDadosGerais.Controls.Add(this.labelControl2);
            this.groupControlDadosGerais.Controls.Add(this.inputLCP);
            this.groupControlDadosGerais.Controls.Add(this.inputNome);
            this.groupControlDadosGerais.Controls.Add(this.labelControl8);
            this.groupControlDadosGerais.Controls.Add(this.labelControl1);
            this.groupControlDadosGerais.Controls.Add(this.inputCNPJ);
            this.groupControlDadosGerais.Location = new System.Drawing.Point(12, 12);
            this.groupControlDadosGerais.Name = "groupControlDadosGerais";
            this.groupControlDadosGerais.Size = new System.Drawing.Size(683, 96);
            this.groupControlDadosGerais.TabIndex = 47;
            this.groupControlDadosGerais.Text = "Dados Gerais";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(13, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(25, 16);
            this.labelControl2.TabIndex = 48;
            this.labelControl2.Text = "LCP";
            // 
            // inputLCP
            // 
            this.inputLCP.Location = new System.Drawing.Point(73, 61);
            this.inputLCP.Name = "inputLCP";
            this.inputLCP.Properties.AllowFocused = false;
            this.inputLCP.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLCP.Properties.Appearance.Options.UseFont = true;
            this.inputLCP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.inputLCP.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.inputLCP.Size = new System.Drawing.Size(380, 22);
            this.inputLCP.TabIndex = 2;
            this.inputLCP.ButtonClick += this.inputLCP_EditValueChanged;
            //this.inputLCP.ButtonClick += this.inputLCP_EditValueChanged;
            // 
            // inputNome
            // 
            this.inputNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputNome.Location = new System.Drawing.Point(73, 31);
            this.inputNome.Name = "inputNome";
            this.inputNome.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNome.Properties.Appearance.Options.UseFont = true;
            this.inputNome.Size = new System.Drawing.Size(593, 22);
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
            this.groupControl2.Controls.Add(this.labelControl15);
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Controls.Add(this.inputCEP);
            this.groupControl2.Controls.Add(this.inputNumero);
            this.groupControl2.Controls.Add(this.labelControl12);
            this.groupControl2.Controls.Add(this.botaoPesquisarCEP);
            this.groupControl2.Location = new System.Drawing.Point(12, 114);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(683, 145);
            this.groupControl2.TabIndex = 48;
            this.groupControl2.Text = "Endereço";
            // 
            // inputComplemento
            // 
            this.inputComplemento.Location = new System.Drawing.Point(123, 106);
            this.inputComplemento.Name = "inputComplemento";
            this.inputComplemento.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputComplemento.Properties.Appearance.Options.UseFont = true;
            this.inputComplemento.Size = new System.Drawing.Size(328, 22);
            this.inputComplemento.TabIndex = 9;
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl17.Location = new System.Drawing.Point(16, 107);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(84, 16);
            this.labelControl17.TabIndex = 55;
            this.labelControl17.Text = "Complemento";
            // 
            // inputUFEndereco
            // 
            this.inputUFEndereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputUFEndereco.Location = new System.Drawing.Point(580, 78);
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
            this.inputUFEndereco.Size = new System.Drawing.Size(86, 22);
            this.inputUFEndereco.TabIndex = 11;
            // 
            // inputBairro
            // 
            this.inputBairro.Location = new System.Drawing.Point(123, 80);
            this.inputBairro.Name = "inputBairro";
            this.inputBairro.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBairro.Properties.Appearance.Options.UseFont = true;
            this.inputBairro.Size = new System.Drawing.Size(328, 22);
            this.inputBairro.TabIndex = 8;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Location = new System.Drawing.Point(16, 81);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(36, 16);
            this.labelControl11.TabIndex = 49;
            this.labelControl11.Text = "Bairro";
            // 
            // labelControl16
            // 
            this.labelControl16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Location = new System.Drawing.Point(526, 81);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(18, 16);
            this.labelControl16.TabIndex = 43;
            this.labelControl16.Text = "UF";
            // 
            // inputCidade
            // 
            this.inputCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputCidade.Location = new System.Drawing.Point(383, 25);
            this.inputCidade.Name = "inputCidade";
            this.inputCidade.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCidade.Properties.Appearance.Options.UseFont = true;
            this.inputCidade.Size = new System.Drawing.Size(283, 22);
            this.inputCidade.TabIndex = 6;
            // 
            // inputRua
            // 
            this.inputRua.Location = new System.Drawing.Point(123, 53);
            this.inputRua.Name = "inputRua";
            this.inputRua.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputRua.Properties.Appearance.Options.UseFont = true;
            this.inputRua.Size = new System.Drawing.Size(328, 22);
            this.inputRua.TabIndex = 7;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Location = new System.Drawing.Point(16, 57);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(25, 16);
            this.labelControl14.TabIndex = 46;
            this.labelControl14.Text = "Rua";
            // 
            // labelControl15
            // 
            this.labelControl15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Location = new System.Drawing.Point(322, 28);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(44, 16);
            this.labelControl15.TabIndex = 53;
            this.labelControl15.Text = "Cidade";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(16, 29);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(27, 16);
            this.labelControl10.TabIndex = 44;
            this.labelControl10.Text = "CEP";
            // 
            // inputCEP
            // 
            this.inputCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCEP.Location = new System.Drawing.Point(123, 26);
            this.inputCEP.Mask = "00.000-000";
            this.inputCEP.Name = "inputCEP";
            this.inputCEP.Size = new System.Drawing.Size(86, 22);
            this.inputCEP.TabIndex = 4;
            // 
            // inputNumero
            // 
            this.inputNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputNumero.Location = new System.Drawing.Point(580, 50);
            this.inputNumero.Name = "inputNumero";
            this.inputNumero.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNumero.Properties.Appearance.Options.UseFont = true;
            this.inputNumero.Size = new System.Drawing.Size(86, 22);
            this.inputNumero.TabIndex = 10;
            // 
            // labelControl12
            // 
            this.labelControl12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Location = new System.Drawing.Point(526, 56);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(48, 16);
            this.labelControl12.TabIndex = 51;
            this.labelControl12.Text = "Número";
            // 
            // botaoPesquisarCEP
            // 
            this.botaoPesquisarCEP.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoPesquisarCEP.Appearance.Options.UseFont = true;
            this.botaoPesquisarCEP.Location = new System.Drawing.Point(215, 25);
            this.botaoPesquisarCEP.Name = "botaoPesquisarCEP";
            this.botaoPesquisarCEP.Size = new System.Drawing.Size(75, 23);
            this.botaoPesquisarCEP.TabIndex = 5;
            this.botaoPesquisarCEP.Text = "Pesquisar";
            this.botaoPesquisarCEP.Click += new System.EventHandler(this.botaoPesquisarCEP_Click);
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.botaoSalvar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSalvar.Appearance.Options.UseFont = true;
            this.botaoSalvar.Location = new System.Drawing.Point(12, 265);
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(75, 30);
            this.botaoSalvar.TabIndex = 12;
            this.botaoSalvar.Text = "Salvar";
            this.botaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // Escritorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 305);
            this.Controls.Add(this.botaoSalvar);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControlDadosGerais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(723, 344);
            this.MinimumSize = new System.Drawing.Size(723, 344);
            this.Name = "Escritorio";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escritorio";
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDadosGerais)).EndInit();
            this.groupControlDadosGerais.ResumeLayout(false);
            this.groupControlDadosGerais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputLCP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputComplemento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputUFEndereco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputBairro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputRua.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputNumero.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.MaskedTextBox inputCNPJ;
        private DevExpress.XtraEditors.GroupControl groupControlDadosGerais;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ButtonEdit inputLCP;
        private DevExpress.XtraEditors.TextEdit inputNome;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit inputComplemento;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.ComboBoxEdit inputUFEndereco;
        private DevExpress.XtraEditors.TextEdit inputBairro;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.TextEdit inputCidade;
        private DevExpress.XtraEditors.TextEdit inputRua;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.MaskedTextBox inputCEP;
        private DevExpress.XtraEditors.TextEdit inputNumero;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.SimpleButton botaoPesquisarCEP;
        private DevExpress.XtraEditors.SimpleButton botaoSalvar;
    }
}