namespace Principal.Forms
{
    partial class SelecionarPessoa
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
            this.inputNome = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.botaoPesquisar = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlListaPessoas = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Nome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sobrenome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CPF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.botaoSelecionar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.inputNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlListaPessoas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // inputNome
            // 
            this.inputNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputNome.Location = new System.Drawing.Point(68, 9);
            this.inputNome.Name = "inputNome";
            this.inputNome.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNome.Properties.Appearance.Options.UseFont = true;
            this.inputNome.Size = new System.Drawing.Size(575, 22);
            this.inputNome.TabIndex = 31;
            this.inputNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 16);
            this.labelControl1.TabIndex = 32;
            this.labelControl1.Text = "Nome";
            // 
            // botaoPesquisar
            // 
            this.botaoPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoPesquisar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoPesquisar.Appearance.Options.UseFont = true;
            this.botaoPesquisar.Location = new System.Drawing.Point(649, 8);
            this.botaoPesquisar.Name = "botaoPesquisar";
            this.botaoPesquisar.Size = new System.Drawing.Size(75, 23);
            this.botaoPesquisar.TabIndex = 49;
            this.botaoPesquisar.Text = "Pesquisar";
            this.botaoPesquisar.Click += new System.EventHandler(this.botaoPesquisar_Click);
            // 
            // gridControlListaPessoas
            // 
            this.gridControlListaPessoas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlListaPessoas.Location = new System.Drawing.Point(12, 40);
            this.gridControlListaPessoas.MainView = this.gridView1;
            this.gridControlListaPessoas.Name = "gridControlListaPessoas";
            this.gridControlListaPessoas.Size = new System.Drawing.Size(712, 380);
            this.gridControlListaPessoas.TabIndex = 50;
            this.gridControlListaPessoas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControlListaPessoas.DoubleClick += new System.EventHandler(this.gridControlListaPessoas_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Nome,
            this.Sobrenome,
            this.CPF});
            this.gridView1.GridControl = this.gridControlListaPessoas;
            this.gridView1.Name = "gridView1";
            // 
            // Nome
            // 
            this.Nome.Caption = "Nome";
            this.Nome.FieldName = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.OptionsColumn.AllowEdit = false;
            this.Nome.Visible = true;
            this.Nome.VisibleIndex = 0;
            this.Nome.Width = 191;
            // 
            // Sobrenome
            // 
            this.Sobrenome.Caption = "Sobrenome";
            this.Sobrenome.FieldName = "Sobrenome";
            this.Sobrenome.Name = "Sobrenome";
            this.Sobrenome.OptionsColumn.AllowEdit = false;
            this.Sobrenome.Visible = true;
            this.Sobrenome.VisibleIndex = 1;
            this.Sobrenome.Width = 353;
            // 
            // CPF
            // 
            this.CPF.Caption = "CPF";
            this.CPF.FieldName = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.OptionsColumn.AllowEdit = false;
            this.CPF.Visible = true;
            this.CPF.VisibleIndex = 2;
            this.CPF.Width = 153;
            // 
            // botaoSelecionar
            // 
            this.botaoSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.botaoSelecionar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSelecionar.Appearance.Options.UseFont = true;
            this.botaoSelecionar.Location = new System.Drawing.Point(12, 429);
            this.botaoSelecionar.Name = "botaoSelecionar";
            this.botaoSelecionar.Size = new System.Drawing.Size(75, 28);
            this.botaoSelecionar.TabIndex = 51;
            this.botaoSelecionar.Text = "Selecionar";
            this.botaoSelecionar.Click += new System.EventHandler(this.botaoSelecionar_Click);
            // 
            // SelecionarPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 466);
            this.Controls.Add(this.botaoSelecionar);
            this.Controls.Add(this.gridControlListaPessoas);
            this.Controls.Add(this.botaoPesquisar);
            this.Controls.Add(this.inputNome);
            this.Controls.Add(this.labelControl1);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "SelecionarPessoa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaPessoas";
            ((System.ComponentModel.ISupportInitialize)(this.inputNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlListaPessoas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit inputNome;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton botaoPesquisar;
        private DevExpress.XtraGrid.GridControl gridControlListaPessoas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Nome;
        private DevExpress.XtraGrid.Columns.GridColumn Sobrenome;
        private DevExpress.XtraGrid.Columns.GridColumn CPF;
        private DevExpress.XtraEditors.SimpleButton botaoSelecionar;
    }
}