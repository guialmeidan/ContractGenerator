using DevExpress.XtraEditors;
using Principal.Domain.Repositories;
using Principal.WinApp;
using Principal.Domain;
using Unity;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal.Forms
{

    public partial class Escritorio : XtraForm
    {
        private IEscritorioRepositorio _repositorioEscritorio;
        private IPessoaRepositorio _repositorioPessoa;
        private Domain.Entities.Escritorio _escritorio;
        private int pessoaId;
        private string pessoaNome;

        public Escritorio()
        {
            InitializeComponent();
            _repositorioEscritorio = AppCore.Container.Resolve<IEscritorioRepositorio>();
            _repositorioPessoa = AppCore.Container.Resolve<IPessoaRepositorio>();
            this.Text = "Cadastro de Escritório";
            
            popularTela();
        }

        private void popularTela()
        {
            _escritorio = _repositorioEscritorio.ObterEscritorio();
            inputNome.Text = _escritorio.Nome;
            inputCNPJ.Text = _escritorio.CNPJ;
            inputCEP.Text = _escritorio.CEP;
            inputRua.Text = _escritorio.Rua;
            inputNumero.Text = _escritorio.Numero;
            inputBairro.Text = _escritorio.Bairro;
            inputCidade.Text = _escritorio.Cidade;
            inputUFEndereco.Text = _escritorio.UF;
            inputComplemento.Text = _escritorio.Complemento;
            inputLCP.Text = _escritorio.LCPNome;
        }

        private void botaoPesquisarCEP_Click(object sender, EventArgs e)
        {
            //consulta ws dos correios e preenche campos de endereco
            using (var ws = new br.com.correios.apps.AtendeClienteService())
            {
                try
                {
                    var resultado = ws.consultaCEP(inputCEP.Text);
                    this.inputRua.Text = resultado.end;
                    this.inputCidade.Text = resultado.cidade;
                    this.inputBairro.Text = resultado.bairro;
                    this.inputUFEndereco.Text = resultado.uf;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Atenção!",
                    MessageBoxButtons.OK);
                }
            }
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                _escritorio.Nome = inputNome.Text;
                _escritorio.CNPJ = inputCNPJ.Text;
                _escritorio.CEP = inputCEP.Text;
                _escritorio.Rua = inputRua.Text;
                _escritorio.Numero = inputNumero.Text;
                _escritorio.Bairro = inputBairro.Text;
                _escritorio.Cidade = inputCidade.Text;
                _escritorio.UF = inputUFEndereco.Text;
                _escritorio.Complemento = inputComplemento.Text;

                //indica que houve alteracao de LCP
                if (pessoaId > 0 && pessoaNome != null)
                {
                    _escritorio.LCP = pessoaId;
                    _escritorio.LCPNome = inputLCP.Text;
                }

                _repositorioEscritorio.Atualizar(_escritorio);

                MessageBox.Show("Registro gravado!\n", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar escritório\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void inputLCP_EditValueChanged(object sender, EventArgs e)
        {
            var LCP = sender as DevExpress.XtraEditors.ButtonEdit;
            var pessoas = _repositorioPessoa.ListarTodasPessoas();
            var form = new SelecionarPessoa(pessoas);
            form.ShowDialog(MdiParent);
            pessoaId = form.SelectedItem.Id;
            pessoaNome = form.SelectedItem.Nome;
            inputLCP.Text = form.SelectedItem.Nome + " " + form.SelectedItem.Sobrenome;
        }
    }
}
