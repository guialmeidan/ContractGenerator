using Principal.Conversoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Domain.Entities
{
    public class VagaResumidaBR
    {
        public string TNID { get; set; }
        public string NomeVaga { get; set; }
        public string PaisDestino { get; set; }
        public string CidadeDestino { get; set; }
        public int CargaHorariaNumerica { get; set; }
        public string CargaHorariaExtenso { get; set; }
        public string DuracaoIntercambio { get; set; }
        public string LocalizacaoONG { get; set; }
        public int TipoProdutoId { get; set; }
        public string TipoProdutoDescricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string TrabalhoSabado { get; set; }
        public string AcomodacaoProvida { get; set; }
        public string AcomodacaoCoberta { get; set; }
        public string AlimentacaoSemana { get; set; }
        public string AlimentacaoFimSemana { get; set; }
        public string Computador { get; set; }
        public string BolsaAuxilio { get; set; }
        public string DescricaoCargo { get; set; }
        public string PrincipaisAtividades { get; set; }

        public VagaResumidaBR(Opportunity.MainOpportunity vagaEXPA)
        {
            this.TNID = vagaEXPA.id.ToString();
            this.NomeVaga = vagaEXPA.title;
            this.PaisDestino = vagaEXPA.host_lc.country;
            this.CidadeDestino = vagaEXPA.location.Split(new[] { ',' }, 2)[0].Trim();
            this.CargaHorariaNumerica = obterCargaHorariaNumerica(vagaEXPA);
            this.CargaHorariaExtenso = obterCargaHorariaExtenso();
            this.DuracaoIntercambio = vagaEXPA.duration.ToString() + " semanas";
            this.LocalizacaoONG = vagaEXPA.role_info.city;
            this.TipoProdutoId = Conversoes.Conversoes.ConverteStringIntTipoProduto(vagaEXPA.programmes.short_name);
            this.TipoProdutoDescricao = Conversoes.Conversoes.ConverteStringCurtaStringLongaTipoProduto(vagaEXPA.programmes.short_name);
            this.DataInicio = vagaEXPA.earliest_start_date.Date.AddDays(-1);
            this.DataFim = vagaEXPA.latest_end_date.Date.AddDays(-1);
            this.TrabalhoSabado = Conversoes.Conversoes.converteBoolPortugues(vagaEXPA.specifics_info.saturday_work);
            this.AcomodacaoProvida = Conversoes.Conversoes.ConverteAcomodacaoProvida(vagaEXPA.logistics_info.accommodation_provided);
            this.AcomodacaoCoberta = Conversoes.Conversoes.ConverteStringBoolParaPortugues(vagaEXPA.logistics_info.accommodation_covered);
            this.AlimentacaoSemana = Conversoes.Conversoes.ConverteAlimentacaoSemana(vagaEXPA.logistics_info.food_covered);
            this.AlimentacaoFimSemana = Conversoes.Conversoes.ConverteStringBoolParaPortugues(vagaEXPA.logistics_info.food_weekends);
            this.Computador = Conversoes.Conversoes.converteBoolPortugues(vagaEXPA.specifics_info.computer);
            this.BolsaAuxilio = obterBolsaAuxilio(vagaEXPA);
            this.DescricaoCargo = vagaEXPA.description;
            this.PrincipaisAtividades = obterAtividades(vagaEXPA);
        }

        private string obterAtividades(Opportunity.MainOpportunity vagaEXPA)
        {
            string atividades = "";
            foreach (var item in vagaEXPA.role_info.learning_points_list)
            {
                atividades += "- ";
                atividades += item;
                atividades += "\n";
            }
            return atividades;
        }

        private string obterBolsaAuxilio(Opportunity.MainOpportunity vagaEXPA)
        {           
            var salario = "";
            if (string.IsNullOrEmpty(vagaEXPA.specifics_info.salary) || vagaEXPA.specifics_info.salary.Equals("0"))
            {
                salario = "Não possui";
            }
            else salario = vagaEXPA.specifics_info.salary_currency.alphabetic_code + " " +
                            Convert.ToDecimal(vagaEXPA.specifics_info.salary).ToString("n2") + " (" +
                           Conversoes.Conversoes.EscreverExtenso(Convert.ToDecimal(vagaEXPA.specifics_info.salary), vagaEXPA.specifics_info.salary_currency.alphabetic_code) + ")";
            return salario;
        }

        private DateTime obterDataCorreta(DateTime date)
        {
            return date.AddDays(-1);
        }

        private string obterTipoProdutoDescricao(Opportunity.MainOpportunity vagaEXPA)
        {
            throw new NotImplementedException();
        }

        private string obterCargaHorariaExtenso()
        {
            return Conversoes.Conversoes.ConverteNumericoExtenso(this.CargaHorariaNumerica) + " Horas Semanais";
        }

        private int obterCargaHorariaNumerica(Opportunity.MainOpportunity vagaEXPA)
        {
            int cargaHorariaSemanal = 0;
            int horaInicio = Convert.ToInt32(vagaEXPA.specifics_info.expected_work_schedule.from);
            int horaFim = Convert.ToInt32(vagaEXPA.specifics_info.expected_work_schedule.to);

            //verificar se existe trabalho aos sábados
            if (vagaEXPA.specifics_info.saturday_work == true)
                cargaHorariaSemanal = (horaFim - horaInicio) * 6;
            else cargaHorariaSemanal = (horaFim - horaInicio) * 5;
            
            return Math.Abs(cargaHorariaSemanal);
        }
    }
}
