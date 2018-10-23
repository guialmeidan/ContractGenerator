using Principal.Domain.Entities;
using Principal.Domain.Repositories;
using Principal.Domain.Services;
using Principal.WinApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace Principal.Forms
{
    public partial class ConsultaOpportunity : Form
    {
        private IOpportunityRepository _repositorioOpportunity;
        private IOpportunityService _opportunityService;
        public string token = "e316ebe109dd84ed16734e5161a2d236d0a7e6daf499941f7c110078e3c75493";

        public ConsultaOpportunity()
        {
            InitializeComponent();
            _opportunityService = AppCore.Container.Resolve<IOpportunityService>();
            _repositorioOpportunity = AppCore.Container.Resolve<IOpportunityRepository>();
            inputTNID.Text = "877136";
        }

        private void botaoBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Opportunity.MainOpportunity vaga = _repositorioOpportunity.ObterPorId(Convert.ToInt32(inputTNID.Text), token);
                preencherCampos(vaga);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar vaga", "Atenção!",
                MessageBoxButtons.OK);
            }
        }

        private void preencherCampos(Opportunity.MainOpportunity vaga)
        {
            int horaInicio = Convert.ToInt32(vaga.specifics_info.expected_work_schedule.from);
            int horaFim = Convert.ToInt32(vaga.specifics_info.expected_work_schedule.to);
            int cHDiaria = horaFim - horaInicio;
            int cHSemanal = cHDiaria * 5;
            
            this.groupBoxGeral.Text = vaga.title;
            this.textBoxPais.Text = vaga.branch.address_info.country;
            this.textBoxDataInicio.Text = vaga.earliest_start_date.Date.Day + "/" + vaga.earliest_start_date.Date.Month + "/" + vaga.earliest_start_date.Date.Year;
            this.textBoxDataFim.Text = vaga.latest_end_date.Date.Day + "/" + vaga.latest_end_date.Date.Month + "/" + vaga.latest_end_date.Date.Year;
            this.textBoxCidadeDestino.Text = vaga.branch.address_info.city;
            this.textBoxLocalizacaoEspecifica.Text = vaga.role_info.city;
            this.textBoxDuracao.Text = vaga.duration.ToString() + " semanas";
            this.textBoxCargaHorariaDiaria.Text = "Das " + vaga.specifics_info.expected_work_schedule.from + " às " + vaga.specifics_info.expected_work_schedule.to + " (" + cHDiaria + " horas/dia)";
            this.textBoxCargaHorariaSemanal.Text = cHSemanal.ToString() + " horas/semana";
            this.textBoxTrabalhaSabado.Text = converteBoolPortugues(vaga.specifics_info.saturday_work);

            this.textBoxAlimentacao.Text = converteAlimentacaoCoberta(vaga.logistics_info.food_covered);
            this.textBoxAlimentacaoFimDeSemana.Text = converteStringBoolParaPortugues(vaga.logistics_info.food_weekends);

            this.textBoxAcomodacaoProvida.Text = converteAcomodacaoProvida(vaga.logistics_info.accommodation_provided);
            this.textBoxAcomodacaoCoberta.Text = converteStringBoolParaPortugues(vaga.logistics_info.accommodation_covered);

            

            this.textBoxSalario.Text = obterSalarioCompleto(vaga);
            this.textBoxComputador.Text = converteBoolPortugues(vaga.specifics_info.computer);
            
            this.richTextBoxDescricaoCargo.Text = vaga.description;

            foreach (var item in vaga.role_info.learning_points_list)
            {
                this.richTextBoxAtividadesPrincipais.Text += "- ";
                this.richTextBoxAtividadesPrincipais.Text += item;
                this.richTextBoxAtividadesPrincipais.Text += "\n";
            }
        }

        private string converteBoolPortugues(bool valor)
        {
            if (valor == false)
                return "Não";
            else return "Sim";
        }

        private string converteAlimentacaoCoberta(string valor)
        {
            if (valor.Contains("1 meal"))
                valor = "1 refeição por dia";
            else if (valor.Contains("2 meal"))
                valor = "2 refeições por dia";
            else if (valor.Contains("3 meal"))
                valor = "3 refeições por dia";
            else if (valor.Contains("Not covered"))
                valor = "Não possui";
            else valor = "Não foi possível verificar";
            return valor;
        }

        private string converteAcomodacaoProvida(string valor)
        {
            if (valor.Equals("Provided"))
                return "Sim";
            else if (valor.Equals("Not provided"))
                return "Não";
            else return "Não foi possível verificar";
        }

        private string converteStringBoolParaPortugues(string valor)
        {
            if (valor.Equals("false"))
                return "Não";
            else if (valor.Equals("true"))
                return "Sim";
            else return "Não foi possível verificar";
        }
     
        private string obterSalarioCompleto(Opportunity.MainOpportunity vaga)
        {
            var salario = "";
            if (string.IsNullOrEmpty(vaga.specifics_info.salary) || vaga.specifics_info.salary.Equals("0"))
            {
                salario = "Não possui";
            }
            else salario = vaga.specifics_info.salary + " " + vaga.specifics_info.salary_currency.alphabetic_code + " (" + vaga.specifics_info.salary_currency.name + ")";
            return salario;
        }

    }
}
