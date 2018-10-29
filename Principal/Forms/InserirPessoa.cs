using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Entity;
using Principal.Domain;
using Principal.Infra.Repositories;
using Principal.Domain.Repositories;
using Principal.WinApp;
using Unity;
using DevExpress.XtraEditors;

namespace Principal.Forms
{
    public partial class InserirPessoa : XtraForm
    {
        ListaPessoas _formListaPessoas;
        private IPessoaRepositorio _repositorioPessoa;
        private Pessoa _pessoa;
        Dictionary<string, Control> _binds = new Dictionary<string, Control>();
        Validacoes validador = new Validacoes();
        int _operacao;

        //OPERACAO 1 = NOVO, 2 = EDITAR
        public InserirPessoa(Pessoa pessoa, int operacao, ListaPessoas formListaPessoas)
        {
            //Altera a cultura para substituir , por . e vice-versa (no caso dos valores monetários)
            System.Globalization.CultureInfo newCulture = (System.Globalization.CultureInfo)System.Globalization.CultureInfo.CurrentCulture.Clone();
            newCulture.NumberFormat.NumberGroupSeparator = ",";
            newCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = newCulture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = newCulture;

            _formListaPessoas = formListaPessoas;
            _operacao = operacao;
            InitializeComponent();
            _pessoa = pessoa;
            _repositorioPessoa = AppCore.Container.Resolve<IPessoaRepositorio>();

            if(_operacao == 1)
            {
                ResetarCampos();
            }
            else if(_operacao == 2)
            {
                this.Dock = DockStyle.Fill;

                inputNome.Text = _pessoa.Nome;
                inputSobrenome.Text = _pessoa.Sobrenome;
                inputProfissao.Text = _pessoa.Profissao;
                inputEstadoCivil.Text = _pessoa.EstadoCivil;
                inputNacionalidade.Text = _pessoa.Nacionalidade;
                radioGroupDocumento.SelectedIndex = _pessoa.TipoDocumento;
                inputOrgaoExpedidor.Text = _pessoa.OrgaoExpedidor;
                inputNumeroDoc.Text = _pessoa.NumeroDocumento;
                inputCPF.Text = _pessoa.CPF;
                inputUFDocumento.Text = _pessoa.UFDocumento;
                inputEmail.Text = _pessoa.Email;
                inputRua.Text = _pessoa.Rua;
                inputBairro.Text = _pessoa.Bairro;
                inputComplemento.Text = _pessoa.Complemento;
                inputCEP.Text = _pessoa.CEP;
                inputNumero.Text = _pessoa.Numero;
                inputCidade.Text = _pessoa.Cidade;
                inputUFEndereco.Text = _pessoa.UFEndereco;
            }
        }

        private void botaoResetar_Click(object sender, EventArgs e)
        {
            ResetarCampos();
            _operacao = 1;
        }

        private void ResetarCampos()
        {
            inputNome.Text = "";
            inputSobrenome.Text = "";
            inputEstadoCivil.SelectedIndex = 0;
            inputNacionalidade.Text = "";
            inputProfissao.Text = "";
            radioGroupDocumento.SelectedIndex = 0;
            inputNumeroDoc.Text = "";
            inputOrgaoExpedidor.SelectedIndex = 0;
            inputUFEndereco.SelectedIndex = 0;
            inputCPF.Text = "";
            inputEmail.Text = "";
            inputCEP.Text = "";
            inputRua.Text = "";
            inputNumero.Text = "";
            inputBairro.Text = "";
            inputCidade.Text = "";
            inputUFDocumento.SelectedIndex = 0;
            inputComplemento.Text = "";
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
                    XtraMessageBox.Show(ex.Message, "Atenção!",
                    MessageBoxButtons.OK);
                }
            }
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            int flag = 0;
            flag = validarPessoa(flag);

            if(flag == 0) {
                try
                {            
                    if(_operacao == 1)
                    {
                        Pessoa pessoa = new Pessoa()
                        {
                            Nome = inputNome.Text,
                            Sobrenome = inputSobrenome.Text,
                            Nacionalidade = inputNacionalidade.Text,
                            EstadoCivil = inputEstadoCivil.Text,
                            Profissao = inputProfissao.Text,
                            TipoDocumento = radioGroupDocumento.SelectedIndex,
                            NumeroDocumento = inputNumeroDoc.Text,
                            OrgaoExpedidor = inputOrgaoExpedidor.Text,
                            UFEndereco = inputUFEndereco.Text,
                            CPF = inputCPF.Text,
                            Email = inputEmail.Text,
                            CEP = inputCEP.Text,
                            Rua = inputRua.Text,
                            Numero = inputNumero.Text,
                            Bairro = inputBairro.Text,
                            Cidade = inputCidade.Text,
                            UFDocumento = inputUFDocumento.Text,
                            Complemento = inputComplemento.Text
                        };
                        _repositorioPessoa.Criar(pessoa);
                        _pessoa = pessoa;
                    }
                        
                    else if(_operacao == 2)
                    {
                        _pessoa.Nome = inputNome.Text;
                        _pessoa.Sobrenome = inputSobrenome.Text;
                        _pessoa.Nacionalidade = inputNacionalidade.Text;
                        _pessoa.EstadoCivil = inputEstadoCivil.Text;
                        _pessoa.Profissao = inputProfissao.Text;
                        _pessoa.TipoDocumento = radioGroupDocumento.SelectedIndex;
                        _pessoa.NumeroDocumento = inputNumeroDoc.Text;
                        _pessoa.OrgaoExpedidor = inputOrgaoExpedidor.Text;
                        _pessoa.UFEndereco = inputUFEndereco.Text;
                        _pessoa.CPF = inputCPF.Text;
                        _pessoa.Email = inputEmail.Text;
                        _pessoa.CEP = inputCEP.Text;
                        _pessoa.Rua = inputRua.Text;
                        _pessoa.Numero = inputNumero.Text;
                        _pessoa.Bairro = inputBairro.Text;
                        _pessoa.Cidade = inputCidade.Text;
                        _pessoa.UFDocumento = inputUFDocumento.Text;
                        _pessoa.Complemento = inputComplemento.Text;

                        _repositorioPessoa.Atualizar(_pessoa);
                    }

                    XtraMessageBox.Show("Registro gravado!\n", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _operacao = 2;
                    atualizarListaPessoas();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Erro ao inserir Pessoa\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }            
            }
            
        }

        public void atualizarListaPessoas()
        {
            _formListaPessoas.iniciarGrid();
        }

        private int validarPessoa(int flag)
        {          
            //confere se existem campos em branco ou inválidos
            if (inputNome.Text == "")
            {
                XtraMessageBox.Show("Informe o nome!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else
            if (inputSobrenome.Text == "")
            {
                XtraMessageBox.Show("Informe o sobrenome!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else
                if (inputNacionalidade.Text == "")
            {
                XtraMessageBox.Show("Informe a nacionalidade!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else
                if (inputEstadoCivil.Text == "")
            {
                XtraMessageBox.Show("Informe o estado civil!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else
                if (inputProfissao.Text == "")
            {
                XtraMessageBox.Show("Informe a profissao!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else
                if (inputNumeroDoc.Text == "")
            {
                XtraMessageBox.Show("Informe o numero do documento!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else
                if (removerMascara(inputCPF.Text) == "")
            {
                XtraMessageBox.Show("Informe o CPF!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else
                if (validador.validarCPF(inputCPF.Text) == false)
            {
                XtraMessageBox.Show("CPF incorreto!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else
                if (radioGroupDocumento.SelectedIndex == 0)
                if (inputOrgaoExpedidor.Text == "" || inputUFDocumento.Text == "")
                {
                    XtraMessageBox.Show("Informe o complemento do RG!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = 1;
                }
                else
            if (inputEmail.Text == "")
                {
                    XtraMessageBox.Show("Informe o e-mail!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = 1;
                }
                else
            if (removerMascara(inputCEP.Text) == "")
                {
                    XtraMessageBox.Show("Informe o CEP!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = 1;
                }
                else
            if (inputRua.Text == "")
                {
                    XtraMessageBox.Show("Informe a rua!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = 1;
                }
                else
            if (inputBairro.Text == "")
                {
                    XtraMessageBox.Show("Informe o bairro!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = 1;
                }
                else
            if (inputCidade.Text == "")
                {
                    XtraMessageBox.Show("Informe a cidade!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = 1;
                }
                else
            if (inputUFEndereco.Text == "")
                {
                    XtraMessageBox.Show("Informe a UF do endereço!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = 1;
                }
                else
            if (inputNumero.Text == "")
                {
                    XtraMessageBox.Show("Informe o número do endereço!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = 1;
                }

            return flag;
        }

        public string removerMascara(string campoMascara)
        {
            string campoNovo = campoMascara.Replace(".", "").Replace("-", "").Replace("_", "").Replace(" ", "");
                return campoNovo;
        }
    }
}