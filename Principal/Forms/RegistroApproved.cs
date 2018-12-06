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
        ListaApproveds _formListaApproveds;
        private IApprovedService _servicoApproved;
        private IPessoaRepositorio _repositorioPessoa;
        private IEscritorioRepositorio _repositorioEscritorio;
        private IOpportunityRepository _repositorioOpportunity;
        private ITokenPublicoRepositorio _repositorioTokenPublico;
        private ITestemunhaRepositorio _repositorioTestemunha;
        private Domain.Entities.Escritorio _escritorio;
        private Domain.Entities.TokenPublico _token;
        private Domain.Entities.Testemunha _testemunha;

        private Approved _approved;

        private int IDEP;
        private string EPNome;
        private int IDResponsavel;
        private string ResponsavelNome;
        private int IDTestemunha1;
        private string Testemunha1Nome;
        private int IDTestemunha2;
        private string Testemunha2Nome;
        int _operacao;
        bool _documento;

        Dictionary<string, Control> _binds = new Dictionary<string, Control>();
        Validacoes validador = new Validacoes();
        DateTime dataNula = new DateTime(0001, 1, 2, 1, 1, 0);

        //OPERACAO 1 = NOVO, 2 = EDITAR
        public RegistroApproved(Approved approved, int operacao, ListaApproveds formListaApproveds)
        {
            //Altera a cultura para substituir , por . e vice-versa (no caso dos valores monetários)
            System.Globalization.CultureInfo newCulture = (System.Globalization.CultureInfo)System.Globalization.CultureInfo.CurrentCulture.Clone();
            newCulture.NumberFormat.NumberGroupSeparator = ".";
            newCulture.NumberFormat.NumberDecimalSeparator = ",";
            System.Threading.Thread.CurrentThread.CurrentCulture = newCulture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = newCulture;

            _formListaApproveds = formListaApproveds;
            _operacao = operacao;
            _documento = false;
            InitializeComponent();
            this.Text = "Registro de Approval";
            _approved = approved;
            _servicoApproved = AppCore.Container.Resolve<IApprovedService>();
            _repositorioPessoa = AppCore.Container.Resolve<IPessoaRepositorio>();
            _repositorioEscritorio = AppCore.Container.Resolve<IEscritorioRepositorio>();
            _repositorioOpportunity = AppCore.Container.Resolve<IOpportunityRepository>();
            _repositorioTokenPublico = AppCore.Container.Resolve<ITokenPublicoRepositorio>();
            _repositorioTestemunha = AppCore.Container.Resolve<ITestemunhaRepositorio>();
            _escritorio = _repositorioEscritorio.ObterEscritorio();
            _token = _repositorioTokenPublico.ObterToken();
            _testemunha = _repositorioTestemunha.ObterTestemunhas();

            if (_operacao == 1)
            {
                ResetarCampos();
            }

            else if (_operacao == 2)
            {
                this.Dock = DockStyle.Fill;
                IDEP = approved.IdEP;
                IDResponsavel = approved.IdResponsavel;
                IDTestemunha1 = approved.IdTestemunha1;
                IDTestemunha2 = approved.IdTestemunha2;
                inputNomeEP.Text = approved.NomeEP;
                inputNomeResponsavel.Text = approved.NomeResponsavel;
                inputEPID.Text = approved.EPID;
                inputDataAPD.Text = approved.DataApproved.ToString();
                inputTNID.Text = approved.TNID;
                radioGroupPrograma.SelectedIndex = approved.TipoProdutoId;
                inputPaisDestino.Text = approved.PaisDestino;
                inputCidadeDestino.Text = approved.CidadeDestino;
                inputBolsaAuxilio.Text = approved.BolsaAuxilio;
                inputCargaHorariaNumero.Text = approved.CargaHorariaNumeral.ToString();
                inputCargaHorariaExtenso.Text = approved.CargaHorariaExtenso;
                inputAlimentacaoSemana.Text = approved.AlimentacaoDiaTrabalho;
                inputAlimentacaoFimDeSemana.Text = approved.AlimentacaoFimSemana;
                inputDataInicio.Text = approved.DataInicio.ToString();
                inputDataFim.Text = approved.DataFim.ToString();
                inputTrabalhoSabado.Text = approved.TrabalhoSabado;
                inputFeeICX.Text = approved.TaxaDestino;
                inputAcomodacaoProvida.Text = approved.AcomodacaoProvida.ToString();
                inputAcomodacaoCoberta.Text = approved.AcomodacaoCoberta.ToString();
                inputComputador.Text = approved.Computador.ToString();
                inputValorContrato.Text = approved.ValorContratoNumerico.ToString();
                inputValorExtenso.Text = approved.ValorContratoExtenso;
                inputValorParcial.Text = approved.ValorParcialNumerico.ToString();
                inputValorParcialExtenso.Text = approved.ValorParcialExtenso;
                inputDataPagamento.Text = approved.DataPagamento.ToString();
                inputModoPagamento.SelectedIndex = approved.TipoPagamento;
                inputNumeroParcelas.Text = approved.QtdParcelas.ToString();
                inputModoBoleto.Checked = approved.ModoBoleto;
                inputModoCredito.Checked = approved.ModoCartaoCredito;
                inputModoDebito.Checked = approved.ModoCartaoDebito;
                inputModoCheque.Checked = approved.ModoCheque;
                inputModoDeposito.Checked = approved.ModoDeposito;
                inputModoDinheiro.Checked = approved.ModoDinheiro;
                inputModoPagSeguro.Checked = approved.ModoPagSeguro;
                inputModoTransferencia.Checked = approved.ModoTransferencia;
                inputParcela1.Text = approved.Parcela1.ToString();
                inputParcela2.Text = approved.Parcela2.ToString();
                inputParcela3.Text = approved.Parcela3.ToString();
                inputParcela4.Text = approved.Parcela4.ToString();
                inputParcela5.Text = approved.Parcela5.ToString();
                inputParcela6.Text = approved.Parcela6.ToString();
                inputParcela7.Text = approved.Parcela7.ToString();
                inputParcela8.Text = approved.Parcela8.ToString();
                inputParcela9.Text = approved.Parcela9.ToString();
                inputParcela10.Text = approved.Parcela10.ToString();
                inputParcela11.Text = approved.Parcela11.ToString();
                inputParcela12.Text = approved.Parcela12.ToString();
                inputTestemunha1.Text = approved.NomeTestemunha1;
                inputTestemunha2.Text = approved.NomeTestemunha2;
                if (approved.TipoPagamento != 1)
                    mostrarCamposParcelas(false);
                _documento = true;
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
            inputValorParcial.Text = "";
            inputValorParcialExtenso.Text = "";
            resetarModosPagamento();
            exibirCamposParcela(0);
            _documento = false;
            mostrarCamposParcelas(false);
            obterTestemunhas();
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

            if (flag == 0)
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
                            TipoProdutoId = radioGroupPrograma.SelectedIndex,
                            TipoProdutoDescricao = Conversoes.Conversoes.ConverteIntStringTipoProduto(radioGroupPrograma.SelectedIndex),
                            TNID = inputTNID.Text,
                            PaisDestino = inputPaisDestino.Text,
                            CidadeDestino = inputCidadeDestino.Text,
                            DataInicio = inputDataInicio.DateTime,
                            DataFim = inputDataFim.DateTime,
                            CargaHorariaNumeral = Convert.ToInt32(inputCargaHorariaNumero.Value),
                            CargaHorariaExtenso = inputCargaHorariaExtenso.Text,
                            TrabalhoSabado = inputTrabalhoSabado.Text,
                            TaxaDestino = inputFeeICX.Text,
                            BolsaAuxilio = inputBolsaAuxilio.Text,
                            AcomodacaoProvida = inputAcomodacaoProvida.Text,
                            AcomodacaoCoberta = inputAcomodacaoCoberta.Text,
                            AlimentacaoDiaTrabalho = inputAlimentacaoSemana.Text,
                            AlimentacaoFimSemana = inputAlimentacaoFimDeSemana.Text,
                            Computador = inputAcomodacaoProvida.Text,
                            DataApproved = inputDataAPD.DateTime,
                            ValorContratoNumerico = Convert.ToDecimal(inputValorContrato.Text),
                            ValorContratoExtenso = inputValorExtenso.Text,
                            DataPagamento = inputDataPagamento.DateTime,
                            TipoPagamento = inputModoPagamento.SelectedIndex,
                            QtdParcelas = Convert.ToInt32(inputNumeroParcelas.Value),
                            ValorParcialNumerico = Convert.ToDecimal(inputValorParcial.Text),
                            ValorParcialExtenso = inputValorParcialExtenso.Text,
                            ModoBoleto = inputModoBoleto.Checked,
                            ModoCartaoCredito = inputModoCredito.Checked,
                            ModoCartaoDebito = inputModoDebito.Checked,
                            ModoCheque = inputModoCheque.Checked,
                            ModoDeposito = inputModoDeposito.Checked,
                            ModoDinheiro = inputModoDinheiro.Checked,
                            ModoPagSeguro = inputModoPagSeguro.Checked,
                            ModoTransferencia = inputModoTransferencia.Checked,
                            Parcela1 = inputParcela1.DateTime,
                            Parcela2 = inputParcela2.DateTime,
                            Parcela3 = inputParcela3.DateTime,
                            Parcela4 = inputParcela4.DateTime,
                            Parcela5 = inputParcela5.DateTime,
                            Parcela6 = inputParcela6.DateTime,
                            Parcela7 = inputParcela7.DateTime,
                            Parcela8 = inputParcela8.DateTime,
                            Parcela9 = inputParcela9.DateTime,
                            Parcela10 = inputParcela10.DateTime,
                            Parcela11 = inputParcela11.DateTime,
                            Parcela12 = inputParcela12.DateTime,
                            IdTestemunha1 = IDTestemunha1,
                            NomeTestemunha1 = inputTestemunha1.Text,
                            IdTestemunha2 = IDTestemunha2,
                            NomeTestemunha2 = inputTestemunha2.Text
                        };
                        _servicoApproved.Criar(approved);
                        _approved = approved;
                        _documento = true;
                    }
                    else if (_operacao == 2)
                    {
                        _approved.IdEP = IDEP;
                        _approved.NomeEP = inputNomeEP.Text;
                        _approved.IdResponsavel = IDResponsavel;
                        _approved.NomeResponsavel = inputNomeResponsavel.Text;
                        _approved.EPID = inputEPID.Text;
                        _approved.IdPresidente = _escritorio.LCP;
                        _approved.TipoProdutoId = radioGroupPrograma.SelectedIndex;
                        _approved.TipoProdutoDescricao = Conversoes.Conversoes.ConverteIntStringTipoProduto(radioGroupPrograma.SelectedIndex);
                        _approved.TNID = inputTNID.Text;
                        _approved.PaisDestino = inputPaisDestino.Text;
                        _approved.CidadeDestino = inputCidadeDestino.Text;
                        _approved.DataInicio = inputDataInicio.DateTime;
                        _approved.DataFim = inputDataFim.DateTime;
                        _approved.CargaHorariaNumeral = Convert.ToInt32(inputCargaHorariaNumero.Value);
                        _approved.CargaHorariaExtenso = inputCargaHorariaExtenso.Text;
                        _approved.TrabalhoSabado = inputTrabalhoSabado.Text;
                        _approved.TaxaDestino = inputFeeICX.Text;
                        _approved.BolsaAuxilio = inputBolsaAuxilio.Text;
                        _approved.AcomodacaoProvida = inputAcomodacaoProvida.Text;
                        _approved.AcomodacaoCoberta = inputAcomodacaoCoberta.Text;
                        _approved.AlimentacaoDiaTrabalho = inputAlimentacaoSemana.Text;
                        _approved.AlimentacaoFimSemana = inputAlimentacaoFimDeSemana.Text;
                        _approved.Computador = inputAcomodacaoProvida.Text;
                        _approved.DataApproved = inputDataAPD.DateTime;
                        _approved.ValorContratoNumerico = Convert.ToDecimal(inputValorContrato.Text);
                        _approved.ValorContratoExtenso = inputValorExtenso.Text;
                        _approved.DataPagamento = inputDataPagamento.DateTime;
                        _approved.TipoPagamento = inputModoPagamento.SelectedIndex;
                        _approved.QtdParcelas = Convert.ToInt32(inputNumeroParcelas.Value);
                        _approved.ValorParcialNumerico = Convert.ToDecimal(inputValorParcial.Text);
                        _approved.ValorParcialExtenso = inputValorParcialExtenso.Text;
                        _approved.ModoBoleto = inputModoBoleto.Checked;
                        _approved.ModoCartaoCredito = inputModoCredito.Checked;
                        _approved.ModoCartaoDebito = inputModoDebito.Checked;
                        _approved.ModoCheque = inputModoCheque.Checked;
                        _approved.ModoDeposito = inputModoDeposito.Checked;
                        _approved.ModoDinheiro = inputModoDinheiro.Checked;
                        _approved.ModoPagSeguro = inputModoPagSeguro.Checked;
                        _approved.ModoTransferencia = inputModoTransferencia.Checked;
                        _approved.Parcela1 = inputParcela1.DateTime;
                        _approved.Parcela2 = inputParcela2.DateTime;
                        _approved.Parcela3 = inputParcela3.DateTime;
                        _approved.Parcela4 = inputParcela4.DateTime;
                        _approved.Parcela5 = inputParcela5.DateTime;
                        _approved.Parcela6 = inputParcela6.DateTime;
                        _approved.Parcela7 = inputParcela7.DateTime;
                        _approved.Parcela8 = inputParcela8.DateTime;
                        _approved.Parcela9 = inputParcela9.DateTime;
                        _approved.Parcela10 = inputParcela10.DateTime;
                        _approved.Parcela11 = inputParcela11.DateTime;
                        _approved.Parcela12 = inputParcela12.DateTime;
                        _approved.IdTestemunha1 = IDTestemunha1;
                        _approved.NomeTestemunha1 = inputTestemunha1.Text;
                        _approved.IdTestemunha2 = IDTestemunha2;
                        _approved.NomeTestemunha2 = inputTestemunha2.Text;

                        _servicoApproved.Atualizar(_approved);
                    }

                    XtraMessageBox.Show("Registro gravado!\n", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _operacao = 2;
                    _documento = true;
                    atualizarListaApproveds();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Erro ao salvar Approved!\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _documento = false;
                }
            }
            //Fim do Metodo
        }

        private void atualizarListaApproveds()
        {
            var f = Application.OpenForms[nameof(ListaApproveds)];
            if (f != null)
                _formListaApproveds.iniciarGrid();
        }

        private int validarApproved(int flag)
        {
            if (IDEP == 0 || inputNomeEP.Text == "")
            {
                XtraMessageBox.Show("Informe o EP!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else
            if (inputDataAPD.Text == "")
            {
                XtraMessageBox.Show("Informe a data de approved!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else
            if (inputTNID.Text == "")
            {
                XtraMessageBox.Show("Informe a TN ID!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else
            if (inputPaisDestino.Text == "")
            {
                XtraMessageBox.Show("Informe o país de destino!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else
            if (inputCidadeDestino.Text == "")
            {
                XtraMessageBox.Show("Informe a cidade de destino!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else
            if (inputBolsaAuxilio.Text == "")
            {
                XtraMessageBox.Show("Informe o valor da bolsa auxílio ou especifique caso não exista!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else
            if (inputFeeICX.Text == "")
            {
                XtraMessageBox.Show("Informe a fee de ICX!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else
            if (inputCargaHorariaNumero.Text == "")
            {
                XtraMessageBox.Show("Informe a carga horária!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else
            if (inputCargaHorariaExtenso.Text == "")
            {
                XtraMessageBox.Show("Informe o valor por extenso da carga horária!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else
            if (inputAlimentacaoSemana.Text == "")
            {
                XtraMessageBox.Show("Informe se existe alimentação por dia de trabalho!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else
            if (inputAlimentacaoFimDeSemana.Text == "")
            {
                XtraMessageBox.Show("Informe se existe alimentação aos finais de semana!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else
            if (inputDataInicio.Text == "")
            {
                XtraMessageBox.Show("Informe a data de início do intercâmbio!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else
            if (inputDataFim.Text == "")
            {
                XtraMessageBox.Show("Informe a data final do intercâmbio!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else
            if (inputDataFim.DateTime < inputDataInicio.DateTime)
            {
                XtraMessageBox.Show("Erro nas datas de realização!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else
            if ((inputDataFim.DateTime - inputDataInicio.DateTime).TotalDays < 28)
            {
                XtraMessageBox.Show("Intercâmbio de duração menor que 4 semanas não é permido!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else
            if (inputTrabalhoSabado.Text == "")
            {
                XtraMessageBox.Show("Informe se existe trabalho aos sábados!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else
            if (inputAcomodacaoProvida.Text == "")
            {
                XtraMessageBox.Show("Informe se a acomodação é provida!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else
            if (inputAcomodacaoCoberta.Text == "")
            {
                XtraMessageBox.Show("Informe se a acomodação é coberta!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else
            if (inputComputador.Text == "")
            {
                XtraMessageBox.Show("Informe a instituição de trabalho fornece computador!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else
            if (inputValorContrato.Text == "" || inputValorExtenso.Text == "")
            {
                XtraMessageBox.Show("Informe o valor do contrato!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else
            if (inputDataPagamento.Text == "")
            {
                XtraMessageBox.Show("Informe a data de pagamento!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else
            if ((inputModoPagamento.SelectedIndex == 0 || inputModoPagamento.SelectedIndex == 1) && Convert.ToDecimal(inputValorContrato.Text) == 0)
            {
                XtraMessageBox.Show("Informe o valor do contrato corretamente!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else
            if (!verificarSeExisteModoPagamento() && (inputModoPagamento.SelectedIndex == 0 || inputModoPagamento.SelectedIndex == 1))
            {
                XtraMessageBox.Show("Selecione pelo menos uma forma de pagamento!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else
             if (inputModoPagamento.SelectedIndex == 1 && inputNumeroParcelas.Text == "")
            {
                XtraMessageBox.Show("Informe em quantas parcelas o pagamento foi parcelado!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else
             if (inputModoPagamento.SelectedIndex == 1 && (inputValorParcial.Text == "" || inputValorParcialExtenso.Text == ""))
            {
                XtraMessageBox.Show("Informe o valor parcial referente a primeira parcela!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            } // VerificarDatasParcelas
            else
             if (VerificarDatasParcelas(Convert.ToInt32(inputNumeroParcelas.Value)) == false)
            {
                XtraMessageBox.Show("Informe as datas de todas as parcelas!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else if (inputValorContrato.Text == "" || inputValorExtenso.Text == "")
            {
                XtraMessageBox.Show("Informe o valor do contrato!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else
           if (IDTestemunha1 == 0 || IDTestemunha2 == 0)
            {
                XtraMessageBox.Show("Informe as testemunhas do contrato!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else
           if (IDTestemunha1 == IDTestemunha2)
            {
                XtraMessageBox.Show("Informe testemunhas diferentes!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            else
           if (IDTestemunha1 == IDEP || IDTestemunha2 == IDEP)
            {
                XtraMessageBox.Show("EP não pode ser testemunha!", "Cadastro Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }

            else 
            if ((inputDataFim.DateTime - inputDataInicio.DateTime).TotalDays < 42)
            {
                XtraMessageBox.Show("O intercâmbio possui menos que 6 semanas de duração!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return flag;
        }

        private bool verificarSeExisteModoPagamento()
        {
            if (inputModoBoleto.Checked == true || inputModoCredito.Checked == true || inputModoDebito.Checked == true || inputModoCheque.Checked == true ||
                inputModoDeposito.Checked == true || inputModoDinheiro.Checked == true || inputModoPagSeguro.Checked == true || inputModoTransferencia.Checked == true)
                return true;
            return false;
        }

        private void inputNomeEP_ButtonClick(object sender, EventArgs e)
        {
            var EP = sender as DevExpress.XtraEditors.ButtonEdit;
            var pessoas = _repositorioPessoa.ListarTodasPessoas();
            var form = new SelecionarPessoa(pessoas);
            form.ShowDialog(MdiParent);

            if (form.SelectedItem.Id != 0)
            {
                IDEP = form.SelectedItem.Id;
                EPNome = form.SelectedItem.Nome;
                inputNomeEP.Text = form.SelectedItem.Nome + " " + form.SelectedItem.Sobrenome;
            }
        }

        private void inputNomeResponsavel_ButtonClick(object sender, EventArgs e)
        {
            var responsavel = sender as DevExpress.XtraEditors.ButtonEdit;
            var pessoas = _repositorioPessoa.ListarTodasPessoas();
            var form = new SelecionarPessoa(pessoas);
            form.ShowDialog(MdiParent);
            if (form.SelectedItem.Id != 0)
            {
                IDResponsavel = form.SelectedItem.Id;
                ResponsavelNome = form.SelectedItem.Nome;
                inputNomeResponsavel.Text = form.SelectedItem.Nome + " " + form.SelectedItem.Sobrenome;
            }
            else
            {
                IDResponsavel = 0;
                ResponsavelNome = "";
                inputNomeResponsavel.Text = "";
            }
        }

        private void inputTestemunha1_ButtonClick(object sender, EventArgs e)
        {
            var testemunha = sender as DevExpress.XtraEditors.ButtonEdit;
            var pessoas = _repositorioPessoa.ListarTodasPessoas();
            var form = new SelecionarPessoa(pessoas);
            form.ShowDialog(MdiParent);

            if (form.SelectedItem.Id != 0)
            {
                IDTestemunha1 = form.SelectedItem.Id;
                Testemunha1Nome = form.SelectedItem.Nome;
                inputTestemunha1.Text = form.SelectedItem.Nome + " " + form.SelectedItem.Sobrenome;
            }
        }

        private void inputTestemunha2_ButtonClick(object sender, EventArgs e)
        {
            var testemunha = sender as DevExpress.XtraEditors.ButtonEdit;
            var pessoas = _repositorioPessoa.ListarTodasPessoas();
            var form = new SelecionarPessoa(pessoas);
            form.ShowDialog(MdiParent);

            if (form.SelectedItem.Id != 0)
            {
                IDTestemunha2 = form.SelectedItem.Id;
                Testemunha2Nome = form.SelectedItem.Nome;
                inputTestemunha2.Text = form.SelectedItem.Nome + " " + form.SelectedItem.Sobrenome;
            }

        }

        private void botaoPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                this.ExibirFormEspera();
                VagaResumidaBR vaga = new VagaResumidaBR(_repositorioOpportunity.ObterPorId(Convert.ToInt32(inputTNID.Text), _token.Token));
                preencherCampos(vaga);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erro ao buscar vaga!", "Atenção!",
                MessageBoxButtons.OK);
            }
            finally
            {
                this.FecharFormEspera();
            }
        }

        private void preencherCampos(VagaResumidaBR vaga)
        {
            this.inputPaisDestino.Text = vaga.PaisDestino;
            this.inputCidadeDestino.Text = vaga.CidadeDestino;
            this.inputCargaHorariaNumero.Text = vaga.CargaHorariaNumerica.ToString();
            this.inputCargaHorariaExtenso.Text = vaga.CargaHorariaExtenso;
            this.radioGroupPrograma.SelectedIndex = vaga.TipoProdutoId;
            this.inputDataInicio.DateTime = vaga.DataInicio.Date;
            this.inputDataFim.DateTime = vaga.DataFim.Date;
            this.inputTrabalhoSabado.Text = vaga.TrabalhoSabado;
            this.inputAcomodacaoProvida.Text = vaga.AcomodacaoProvida;
            this.inputAcomodacaoCoberta.Text = vaga.AcomodacaoCoberta;
            this.inputBolsaAuxilio.Text = vaga.BolsaAuxilio;
            this.inputAlimentacaoSemana.Text = vaga.AlimentacaoSemana;
            this.inputAlimentacaoFimDeSemana.Text = vaga.AlimentacaoFimSemana;
            this.inputComputador.Text = vaga.Computador;
        }

        private void alterarCargaHorariaNumerica(object sender, EventArgs e)
        {
            inputCargaHorariaExtenso.Text = Conversoes.Conversoes.ConverteNumericoExtenso(Convert.ToInt32(inputCargaHorariaNumero.Text)) + " Horas Semanais";
        }

        private void alterarValorContrato(object sender, EventArgs e)
        {
            inputValorExtenso.Text = Conversoes.Conversoes.EscreverExtenso(Convert.ToDecimal(inputValorContrato.Text), "BRL");

            if (inputModoPagamento.SelectedIndex == 1)
                alterarValorParcial(sender, e);
        }

        private void alterarValorParcialExtenso(object sender, EventArgs e)
        {
            inputValorParcialExtenso.Text = Conversoes.Conversoes.EscreverExtenso(Convert.ToDecimal(inputValorParcial.Text), "BRL");
        }

        private void alterarNumeroParcelas(object sender, EventArgs e)
        {
            if (inputModoPagamento.SelectedIndex == 1)
            {
                mostrarCamposParcelas(true);
                visibilidadeModosPagamento(true);
                alterarValorParcial(sender, e);
            }
            else if (inputModoPagamento.SelectedIndex == 2) {
                mostrarCamposParcelas(false);
                inputValorContrato.Text = "0";
                inputValorParcial.Text = "0";
                resetarModosPagamento();
                visibilidadeModosPagamento(false);
            }
            else if (inputModoPagamento.SelectedIndex == 0)
            {
                mostrarCamposParcelas(false);
                visibilidadeModosPagamento(true);
            }
        }

        private void visibilidadeModosPagamento(bool visibilidade)
        {
            inputModoBoleto.Visible = visibilidade;
            inputModoCredito.Visible = visibilidade;
            inputModoDebito.Visible = visibilidade;
            inputModoCheque.Visible = visibilidade;
            inputModoDeposito.Visible = visibilidade;
            inputModoDinheiro.Visible = visibilidade;
            inputModoPagSeguro.Visible = visibilidade;
            inputModoTransferencia.Visible = visibilidade;
        }

        private void resetarModosPagamento() {
            inputModoBoleto.Checked = false;
            inputModoCredito.Checked = false;
            inputModoDebito.Checked = false;
            inputModoCheque.Checked = false;
            inputModoDeposito.Checked = false;
            inputModoDinheiro.Checked = false;
            inputModoPagSeguro.Checked = false;
            inputModoTransferencia.Checked = false;
        }

        private void alterarValorParcial(object sender, EventArgs e)
        {
            decimal valorContrato = Convert.ToDecimal(inputValorContrato.Text);
            if (valorContrato > 0 && Convert.ToInt32(inputNumeroParcelas.Value) > 0)
            {
                valorContrato = valorContrato / Convert.ToInt32(inputNumeroParcelas.Value);
                inputValorParcial.Text = valorContrato.ToString();
                exibirCamposParcela(Convert.ToInt32(inputNumeroParcelas.Value));
            }
        }



        private void mostrarCamposParcelas(bool flag)
        {
            labelControlNumeroParcelas.Visible = flag;
            inputNumeroParcelas.Visible = flag;
            labelControlValorParcial.Visible = flag;
            inputValorParcial.Visible = flag;
            labelControlValorParcialExtenso.Visible = flag;
            inputValorParcialExtenso.Visible = flag;

            if(flag == true)
            {
                exibirCamposParcela(Convert.ToInt32(inputNumeroParcelas.Value.ToString()));
            }else
            {
                exibirCamposParcela(0);
            }

        }

        private void atribuirTestemunhas(object sender, EventArgs e)
        {
            obterTestemunhas();
        }

        private void obterTestemunhas()
        {
            int tipoProduto = this.radioGroupPrograma.SelectedIndex;

            try
            {
                if (tipoProduto == 0)
                {
                    IDTestemunha1 = _testemunha.IdTestemunha1GV;
                    IDTestemunha2 = _testemunha.IdTestemunha2GV;
                    inputTestemunha1.Text = _testemunha.NomeTestemunha1GV;
                    inputTestemunha2.Text = _testemunha.NomeTestemunha2GV;
                }
                else if (tipoProduto == 1)
                {
                    IDTestemunha1 = _testemunha.IdTestemunha1GE;
                    IDTestemunha2 = _testemunha.IdTestemunha2GE;
                    inputTestemunha1.Text = _testemunha.NomeTestemunha1GE;
                    inputTestemunha2.Text = _testemunha.NomeTestemunha2GE;
                }
                else if (tipoProduto == 2)
                {
                    IDTestemunha1 = _testemunha.IdTestemunha1GT;
                    IDTestemunha2 = _testemunha.IdTestemunha2GT;
                    inputTestemunha1.Text = _testemunha.NomeTestemunha1GT;
                    inputTestemunha2.Text = _testemunha.NomeTestemunha2GT;
                }
            }
            catch (Exception ex)
            {
            }

        }

        private void botaoContratoText_Click(object sender, EventArgs e)
        {
            try
            {
                validarNovoApproved();
                if (_documento == true)
                {
                    this.ExibirFormEspera();
                    var f = Application.OpenForms[nameof(ContratoTrabalhoOGX)];
                    if (f != null)
                        f.Close();
                    var formEdit = new ContratoTrabalhoOGX(_approved, 1) { MdiParent = this.MdiParent };
                    formEdit.Show();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erro ao carregar documento! Verifique se todas as informações estão preenchidas\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _documento = false;
            }
            finally
            {
                this.FecharFormEspera();
            }

        }

        private void botaoContratoPDF_Click(object sender, EventArgs e)
        {
            try
            {
                validarNovoApproved();
                if (_documento == true)
                {
                    this.ExibirFormEspera();
                    var f = Application.OpenForms[nameof(ContratoTrabalhoOGX)];
                    if (f != null)
                        f.Close();
                    var formEdit = new ContratoTrabalhoOGX(_approved, 2) { MdiParent = this.MdiParent };
                    formEdit.Show();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erro ao carregar documento! Verifique se todas as informações estão preenchidas\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _documento = false;
            }
            finally
            {
                this.FecharFormEspera();
            }
        }

        private void botaoTermoText_Click(object sender, EventArgs e)
        {
            try
            {
                validarNovoApproved();
                if (_documento == true)
                {
                    this.ExibirFormEspera();
                    var f = Application.OpenForms[nameof(TermoVoluntario)];
                    if (f != null)
                        f.Close();
                    var formEdit = new TermoVoluntario(_approved, 1) { MdiParent = this.MdiParent };
                    formEdit.Show();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erro ao carregar documento! Verifique se todas as informações estão preenchidas\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _documento = false;
            }
            finally
            {
                this.FecharFormEspera();
            }
        }

        private void botaoTermoPDF_Click(object sender, EventArgs e)
        {
            try
            {
                validarNovoApproved();
                if (_documento == true)
                {
                    this.ExibirFormEspera();
                    var f = Application.OpenForms[nameof(TermoVoluntario)];
                    if (f != null)
                        f.Close();
                    var formEdit = new TermoVoluntario(_approved, 2) { MdiParent = this.MdiParent };
                    formEdit.Show();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erro ao carregar documento! Verifique se todas as informações estão preenchidas\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _documento = false;
            }
            finally
            {
                this.FecharFormEspera();
            }
        }

        private void validarNovoApproved()
        {
            if (_documento == false)
            {
                XtraMessageBox.Show("Salve o registro antes de prosseguir!", "Ação não permitida!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exibirCamposParcela(int quantosExibir)
        {
            labelValorNaoParcelado.Visible = true;

            if (quantosExibir >= 1)
            {
                labelValorNaoParcelado.Visible = false;
                inputParcela1.Visible = true;
                inputLabelParcela1.Visible = true;
            }
            else
            {
                inputParcela1.Text = "";
                inputParcela1.Visible = false;
                inputLabelParcela1.Visible = false;
            }

            if (quantosExibir >= 2)
            {
                inputParcela2.Visible = true;
                inputLabelParcela2.Visible = true;
            }
            else
            {
                inputParcela2.Text = "";
                inputParcela2.Visible = false;
                inputLabelParcela2.Visible = false;
            }

            if (quantosExibir >= 3)
            {                
                inputParcela3.Visible = true;
                inputLabelParcela3.Visible = true;
            }
            else
            {
                inputParcela3.Text = "";
                inputParcela3.Visible = false;
                inputLabelParcela3.Visible = false;
            }

            if (quantosExibir >= 4)
            {
                inputParcela4.Visible = true;
                inputLabelParcela4.Visible = true;
            }
            else
            {
                inputParcela4.Text = "";
                inputParcela4.Visible = false;
                inputLabelParcela4.Visible = false;
            }

            if (quantosExibir >= 5)
            {
                inputParcela5.Visible = true;
                inputLabelParcela5.Visible = true;
            }
            else
            {
                inputParcela5.Text = "";
                inputParcela5.Visible = false;
                inputLabelParcela5.Visible = false;
            }

            if (quantosExibir >= 6)
            {
                inputParcela6.Visible = true;
                inputLabelParcela6.Visible = true;
            }
            else
            {
                inputParcela6.Text = "";
                inputParcela6.Visible = false;
                inputLabelParcela6.Visible = false;
            }

            if (quantosExibir >= 7)
            {
                inputParcela7.Visible = true;
                inputLabelParcela7.Visible = true;
            }
            else
            {
                inputParcela7.Text = "";
                inputParcela7.Visible = false;
                inputLabelParcela7.Visible = false;
            }

            if (quantosExibir >= 8)
            {
                inputParcela8.Visible = true;
                inputLabelParcela8.Visible = true;
            }
            else
            {
                inputParcela8.Text = "";
                inputParcela8.Visible = false;
                inputLabelParcela8.Visible = false;
            }

            if (quantosExibir >= 9)
            {
                inputParcela9.Visible = true;
                inputLabelParcela9.Visible = true;
            }
            else
            {
                inputParcela9.Text = "";
                inputParcela9.Visible = false;
                inputLabelParcela9.Visible = false;
            }

            if (quantosExibir >= 10)
            {
                inputParcela10.Visible = true;
                inputLabelParcela10.Visible = true;
            }
            else
            {
                inputParcela10.Text = "";
                inputParcela10.Visible = false;
                inputLabelParcela10.Visible = false;
            }

            if (quantosExibir >= 11)
            {
                inputParcela11.Visible = true;
                inputLabelParcela11.Visible = true;
            }
            else
            {
                inputParcela11.Text = "";
                inputParcela11.Visible = false;
                inputLabelParcela11.Visible = false;
            }

            if (quantosExibir >= 12)
            {
                inputParcela12.Visible = true;
                inputLabelParcela12.Visible = true;
            }
            else
            {
                inputParcela12.Text = "";
                inputParcela12.Visible = false;
                inputLabelParcela12.Visible = false;
            }
        }

        private bool VerificarDatasParcelas(int nParcelas)
        {
            if (inputModoPagamento.SelectedIndex == 1)
                for (int i = 1; i <= nParcelas; i++)
                {
                    if (i == 1)
                        if (inputParcela1.DateTime < dataNula)
                            return false;
                    if (i == 2)
                        if (inputParcela2.DateTime < dataNula)
                            return false;
                    if (i == 3)
                        if (inputParcela3.DateTime < dataNula)
                            return false;
                    if (i == 4)
                        if (inputParcela4.DateTime < dataNula)
                            return false;
                    if (i == 5)
                        if (inputParcela5.DateTime < dataNula)
                            return false;
                    if (i == 6)
                        if (inputParcela6.DateTime < dataNula)
                            return false;
                    if (i == 7)
                        if (inputParcela7.DateTime < dataNula)
                            return false;
                    if (i == 8)
                        if (inputParcela8.DateTime < dataNula)
                            return false;
                    if (i == 9)
                        if (inputParcela9.DateTime < dataNula)
                            return false;
                    if (i == 10)
                        if (inputParcela10.DateTime < dataNula)
                            return false;
                    if (i == 11)
                        if (inputParcela11.DateTime < dataNula)
                            return false;
                    if (i == 12)
                        if (inputParcela12.DateTime < dataNula)
                            return false;
                }
            return true;
        }

    }
}

            //this.inputNomeEP.ButtonClick += inputNomeEP_ButtonClick;
            //this.inputNomeResponsavel.ButtonClick += inputNomeResponsavel_ButtonClick;
            //this.inputTestemunha1.ButtonClick += inputTestemunha1_ButtonClick;
            //this.inputTestemunha2.ButtonClick += inputTestemunha2_ButtonClick;