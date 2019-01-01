namespace Principal.Forms
{
    partial class ListaPessoas
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
            this.botaoNovo = new DevExpress.XtraEditors.SimpleButton();
            this.botaoEditar = new DevExpress.XtraEditors.SimpleButton();
            this.botaoRemover = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.inputNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlListaPessoas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // inputNome
            // 
            this.inputNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputNome.Location = new System.Drawing.Point(68, 10);
            this.inputNome.Name = "inputNome";
            this.inputNome.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNome.Properties.Appearance.Options.UseFont = true;
            this.inputNome.Size = new System.Drawing.Size(575, 24);
            this.inputNome.TabIndex = 31;
            this.inputNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(12, 14);
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
            this.botaoPesquisar.Size = new System.Drawing.Size(75, 27);
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
            // botaoNovo
            // 
            this.botaoNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.botaoNovo.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoNovo.Appearance.Options.UseFont = true;
            this.botaoNovo.Location = new System.Drawing.Point(12, 429);
            this.botaoNovo.Name = "botaoNovo";
            this.botaoNovo.Size = new System.Drawing.Size(75, 28);
            this.botaoNovo.TabIndex = 51;
            this.botaoNovo.Text = "Novo";
            this.botaoNovo.Click += new System.EventHandler(this.botaoNovo_Click);
            // 
            // botaoEditar
            // 
            this.botaoEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.botaoEditar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoEditar.Appearance.Options.UseFont = true;
            this.botaoEditar.Location = new System.Drawing.Point(93, 429);
            this.botaoEditar.Name = "botaoEditar";
            this.botaoEditar.Size = new System.Drawing.Size(75, 28);
            this.botaoEditar.TabIndex = 52;
            this.botaoEditar.Text = "Editar";
            this.botaoEditar.Click += new System.EventHandler(this.botaoEditar_Click);
            // 
            // botaoRemover
            // 
            this.botaoRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoRemover.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoRemover.Appearance.Options.UseFont = true;
            this.botaoRemover.Location = new System.Drawing.Point(649, 429);
            this.botaoRemover.Name = "botaoRemover";
            this.botaoRemover.Size = new System.Drawing.Size(75, 28);
            this.botaoRemover.TabIndex = 53;
            this.botaoRemover.Text = "Remover";
            this.botaoRemover.Click += new System.EventHandler(this.botaoRemover_Click);
            // 
            // ListaPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 466);
            this.Controls.Add(this.botaoRemover);
            this.Controls.Add(this.botaoEditar);
            this.Controls.Add(this.botaoNovo);
            this.Controls.Add(this.gridControlListaPessoas);
            this.Controls.Add(this.botaoPesquisar);
            this.Controls.Add(this.inputNome);
            this.Controls.Add(this.labelControl1);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "ListaPessoas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pessoas";
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
        private DevExpress.XtraEditors.SimpleButton botaoNovo;
        private DevExpress.XtraEditors.SimpleButton botaoEditar;
        private DevExpress.XtraEditors.SimpleButton botaoRemover;
    }
}