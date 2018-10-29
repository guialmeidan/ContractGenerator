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
    public partial class ContratoOGX : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private IPessoaRepositorio _repositorioPessoa;
        private IEscritorioRepositorio _repositorioEscritorio;
        private ITestemunhaRepositorio _repositorioTestemunha;

        private Domain.Entities.Escritorio _escritorio;
        private Domain.Entities.Testemunha _testemunha;
        private Domain.Entities.Approved _approved;
        private Domain.Pessoa _pessoaLCP;
        private Domain.Pessoa _pessoaEP;
        private Domain.Pessoa _pessoaResponsavel;
        private Domain.Pessoa _pessoaTestemunha1;
        private Domain.Pessoa _pessoaTestemunha2;

        public ContratoOGX(Approved approved)
        {
            InitializeComponent();
            this.Text = "Contrato de OGX";

            _repositorioPessoa = AppCore.Container.Resolve<IPessoaRepositorio>();
            _repositorioEscritorio = AppCore.Container.Resolve<IEscritorioRepositorio>();
            _repositorioTestemunha = AppCore.Container.Resolve<ITestemunhaRepositorio>();

            _escritorio = _repositorioEscritorio.ObterEscritorio();
            _approved = approved;
            _pessoaLCP = _repositorioPessoa.SelecionarPorId(_escritorio.LCP);
            _pessoaEP = _repositorioPessoa.SelecionarPorId(approved.IdEP);
            _pessoaResponsavel = _repositorioPessoa.SelecionarPorId(approved.IdResponsavel);
            _pessoaTestemunha1 = _repositorioPessoa.SelecionarPorId(approved.IdTestemunha1);
            _pessoaTestemunha2 = _repositorioPessoa.SelecionarPorId(approved.IdTestemunha2);

            CarregarDocumento();
            PreencherDocumento();
        }

        private void PreencherDocumento()
        {
            richTextBox.Document.ReplaceAll("<<nomeEPCompleto>>", _pessoaEP.Nome + " " + _pessoaEP.Sobrenome, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<nacionalidadeEP>>",_pessoaEP.Nacionalidade, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<estadoCivilEP>>", _pessoaEP.EstadoCivil, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<profissaoEP>>", _pessoaEP.Profissao, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<RGEP>>", _pessoaEP.NumeroDocumento, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<orgaoExpedidorEP>>", _pessoaEP.OrgaoExpedidor, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<orgaoExpedidorUFEP>>", _pessoaEP.UFDocumento, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<CPFEP>>", _pessoaEP.CPF, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<emailEP>>", _pessoaEP.Email, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<ruaEP>>", _pessoaEP.Rua, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<numeroEP>>", _pessoaEP.Numero, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<complementoEP>>", _pessoaEP.Complemento, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<bairroEP>>", _pessoaEP.Bairro, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<CEPEP>>", _pessoaEP.CEP, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<cidadeEP>>", _pessoaEP.Cidade, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<estadoEP>>", _pessoaEP.UFEndereco, SearchOptions.CaseSensitive);

            richTextBox.Document.ReplaceAll("<<nomeAIESEC>>", _escritorio.Nome, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<cnpjAIESEC>>", _escritorio.CNPJ, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<ruaAIESEC>>", _escritorio.Rua, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<numeroAIESEC>>", _escritorio.Numero, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<complementoAIESEC>>", _escritorio.Complemento, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<bairroAIESEC>>", _escritorio.Bairro, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<CEPAIESEC>>", _escritorio.CEP, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<cidadeAIESEC>>", _escritorio.Cidade, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<UFAIESEC>>", _escritorio.UF, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<nomeLCP>>", _pessoaLCP.Nome + " " + _pessoaLCP.Sobrenome, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<RGLCP>>", _pessoaLCP.NumeroDocumento, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<orgaoExpedidorLCP>>", _pessoaLCP.OrgaoExpedidor, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<orgaoExpedidorUFLCP>>", _pessoaLCP.UFDocumento, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<CPFLCP>>", _pessoaLCP.CPF, SearchOptions.CaseSensitive);

            richTextBox.Document.ReplaceAll("<<tipoPrograma>>", Conversoes.Conversoes.ConverteIntStringTipoProduto(_approved.TipoProdutoId), SearchOptions.CaseSensitive);

            richTextBox.Document.ReplaceAll("<<TNID>>", _approved.TNID, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<paisDestino>>", _approved.PaisDestino, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<cidadeDestino>>", _approved.CidadeDestino, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<dataInicio>>", _approved.DataInicio.Date.Day.ToString() + "/" + _approved.DataInicio.Date.Month.ToString() + "/" + _approved.DataInicio.Date.Year.ToString(), SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<dataFim>>", _approved.DataFim.Date.Day.ToString() + "/" + _approved.DataFim.Date.Month.ToString() + "/" + _approved.DataFim.Date.Year.ToString(), SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<cargaHoraria>>", _approved.CargaHorariaNumeral.ToString() + " (" + _approved.CargaHorariaExtenso + ")", SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<taxaICX>>", _approved.TaxaDestino, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<bolsaAuxilio>>", _approved.BolsaAuxilio, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<alimentacaoDiasTrabalho>>", _approved.AlimentacaoDiaTrabalho, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<alimentacaoFimSemana>>", _approved.AlimentacaoFimSemana, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<acomodacaoProvida>>", _approved.AcomodacaoProvida, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<acomodacaoCoberta>>", _approved.AcomodacaoCoberta, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<computador>>", _approved.Computador, SearchOptions.CaseSensitive);
            richTextBox.Document.ReplaceAll("<<trabalhoSabado>>", _approved.TrabalhoSabado, SearchOptions.CaseSensitive);

        }

        private void CarregarDocumento()
        {
            richTextBox.LoadDocument("Resources/Contrato-OGX.docx");
            //richTextBox.ExportToPdf("Resultado.pdf");
            //System.Diagnostics.Process.Start("Resultado.pdf");
        }
    }
}
