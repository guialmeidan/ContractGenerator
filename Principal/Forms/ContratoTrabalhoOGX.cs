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
using DevExpress.Office.Utils;
using DevExpress.XtraRichEdit.API.Native;
using Principal.Domain.Entities;
using Principal.Domain.Repositories;
using Principal.WinApp;
using Unity;

namespace Principal.Forms
{
    public partial class ContratoTrabalhoOGX : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private IPessoaRepositorio _repositorioPessoa;
        private IEscritorioRepositorio _repositorioEscritorio;
        private ITestemunhaRepositorio _repositorioTestemunha;
        private IDiretorioArmazenamentoRepositorio _repositorioDiretorioArmazenamento;
        private string _caminhoArquivo;

        private Domain.Entities.Escritorio _escritorio;
        private Domain.Entities.Testemunha _testemunha;
        private Domain.Entities.Approved _approved;
        private Domain.Pessoa _pessoaLCP;
        private Domain.Pessoa _pessoaEP;
        private Domain.Pessoa _pessoaResponsavel;
        private Domain.Pessoa _pessoaTestemunha1;
        private Domain.Pessoa _pessoaTestemunha2;
        private Domain.Entities.DiretorioArmazenamento _diretorioArmazenamento;

        // modelo 1 = texto, modelo 2 = PDF
        public ContratoTrabalhoOGX(Approved approved, int modeloDocumento)
        {
            //Altera a cultura para substituir , por . e vice-versa (no caso dos valores monetários)
            System.Globalization.CultureInfo newCulture = (System.Globalization.CultureInfo)System.Globalization.CultureInfo.CurrentCulture.Clone();
            newCulture.NumberFormat.NumberGroupSeparator = ".";
            newCulture.NumberFormat.NumberDecimalSeparator = ",";
            System.Threading.Thread.CurrentThread.CurrentCulture = newCulture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = newCulture;

            InitializeComponent();

            _repositorioPessoa = AppCore.Container.Resolve<IPessoaRepositorio>();
            _repositorioEscritorio = AppCore.Container.Resolve<IEscritorioRepositorio>();
            _repositorioTestemunha = AppCore.Container.Resolve<ITestemunhaRepositorio>();
            _repositorioDiretorioArmazenamento = AppCore.Container.Resolve<IDiretorioArmazenamentoRepositorio>();

            _escritorio = _repositorioEscritorio.ObterEscritorio();
            _approved = approved;
            this.Text = setarNomeDocumento();
            _pessoaLCP = _repositorioPessoa.SelecionarPorId(_escritorio.LCP);
            _pessoaEP = _repositorioPessoa.SelecionarPorId(approved.IdEP);
            _pessoaResponsavel = _repositorioPessoa.SelecionarPorId(approved.IdResponsavel);
            _pessoaTestemunha1 = _repositorioPessoa.SelecionarPorId(approved.IdTestemunha1);
            _pessoaTestemunha2 = _repositorioPessoa.SelecionarPorId(approved.IdTestemunha2);
            _diretorioArmazenamento = _repositorioDiretorioArmazenamento.ObterCaminho();
            _caminhoArquivo = _diretorioArmazenamento.Caminho;
            CarregarDocumento();
            PreencherDocumento(modeloDocumento);
        }

        private string setarNomeDocumento()
        {
            if (_approved.EPID != "")
                return _approved.EPID + " - " + _approved.NomeEP + " - " + _approved.TNID + " - Contrato";
            else return _approved.NomeEP + " - " + _approved.TNID + " - Contrato";
        }

        private void PreencherDocumento(int modeloDocumento)
        {
            richTextBox.Document.ReplaceAll("<<nomeEPCompleto>>", _pessoaEP.Nome + " " + _pessoaEP.Sobrenome, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<nacionalidadeEP>>", _pessoaEP.Nacionalidade, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<estadoCivilEP>>", _pessoaEP.EstadoCivil, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<profissaoEP>>", _pessoaEP.Profissao, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<dadosCompletoDocumento>>", Conversoes.Conversoes.retornarStringDocumentoCompleto(_pessoaEP), SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<numeroDocumentoEP>>", _pessoaEP.NumeroDocumento, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<CPFEP>>", Conversoes.Conversoes.retornarStringCPF(_pessoaEP.CPF), SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<emailEP>>", _pessoaEP.Email, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<ruaEP>>", _pessoaEP.Rua, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<numeroEP>>", _pessoaEP.Numero, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<complementoEP>>", Conversoes.Conversoes.retornarComplemento(_pessoaEP.Complemento), SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<bairroEP>>", _pessoaEP.Bairro, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<CEPEP>>", _pessoaEP.CEP, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<cidadeEP>>", _pessoaEP.Cidade, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<estadoEP>>", _pessoaEP.UFEndereco, SearchOptions.CaseSensitive);

            if (_pessoaResponsavel != null)
                richTextBox.Document.ReplaceAll("<<dadosResponsavel>>", Conversoes.Conversoes.retornarStringCompletaResponsavel(_pessoaResponsavel), SearchOptions.CaseSensitive);
            else richTextBox.Document.ReplaceAll("<<dadosResponsavel>>", "", SearchOptions.CaseSensitive);

            richTextBox.Document.ReplaceAll("<<nomeAIESEC>>", _escritorio.Nome, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<CNPJAIESEC>>", _escritorio.CNPJ, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<ruaAIESEC>>", _escritorio.Rua, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<numeroAIESEC>>", _escritorio.Numero, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<complementoAIESEC>>", Conversoes.Conversoes.retornarComplemento(_escritorio.Complemento), SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<bairroAIESEC>>", _escritorio.Bairro, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<CEPAIESEC>>", _escritorio.CEP, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<cidadeAIESEC>>", _escritorio.Cidade, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<UFAIESEC>>", _escritorio.UF, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<nomeLCP>>", _pessoaLCP.Nome + " " + _pessoaLCP.Sobrenome, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<dadosCompletoDocumentoLCP>>", Conversoes.Conversoes.retornarStringDocumentoCompleto(_pessoaLCP), SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<CPFLCP>>", _pessoaLCP.CPF, SearchOptions.CaseSensitive);

            richTextBox.Document.ReplaceAll("<<tipoPrograma>>", Conversoes.Conversoes.ConverteIntStringTipoProduto(_approved.TipoProdutoId), SearchOptions.CaseSensitive);

            richTextBox.Document.ReplaceAll("<<TNID>>", _approved.TNID, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<paisDestino>>", _approved.PaisDestino, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<cidadeDestino>>", _approved.CidadeDestino, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<dataInicio>>", RetornaDiaFormatado(_approved.DataInicio), SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<dataFim>>", RetornaDiaFormatado(_approved.DataFim), SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<cargaHoraria>>", _approved.CargaHorariaNumeral.ToString() + " (" + _approved.CargaHorariaExtenso + ")", SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<taxaICX>>", _approved.TaxaDestino, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<bolsaAuxilio>>", _approved.BolsaAuxilio, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<alimentacaoDiasTrabalho>>", _approved.AlimentacaoDiaTrabalho, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<alimentacaoFimSemana>>", _approved.AlimentacaoFimSemana, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<acomodacaoProvida>>", _approved.AcomodacaoProvida, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<acomodacaoCoberta>>", _approved.AcomodacaoCoberta, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<computador>>", _approved.Computador, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<trabalhoSabado>>", _approved.TrabalhoSabado, SearchOptions.CaseSensitive);

            richTextBox.Document.ReplaceAll("<<valorContratoNumerico>>", _approved.ValorContratoNumerico.ToString("n2"), SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<valorContratoExtenso>>", _approved.ValorContratoExtenso, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<tipoPagamento>>", Conversoes.Conversoes.retornarTipoPagamento(_approved), SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<modosPagamento>>", Conversoes.Conversoes.retornarModosPagamento(_approved), SearchOptions.CaseSensitive);

            richTextBox.Document.ReplaceAll("<<diaPagamento>>", RetornaDiaFormatado(_approved.DataPagamento), SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<condicaoPagamento>>", obterCondicaoPagamento(), SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<datasParcelas>>", obterDatasParcelas(), SearchOptions.CaseSensitive);

            richTextBox.Document.ReplaceAll("<<estadoCompletoAIESEC>>", _escritorio.UFCompleto, SearchOptions.CaseSensitive);

            richTextBox.Document.ReplaceAll("<<diaApproved>>", _approved.DataApproved.Day.ToString("D2"), SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<mesExtensoApproved>>", Conversoes.Conversoes.retornarMesExtenso(_approved.DataApproved.Month), SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<anoApproved>>", _approved.DataApproved.Year.ToString(), SearchOptions.CaseSensitive);

            richTextBox.Document.ReplaceAll("<<nomeTestemunha1>>", _pessoaTestemunha1.Nome + " " + _pessoaTestemunha1.Sobrenome, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<CPFTestemunha1>>", _pessoaTestemunha1.CPF, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<RGTestemunha1>>", _pessoaTestemunha1.NumeroDocumento, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<orgaoExpedidorTestemunha1>>", _pessoaTestemunha1.OrgaoExpedidor + "/" + _pessoaTestemunha1.UFDocumento, SearchOptions.CaseSensitive);

            richTextBox.Document.ReplaceAll("<<nomeTestemunha2>>", _pessoaTestemunha2.Nome + " " + _pessoaTestemunha2.Sobrenome, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<CPFTestemunha2>>", _pessoaTestemunha2.CPF, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<RGTestemunha2>>", _pessoaTestemunha2.NumeroDocumento, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<orgaoExpedidorTestemunha2>>", _pessoaTestemunha2.OrgaoExpedidor + "/" + _pessoaTestemunha2.UFDocumento, SearchOptions.CaseSensitive);


            richTextBox.Options.DocumentSaveOptions.CurrentFileName = setarNomeDocumento();

            if (modeloDocumento == 2)
            {
                try
                {
                    _caminhoArquivo += "\\" + setarNomeDocumento() + ".pdf";
                    richTextBox.Options.DocumentSaveOptions.CurrentFileName = setarNomeDocumento();
                    richTextBox.ExportToPdf(_caminhoArquivo);
                    System.Diagnostics.Process.Start(_caminhoArquivo);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Erro ao abrir PDF, verifique se o arquivo já está aberto!\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private string RetornaDiaFormatado(DateTime data)
        {
            return data.Date.Day.ToString("D2") + "/" + data.Date.Month.ToString("D2") + "/" + data.Date.Year.ToString("D2");
        }

        private string obterDatasParcelas()
        {
            DateTime dataNula = new DateTime(0001, 1, 2, 1, 1, 0);
            string parcelas = "";
            int numeroParcelas = _approved.QtdParcelas;

            if (_approved.TipoPagamento == 2)
                return "Isento";
            else if (_approved.TipoPagamento == 0)
                return "Pagamento à vista";
            else if (_approved.TipoPagamento == 1 && numeroParcelas >= 2)
            {
                if (_approved.Parcela1 > dataNula)
                {
                    parcelas += RetornaDiaFormatado(_approved.Parcela1);
                }
                if (_approved.Parcela2 > dataNula)
                {
                    parcelas += "; " + RetornaDiaFormatado(_approved.Parcela2);
                }
                if(_approved.Parcela3 > dataNula)
                {
                    parcelas += "; "+ RetornaDiaFormatado(_approved.Parcela3);
                }
                if(_approved.Parcela4 > dataNula)
                {
                    parcelas += "; " + RetornaDiaFormatado(_approved.Parcela4);
                }
                if (_approved.Parcela5 > dataNula)
                {
                    parcelas += "; " + RetornaDiaFormatado(_approved.Parcela5);
                }
                if (_approved.Parcela6 > dataNula)
                {
                    parcelas += "; " + RetornaDiaFormatado(_approved.Parcela6);
                }
                if (_approved.Parcela7 > dataNula)
                {
                    parcelas += "; " + RetornaDiaFormatado(_approved.Parcela7);
                }
                if (_approved.Parcela8 > dataNula)
                {
                    parcelas += "; " + RetornaDiaFormatado(_approved.Parcela8);
                }
                if (_approved.Parcela9 > dataNula)
                {
                    parcelas += "; " + RetornaDiaFormatado(_approved.Parcela9);
                }
                if (_approved.Parcela10 > dataNula)
                {
                    parcelas += "; " + RetornaDiaFormatado(_approved.Parcela10);
                }
                if (_approved.Parcela11 > dataNula)
                {
                    parcelas += "; " + RetornaDiaFormatado(_approved.Parcela11);
                }
                if (_approved.Parcela12 > dataNula)
                {
                    parcelas += "; " + RetornaDiaFormatado(_approved.Parcela12);
                }

            }
            return parcelas;
        }

        private void CarregarDocumento()
        {
            try
            {
                richTextBox.LoadDocument("Resources/Contrato-OGX.docx");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erro ao carregar documento!\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private string obterCondicaoPagamento()
        {
            if (_approved.TipoPagamento == 0)
                return "Valor Integral";
            else if (_approved.TipoPagamento == 2)
                return "Isento";
            else return "Valor Parcial de R$" + _approved.ValorParcialNumerico.ToString("n2") + " (" + _approved.ValorParcialExtenso + ")";
        }
    }
}
