using DevExpress.XtraEditors;
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
    public partial class ConsultarVaga : XtraForm
    {
        private IOpportunityRepository _repositorioOpportunity;
        private IOpportunityService _opportunityService;
        private ITokenPublicoRepositorio _repositorioTokenPublico;
        private Domain.Entities.TokenPublico _token;

        public ConsultarVaga()
        {
            InitializeComponent();

            _opportunityService = AppCore.Container.Resolve<IOpportunityService>();
            _repositorioOpportunity = AppCore.Container.Resolve<IOpportunityRepository>();
            _repositorioTokenPublico = AppCore.Container.Resolve<ITokenPublicoRepositorio>();

            _token = _repositorioTokenPublico.ObterToken();
        }

        private void botaoBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                this.ExibirFormEspera();
                VagaResumidaBR vaga = new VagaResumidaBR(_repositorioOpportunity.ObterPorId(Convert.ToInt32(inputTNID.Text), _token.Token));
                preencherCampos(vaga);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erro ao buscar vaga", "Atenção!",
                MessageBoxButtons.OK);
            }
            finally
            {
                this.FecharFormEspera();
            }
        }

        private void preencherCampos(VagaResumidaBR vaga)
        {
            this.groupInformacoesGerais.Text = "Informações Gerais - " + vaga.NomeVaga;
            this.inputPaisDestino.Text = vaga.PaisDestino;
            this.inputCidadeDestino.Text = vaga.CidadeDestino;
            this.inputCargaHorariaNumero.Text = vaga.CargaHorariaNumerica.ToString();
            this.inputCargaHorariaExtenso.Text = vaga.CargaHorariaExtenso;
            this.inputDuracao.Text = vaga.DuracaoIntercambio;
            this.inputLocalizacao.Text = vaga.LocalizacaoONG;
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
            this.inputDescricaoCargo.Text = vaga.DescricaoCargo;
            this.inputAtividades.Text = vaga.PrincipaisAtividades;
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                botaoBuscar_Click(sender, e);
            }
        }
    }
}
