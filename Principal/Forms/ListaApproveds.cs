using DevExpress.Office.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Principal.Domain;
using Principal.Domain.Entities;
using Principal.Domain.Repositories;
using Principal.Domain.Services;
using Principal.WinApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace Principal.Forms
{
    public class ListaApproveds : XtraForm
    {
        private SimpleButton botaoPesquisar;
        private TextEdit inputPesquisa;
        private SimpleButton botaoRemover;
        private SimpleButton botaoEditar;
        private SimpleButton botaoNovo;
        private DevExpress.XtraGrid.GridControl gridControlListaApproveds;
        private GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn NomeEP;
        private DevExpress.XtraGrid.Columns.GridColumn TNID;
        private DevExpress.XtraGrid.Columns.GridColumn PaisDestino;
        private DevExpress.XtraGrid.Columns.GridColumn CidadeDestino;
        private LabelControl labelControl1;

        private IApprovedService _approvedService;
        private int operacao;
        private Approved _approved;

        public ListaApproveds()
        {
            InitializeComponent();
            _approvedService = AppCore.Container.Resolve<IApprovedService>();
            iniciarGrid();
        }

        private void iniciarGrid()
        {
            gridControlListaApproveds.Refresh();
            gridControlListaApproveds.DataSource = _approvedService.ListarApproveds();
        }

        private void InitializeComponent()
        {
            this.botaoPesquisar = new DevExpress.XtraEditors.SimpleButton();
            this.inputPesquisa = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.botaoRemover = new DevExpress.XtraEditors.SimpleButton();
            this.botaoEditar = new DevExpress.XtraEditors.SimpleButton();
            this.botaoNovo = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlListaApproveds = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NomeEP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TNID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PaisDestino = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CidadeDestino = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.inputPesquisa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlListaApproveds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // botaoPesquisar
            // 
            this.botaoPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoPesquisar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoPesquisar.Appearance.Options.UseFont = true;
            this.botaoPesquisar.Location = new System.Drawing.Point(649, 7);
            this.botaoPesquisar.Name = "botaoPesquisar";
            this.botaoPesquisar.Size = new System.Drawing.Size(75, 27);
            this.botaoPesquisar.TabIndex = 52;
            this.botaoPesquisar.Text = "Pesquisar";
            this.botaoPesquisar.Click += new System.EventHandler(this.botaoPesquisar_Click);
            // 
            // inputPesquisa
            // 
            this.inputPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPesquisa.Location = new System.Drawing.Point(75, 9);
            this.inputPesquisa.Name = "inputPesquisa";
            this.inputPesquisa.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPesquisa.Properties.Appearance.Options.UseFont = true;
            this.inputPesquisa.Size = new System.Drawing.Size(568, 24);
            this.inputPesquisa.TabIndex = 50;
            this.inputPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 16);
            this.labelControl1.TabIndex = 51;
            this.labelControl1.Text = "Pesquisa";
            // 
            // botaoRemover
            // 
            this.botaoRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoRemover.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoRemover.Appearance.Options.UseFont = true;
            this.botaoRemover.Location = new System.Drawing.Point(649, 429);
            this.botaoRemover.Name = "botaoRemover";
            this.botaoRemover.Size = new System.Drawing.Size(75, 28);
            this.botaoRemover.TabIndex = 57;
            this.botaoRemover.Text = "Remover";
            this.botaoRemover.Click += new System.EventHandler(this.botaoRemover_Click);
            // 
            // botaoEditar
            // 
            this.botaoEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.botaoEditar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoEditar.Appearance.Options.UseFont = true;
            this.botaoEditar.Location = new System.Drawing.Point(93, 429);
            this.botaoEditar.Name = "botaoEditar";
            this.botaoEditar.Size = new System.Drawing.Size(75, 28);
            this.botaoEditar.TabIndex = 56;
            this.botaoEditar.Text = "Editar";
            this.botaoEditar.Click += new System.EventHandler(this.botaoEditar_Click);
            // 
            // botaoNovo
            // 
            this.botaoNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.botaoNovo.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoNovo.Appearance.Options.UseFont = true;
            this.botaoNovo.Location = new System.Drawing.Point(12, 429);
            this.botaoNovo.Name = "botaoNovo";
            this.botaoNovo.Size = new System.Drawing.Size(75, 28);
            this.botaoNovo.TabIndex = 55;
            this.botaoNovo.Text = "Novo";
            this.botaoNovo.Click += new System.EventHandler(this.botaoNovo_Click);
            // 
            // gridControlListaApproveds
            // 
            this.gridControlListaApproveds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlListaApproveds.Location = new System.Drawing.Point(12, 40);
            this.gridControlListaApproveds.MainView = this.gridView1;
            this.gridControlListaApproveds.Name = "gridControlListaApproveds";
            this.gridControlListaApproveds.Size = new System.Drawing.Size(712, 380);
            this.gridControlListaApproveds.TabIndex = 54;
            this.gridControlListaApproveds.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControlListaApproveds.DoubleClick += new System.EventHandler(this.gridControlListaApproveds_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NomeEP,
            this.TNID,
            this.PaisDestino,
            this.CidadeDestino});
            this.gridView1.GridControl = this.gridControlListaApproveds;
            this.gridView1.Name = "gridView1";
            // 
            // NomeEP
            // 
            this.NomeEP.Caption = "Nome";
            this.NomeEP.FieldName = "NomeEP";
            this.NomeEP.Name = "NomeEP";
            this.NomeEP.OptionsColumn.AllowEdit = false;
            this.NomeEP.Visible = true;
            this.NomeEP.VisibleIndex = 0;
            this.NomeEP.Width = 259;
            // 
            // TNID
            // 
            this.TNID.Caption = "TN ID";
            this.TNID.FieldName = "TNID";
            this.TNID.Name = "TNID";
            this.TNID.OptionsColumn.AllowEdit = false;
            this.TNID.Visible = true;
            this.TNID.VisibleIndex = 1;
            this.TNID.Width = 82;
            // 
            // PaisDestino
            // 
            this.PaisDestino.Caption = "País de Destino";
            this.PaisDestino.FieldName = "PaisDestino";
            this.PaisDestino.Name = "PaisDestino";
            this.PaisDestino.OptionsColumn.AllowEdit = false;
            this.PaisDestino.Visible = true;
            this.PaisDestino.VisibleIndex = 2;
            this.PaisDestino.Width = 145;
            // 
            // CidadeDestino
            // 
            this.CidadeDestino.Caption = "Cidade Destino";
            this.CidadeDestino.FieldName = "CidadeDestino";
            this.CidadeDestino.Name = "CidadeDestino";
            this.CidadeDestino.OptionsColumn.AllowEdit = false;
            this.CidadeDestino.Visible = true;
            this.CidadeDestino.VisibleIndex = 3;
            this.CidadeDestino.Width = 210;
            // 
            // ListaApproveds
            // 
            this.ClientSize = new System.Drawing.Size(736, 466);
            this.Controls.Add(this.botaoRemover);
            this.Controls.Add(this.botaoEditar);
            this.Controls.Add(this.botaoNovo);
            this.Controls.Add(this.gridControlListaApproveds);
            this.Controls.Add(this.botaoPesquisar);
            this.Controls.Add(this.inputPesquisa);
            this.Controls.Add(this.labelControl1);
            this.MinimumSize = new System.Drawing.Size(752, 505);
            this.Name = "ListaApproveds";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Approveds";
            ((System.ComponentModel.ISupportInitialize)(this.inputPesquisa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlListaApproveds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void botaoNovo_Click(object sender, EventArgs e)
        {
            operacao = 1;
            var f = Application.OpenForms[nameof(RegistroApproved)];
            if (f != null)
                f.BringToFront();
            else
            {
                var formEdit = new RegistroApproved(null, operacao) { MdiParent = this.MdiParent };
                formEdit.Show();
            }
        }

        private void botaoEditar_Click(object sender, EventArgs e)
        {
            operacao = 2;
            _approved = ObterApprovedSelecionado();
            var f = Application.OpenForms[nameof(RegistroApproved)];
            if (f != null)
                f.Close();
            var formEdit = new RegistroApproved(_approved, operacao) { MdiParent = this.MdiParent };
            formEdit.Show();
        }

        private void botaoRemover_Click(object sender, EventArgs e)
        {
            _approved = ObterApprovedSelecionado();
            if (MessageBox.Show("Tem certeza que deseja remover o Approved de " + _approved.NomeEP + " (TN ID "+ _approved.TNID + ")?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _approvedService.Remover(_approved);
                iniciarGrid();
            }
        }

        private Approved ObterApprovedSelecionado()
        {
            _approved = ((GridView)gridControlListaApproveds.MainView).GetFocusedRow() as Approved;
            if (_approved == null)
                MessageBox.Show("Selecione uma linha!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return _approved;
        }

        private void gridControlListaApproveds_Click(object sender, EventArgs e)
        {
            botaoEditar_Click(sender, e);
        }

        private void botaoPesquisar_Click(object sender, EventArgs e)
        {
            gridControlListaApproveds.Refresh();
            gridControlListaApproveds.DataSource = _approvedService.PesquisarApproved(inputPesquisa.Text);
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                botaoPesquisar_Click(sender, e);
            }
        }
    }
}
