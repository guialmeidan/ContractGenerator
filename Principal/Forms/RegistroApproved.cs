using DevExpress.XtraEditors;
using Principal.Domain.Entities;
using Principal.Domain.Repositories;
using Principal.Domain.Services;
using Principal.WinApp;
using Principal.Conversoes;
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
    public partial class RegistroApproved : XtraForm
    {
        private IApprovedService _servicoApproved;
        private IPessoaRepositorio _repositorioPessoa;
        private IEscritorioRepositorio _repositorioEscritorio;
        private Domain.Entities.Escritorio _escritorio;
        private Approved _approved;
        private int IDEP;
        private string EPNome;
        private int IDResponsavel;
        private string ResponsavelNome;
        private int IDTestemunha1;
        private string Testemunha1Nome;
        private int IDTestemunha2;
        private string Testemunha2Nome;
        Dictionary<string, Control> _binds = new Dictionary<string, Control>();
        Validacoes validador = new Validacoes();
        int _operacao;

        //OPERACAO 1 = NOVO, 2 = EDITAR
        public RegistroApproved(Approved approved, int operacao)
        {
            _operacao = operacao;
            InitializeComponent();
            this.Text = "Registro de Approved";
            _approved = approved;
            _servicoApproved = AppCore.Container.Resolve<IApprovedService>();
            _repositorioPessoa = AppCore.Container.Resolve<IPessoaRepositorio>();
            _repositorioEscritorio = AppCore.Container.Resolve<IEscritorioRepositorio>();
            _escritorio = _repositorioEscritorio.ObterEscritorio();

            if (_operacao == 1)
            {
                ResetarCampos();
            }

            else if (_operacao == 2)
            {
                this.Dock = DockStyle.Fill;
                inputNomeEP.Text = approved.NomeEP;
                inputNomeResponsavel.Text = approved.NomeResponsavel;
                inputEPID.Text = approved.EPID;
                inputDataAPD.Text = approved.DataApproved.ToString();
                inputTNID.Text = approved.TNID;
                radioGroupPrograma.SelectedIndex = Conversoes.Conversoes.converteStringIntTipoProduto(approved.TipoProduto);
                inputPaisDestino.Text = approved.PaisDestino;
                inputCidadeDestino.Text = approved.CidadeDestino;
                inputBolsaAuxilio.Text = approved.BolsaAuxilio;
                inputCargaHorariaNumero.Text = approved.CargaHorariaNumeral.ToString();
                inputCargaHorariaExtenso.Text = approved.CargaHorariaExtenso;
                inputAlimentacaoSemana.Text = approved.AlimentacaoDiaTrabalho;
                inputAlimentacaoFimDeSemana.Text = approved.AlimentacaoFimSemana;
                inputDataInicio.Text = approved.DataInicio.ToString();
                inputDataFim.Text = approved.DataFim.ToString();
                inputFeeICX.Text = approved.TaxaDestino;
                inputAcomodacaoProvida.Text = approved.AcomodacaoProvida.ToString();
                inputAcomodacaoCoberta.Text = approved.AcomodacaoCoberta.ToString();
                inputComputador.Text = approved.Computador.ToString();
                inputValorContrato.Text = approved.ValorContratoNumerico.ToString();
                inputValorExtenso.Text = approved.ValorContratoExtenso;
                inputDataPagamento.Text = approved.DataPagamento.ToString();
                inputModoPagamento.Text = approved.TipoPagamento.ToString();
                inputNumeroParcelas.Text = approved.QtdParcelas.ToString();
                inputModoBoleto.Checked = approved.ModoBoleto;
                inputModoCredito.Checked = approved.ModoCartaoCredito;
                inputModoDebito.Checked = approved.ModoCartaoDebito;
                inputModoCheque.Checked = approved.ModoCheque;
                inputModoDeposito.Checked = approved.ModoDeposito;
                inputModoDinheiro.Checked = approved.ModoDinheiro;
                inputModoPagSeguro.Checked = approved.ModoPagSeguro;
                inputModoTransferencia.Checked = approved.ModoTransferencia;
                inputTestemunha1.Text = approved.NomeTestemunha1;
                inputTestemunha2.Text = approved.NomeTestemunha2;
            }
        }

        private void ResetarCampos()
        {
            inputNomeEP.Text = "";
            inputNomeResponsavel.Text = "";
            inputEPID.Text = "";
            inputDataAPD.Text = "";
            inputTNID.Text = "";
            radioGroupPrograma.SelectedIndex = 0;
            inputModoPagamento.SelectedIndex = 0;
            inputPaisDestino.Text = "";
            inputCidadeDestino.Text = "";
            inputBolsaAuxilio.Text = "";
            inputCargaHorariaNumero.Text = "";
            inputCargaHorariaExtenso.Text = "";
            inputAlimentacaoSemana.Text = "";
            inputAlimentacaoFimDeSemana.Text = "";
            inputDataInicio.Text = "";
            inputDataFim.Text = "";
            inputFeeICX.Text = "";
            inputAcomodacaoProvida.Text = "";
            inputAcomodacaoCoberta.Text = "";
            inputComputador.Text = "";
            inputValorContrato.Text = "";
            inputValorExtenso.Text = "";
            inputTrabalhoSabado.Text = "";
            inputDataPagamento.Text = "";
            inputModoPagamento.Text = "";
            inputNumeroParcelas.Text = "";
            inputModoBoleto.Checked = false;
            inputModoCredito.Checked = false;
            inputModoDebito.Checked = false;
            inputModoCheque.Checked = false;
            inputModoDeposito.Checked = false;
            inputModoDinheiro.Checked = false;
            inputModoPagSeguro.Checked = false;
            inputModoTransferencia.Checked = false;
            inputTestemunha1.Text = "";
            inputTestemunha2.Text = "";
        }

        private void botaoResetar_Click(object sender, EventArgs e)
        {
            ResetarCampos();
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            //Inicio do Metodo
            int flag = 0;
            flag = validarApproved(flag);

            if(flag == 0)
            {
                try
                {
                    if (_operacao == 1)
                    {
                        Approved approved = new Approved()
                        {
                            IdEP = IDEP,
                            NomeEP = inputNomeEP.Text,
                            IdResponsavel = IDResponsavel,
                            NomeResponsavel = inputNomeResponsavel.Text,
                            EPID = inputEPID.Text,
                            IdPresidente = _escritorio.LCP,
                            TNID = inputTNID.Text,
                            TipoProduto = Conversoes.Conversoes.converteIntStringTipoProduto(radioGroupPrograma.SelectedIndex),
                            PaisDestino = inputPaisDestino.Text,
                            CidadeDestino = inputCidadeDestino.Text,
                            DataInicio = inputDataInicio.DateTime,
                            DataFim = inputDataFim.DateTime,
                            CargaHorariaNumeral = Convert.ToInt32(inputCargaHorariaNumero.Value),
                            CargaHorariaExtenso = inputCargaHorariaExtenso.Text,
                            TrabalhoSabado = Conversoes.Conversoes.convertePortuguesBool(inputTrabalhoSabado.Text),
                            TaxaDestino = inputFeeICX.Text,
                            BolsaAuxilio = inputBolsaAuxilio.Text,
                            AcomodacaoProvida = Conversoes.Conversoes.convertePortuguesBool(inputAcomodacaoProvida.Text),
                            AcomodacaoCoberta = Conversoes.Conversoes.convertePortuguesBool(inputAcomodacaoCoberta.Text),
                            AlimentacaoDiaTrabalho = inputAlimentacaoSemana.Text,
                            AlimentacaoFimSemana = inputAlimentacaoFimDeSemana.Text,
                            Computador = Conversoes.Conversoes.convertePortuguesBool(inputAcomodacaoProvida.Text),
                            DataApproved = inputDataAPD.DateTime,
                            ValorContratoNumerico = Convert.ToDecimal(inputValorContrato.Text),
                            ValorContratoExtenso = inputValorContrato.Text,
                            DataPagamento = inputDataPagamento.DateTime,
                            TipoPagamento = inputModoPagamento.SelectedIndex,
                            QtdParcelas = Convert.ToInt32(inputNumeroParcelas.Value),
                            ModoBoleto = inputModoBoleto.Checked,
                            ModoCartaoCredito = inputModoCredito.Checked,
                            ModoCartaoDebito = inputModoDebito.Checked,
                            ModoCheque = inputModoCheque.Checked,
                            ModoDeposito = inputModoDeposito.Checked,
                            ModoDinheiro = inputModoDinheiro.Checked,
                            ModoPagSeguro = inputModoPagSeguro.Checked,
                            ModoTransferencia = inputModoTransferencia.Checked,
                            IdTestemunha1 = IDTestemunha1,
                            NomeTestemunha1 = inputTestemunha1.Text,
                            IdTestemunha2 = IDTestemunha2,
                            NomeTestemunha2 = inputTestemunha2.Text
                        };
                        _servicoApproved.Criar(approved);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar Approved\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //Fim do Metodo
        }

        private int validarApproved(int flag)
        {
            return 0;
        }

        private void inputNomeEP_ButtonClick(object sender, EventArgs e)
        {
            var EP = sender as DevExpress.XtraEditors.ButtonEdit;
            var pessoas = _repositorioPessoa.ListarTodasPessoas();
            var form = new SelecionarPessoa(pessoas);
            form.ShowDialog(MdiParent);
            IDEP = form.SelectedItem.Id;
            EPNome = form.SelectedItem.Nome;
            inputNomeEP.Text = form.SelectedItem.Nome + " " + form.SelectedItem.Sobrenome;
        }

        private void inputNomeResponsavel_ButtonClick(object sender, EventArgs e)
        {
            var responsavel = sender as DevExpress.XtraEditors.ButtonEdit;
            var pessoas = _repositorioPessoa.ListarTodasPessoas();
            var form = new SelecionarPessoa(pessoas);
            form.ShowDialog(MdiParent);
            IDResponsavel = form.SelectedItem.Id;
            ResponsavelNome = form.SelectedItem.Nome;
            inputNomeResponsavel.Text = form.SelectedItem.Nome + " " + form.SelectedItem.Sobrenome;
        }

        private void inputTestemunha1_ButtonClick(object sender, EventArgs e)
        {
            var testemunha = sender as DevExpress.XtraEditors.ButtonEdit;
            var pessoas = _repositorioPessoa.ListarTodasPessoas();
            var form = new SelecionarPessoa(pessoas);
            form.ShowDialog(MdiParent);
            IDTestemunha1 = form.SelectedItem.Id;
            Testemunha1Nome = form.SelectedItem.Nome;
            inputTestemunha1.Text = form.SelectedItem.Nome + " " + form.SelectedItem.Sobrenome;
        }

        private void inputTestemunha2_ButtonClick(object sender, EventArgs e)
        {
            var testemunha = sender as DevExpress.XtraEditors.ButtonEdit;
            var pessoas = _repositorioPessoa.ListarTodasPessoas();
            var form = new SelecionarPessoa(pessoas);
            form.ShowDialog(MdiParent);
            IDTestemunha2 = form.SelectedItem.Id;
            Testemunha2Nome = form.SelectedItem.Nome;
            inputTestemunha2.Text = form.SelectedItem.Nome + " " + form.SelectedItem.Sobrenome;
        }
    }
}

            //this.inputNomeEP.ButtonClick += inputNomeEP_ButtonClick;
            //this.inputNomeResponsavel.ButtonClick += inputNomeResponsavel_ButtonClick;
            //this.inputTestemunha1.ButtonClick += inputTestemunha1_ButtonClick;
            //this.inputTestemunha2.ButtonClick += inputTestemunha2_ButtonClick;