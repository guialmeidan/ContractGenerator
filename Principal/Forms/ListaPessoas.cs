using DevExpress.Office.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Principal.Domain;
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
    public partial class ListaPessoas : XtraForm
    {
        private IPessoaService _pessoaService;
        private IPessoaRepositorio _pessoaRepositorio;
        private int operacao;
        private Pessoa _pessoa;

        private ITestemunhaRepositorio _repositorioTestemunha;
        private IEscritorioRepositorio _repositorioEscritorio;

        public ListaPessoas()
        {
            InitializeComponent();
            _pessoaService = AppCore.Container.Resolve<IPessoaService>();
            _pessoaRepositorio = AppCore.Container.Resolve<IPessoaRepositorio>();
            _repositorioTestemunha = AppCore.Container.Resolve<ITestemunhaRepositorio>();
            _repositorioEscritorio = AppCore.Container.Resolve<IEscritorioRepositorio>();

            iniciarGrid();
            this.Text = "Lista de Pessoas";
        }

        public void iniciarGrid()
        {
            this.gridControlListaPessoas.Refresh();
            this.gridControlListaPessoas.DataSource = _pessoaRepositorio.ListarTodasPessoas();

        }

        private void botaoPesquisar_Click(object sender, EventArgs e)
        {
            gridControlListaPessoas.Refresh();
            gridControlListaPessoas.DataSource = _pessoaRepositorio.PesquisarPorNome(inputNome.Text);
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                botaoPesquisar_Click(sender, e);
            }
        }

        private void botaoNovo_Click(object sender, EventArgs e)
        {
            operacao = 1;
            var f = Application.OpenForms[nameof(InserirPessoa)];
            if (f != null)
                f.BringToFront();
            else
            {
                var formEdit = new InserirPessoa(null, operacao, this) { MdiParent = this.MdiParent };
                formEdit.Show();
            }
        }

        private Pessoa ObterPessoaSelecionada()
        {
            _pessoa = ((GridView)gridControlListaPessoas.MainView).GetFocusedRow() as Pessoa;
            if (_pessoa == null)
                XtraMessageBox.Show("Selecione uma linha!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return _pessoa;
        }

        private void botaoEditar_Click(object sender, EventArgs e)
        {
            operacao = 2;
            _pessoa = ObterPessoaSelecionada();
            var f = Application.OpenForms[nameof(InserirPessoa)];
            if (f != null)
                f.Close();
             var formEdit = new InserirPessoa(_pessoa, operacao, this) { MdiParent = this.MdiParent };
             formEdit.Show();
        }

        private void gridControlListaPessoas_Click(object sender, EventArgs e)
        {
            botaoEditar_Click(sender, e);
        }

        private void botaoRemover_Click(object sender, EventArgs e)
        {
            _pessoa = ObterPessoaSelecionada();

            if (_repositorioEscritorio.VerificarSeELCP(_pessoa.Id) == true)
                XtraMessageBox.Show("Não é permitido remover o(a) LCP!", "Ação não permitida!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (_repositorioTestemunha.VerificarTestemunhaExiste(_pessoa.Id) == true)
                XtraMessageBox.Show("Não é permitido remover uma testemunha padrão!", "Ação não permitida!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (_pessoaRepositorio.VerificarSePessoaEstaEmApproved(_pessoa.Id) == true)
                XtraMessageBox.Show("Esta pessoa está envolvida em um ou mais approveds!", "Ação não permitida!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (XtraMessageBox.Show("Tem certeza que deseja remover "+_pessoa.Nome+"?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _pessoaRepositorio.Remover(_pessoa);
                gridControlListaPessoas.Refresh();
            }
        }
    }
}
