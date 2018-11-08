using DevExpress.XtraEditors;
using Principal.Domain;
using Principal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Principal.Conversoes
{
    public static class Conversoes
    {
        public static string retornarStringDocumentoCompleto(Pessoa pessoa)
        {
            if (pessoa.TipoDocumento == 0)
                return "RG nº " + pessoa.NumeroDocumento + " emitido pelo(a) " + pessoa.OrgaoExpedidor + "/" + pessoa.UFDocumento;
            else if (pessoa.TipoDocumento == 1)
                return "Passaporte nº " + pessoa.NumeroDocumento;
            else return "RNE nº " + pessoa.NumeroDocumento;
        }

        public static string retornarStringCompletaResponsavel(Pessoa pessoa)
        {
            if (pessoa.Id > 0)
                return " neste ato representado(a) por " + pessoa.Nome + " " + pessoa.Sobrenome + ", " + pessoa.Nacionalidade +
                    ", portador do " + retornarStringDocumentoCompleto(pessoa) + " e inscrito(a) no CPF sob o nº " + pessoa.CPF +
                    ", residente e domiciliado(a) na " + pessoa.Rua + ", " + pessoa.Complemento + " " + pessoa.Bairro + ", CEP " +
                    pessoa.CEP + ", " + pessoa.Cidade + " - " + pessoa.UFEndereco;
            else return "";

        }


        public static string TSqlToANSI(this string value, string provider)
        {
            if (provider == "Postgress")
            {
                value = value.Replace("LEN(", "LENGTH(");
                value = value.Replace("DATEPART(YEAR", "DATE_PART('year'");
                value = value.Replace("DATEPART(MONTH", "DATE_PART('month'");
                value = value.Replace("day(", "date_part('day',");
                value = value.Replace("MONTH(", "date_part('month',");
                value = value.Replace("like", "ilike");
            }
            else
            {
                value = value.Replace("false", "0");
                value = value.Replace("true", "1");
            }
            var teste = value.Replace("[", "\"").Replace("]", "\"");
            return teste;
        }

        public static string TSqlToANSI(this StringBuilder value)
        {
            return value.ToString().Replace("[", "\"").Replace("]", "\"");
        }

        public static string converteBoolPortugues(bool valor)
        {
            if (valor == false)
                return "Não";
            else return "Sim";
        }

        public static bool ConvertePortuguesBool(string valor)
        {
            if (valor.Equals("Sim"))
                return true;
            else return false;
        }

        public static string ConverteAlimentacaoSemana(string valor)
        {
            if (valor.ToUpper().Contains("1 meal".ToUpper()))
                valor = "1 refeição por dia de trabalho";
            else if (valor.ToUpper().Contains("2 meal".ToUpper()))
                valor = "2 refeições por dia de trabalho";
            else if (valor.ToUpper().Contains("3 meal".ToUpper()))
                valor = "3 refeições por dia de trabalho";
            else if (valor.ToUpper().Contains("Not covered".ToUpper()))
                valor = "Não possui";
            else valor = "Não foi possível verificar";
            return valor;
        }

        public static string ConverteAcomodacaoProvida(string valor)
        {
            if (valor.ToUpper().Equals("Provided".ToUpper()))
                return "Sim";
            else if (valor.ToUpper().Equals("Not Provided".ToUpper()))
                return "Não";
            else return "Não foi possível verificar";
        }

        public static string ConverteStringBoolParaPortugues(string valor)
        {
            if (valor.ToUpper().Equals("false".ToUpper()))
                return "Não";
            else if (valor.ToUpper().Equals("true".ToUpper()))
                return "Sim";
            else return "Não foi possível verificar";
        }

        public static string ConverteIntStringTipoProduto(int valor)
        {
            if (valor == 0)
                return "Voluntário Global";
            else if (valor == 1)
                return "Empreendedor Global";
            else return "Talento Global";
        }


        public static int ConverteStringIntTipoProduto(string produto)
        {
            if (produto.Equals("GV"))
                return 0;
            else if (produto.Equals("GE"))
                return 1;
            else return 2;
        }

        public static string ConverteStringCurtaStringLongaTipoProduto(string produto)
        {
            if (produto.Equals("GV"))
                return "Voluntário Global";
            else if (produto.Equals("GE"))
                return "Empreendedor Global";
            else return "Talento Global";
        }

        public static string ConverteNumericoExtenso(int valor)
        {
            string numero = valor.ToString();
            string milhar = string.Empty;
            string centena = string.Empty;
            string dezena = string.Empty;
            string unidade = string.Empty;
            string extenso = string.Empty;
            numero = numero.PadLeft(4, '0');

            string zero = "0000";
            if (numero == zero)
            {
                return "Zero";
            }

            // ESCREVER POR EXTENSO MILHAR
            if (numero[0] != '0')
            {
                switch (numero[0])
                {
                    case '1': milhar = "Um Mil"; break;
                    case '2': milhar = "Dois Mil"; break;
                    case '3': milhar = "Três Mil"; break;
                    case '4': milhar = "Quatro Mil"; break;
                    case '5': milhar = "Cinco Mil"; break;
                    case '6': milhar = "Seis Mil"; break;
                    case '7': milhar = "Sete Mil"; break;
                    case '8': milhar = "Oito Mil"; break;
                    case '9': milhar = "Nove Mil"; break;
                }
            }

            // ESCREVER POR EXTENSO CENTENA
            if (numero[1] != '0')
            {

                switch (numero[1])
                {
                    case '1': centena = "Cento "; break;
                    case '2': centena = "Duzentos "; break;
                    case '3': centena = "Trezentos "; break;
                    case '4': centena = "Quatrocentos "; break;
                    case '5': centena = "Quinhentos "; break;
                    case '6': centena = "Seiscentos "; break;
                    case '7': centena = "Setecentos "; break;
                    case '8': centena = "Oitocentos "; break;
                    case '9': centena = "Novecentos "; break;

                }
                if (numero[1] == '1' && numero[2] == '0' && numero[3] == '0')
                {
                    centena = "Cem";
                }
            }

            //ESCREVER POR EXTENSO DEZENA
            if (numero[2] == '1')
            {
                switch (numero.Substring(2))
                {
                    case "10": dezena = "e Dez"; break;
                    case "11": dezena = "e Onze"; break;
                    case "12": dezena = "e Doze"; break;
                    case "13": dezena = "e Treze"; break;
                    case "14": dezena = "e Quatorze"; break;
                    case "15": dezena = "e Quinze"; break;
                    case "16": dezena = "e Dezesseis"; break;
                    case "17": dezena = "e Dezessete"; break;
                    case "18": dezena = "e Dezoito"; break;
                    case "19": dezena = "e Dezenove"; break;
                }
            }
            else if (numero[2] != '0')
            {
                switch (numero[2])
                {
                    case '2': dezena = "e Vinte "; break;
                    case '3': dezena = "e Trinta "; break;
                    case '4': dezena = "e Quarenta "; break;
                    case '5': dezena = "e Cinquenta "; break;
                    case '6': dezena = "e Sessenta "; break;
                    case '7': dezena = "e Setenta "; break;
                    case '8': dezena = "e Oitenta "; break;
                    case '9': dezena = "e Noventa "; break;
                }
            }

            //ESCREVER POR EXTENSO UNIDADE
            if (numero[3] != '0' && numero[2] != '1')
            {
                switch (numero[3])
                {
                    case '1': unidade = "e Uma"; break;
                    case '2': unidade = "e Duas"; break;
                    case '3': unidade = "e Três"; break;
                    case '4': unidade = "e Quatro"; break;
                    case '5': unidade = "e Cinco"; break;
                    case '6': unidade = "e Seis"; break;
                    case '7': unidade = "e Sete"; break;
                    case '8': unidade = "e Oito"; break;
                    case '9': unidade = "e Nove"; break;
                }
            }

            // CRIAR EXTENSO
            extenso = milhar + centena + dezena + unidade;

            // COMANDO DE SAIDA
            if (extenso[0] == 'e')
            {
                extenso = extenso.Substring(2);
            }

            return extenso;
        }

        public static string retornarMesExtenso(int month)
        {
            switch (month)
            {
                case 1: return "Janeiro";
                case 2: return "Fevereiro"; 
                case 3: return "Março"; 
                case 4: return "Abril";
                case 5: return "Maio";
                case 6: return "Junho"; 
                case 7: return "Julho"; 
                case 8: return "Agosto";
                case 9: return "Setembro";
                case 10: return "Outubro"; 
                case 11: return "Novembro"; 
                case 12: return "Dezembro";
                default: return "Janeiro";
;            }
        }

        public static string retornarModosPagamento(Approved approved)
        {
            if (approved.TipoPagamento == 2)
                return "Isento";
            else return "[ " + converteBoolParaX(approved.ModoBoleto) + " ] Boleto Bancário     " +
                    "[ " + converteBoolParaX(approved.ModoCartaoCredito) + " ] Cartão de Crédito     " +
                    "[ " + converteBoolParaX(approved.ModoCartaoDebito) + " ] Cartão de Débito     " +
                    "[ " + converteBoolParaX(approved.ModoCheque) + " ] Cheque                           " +
                    "[ " + converteBoolParaX(approved.ModoDinheiro) + " ] Dinheiro     " +
                    "[ " + converteBoolParaX(approved.ModoTransferencia) + " ] Transferência Bancária     " +
                    "[ " + converteBoolParaX(approved.ModoDeposito) + " ] Depósito Bancário     " +
                    "[ " + converteBoolParaX(approved.ModoPagSeguro) + " ] PagSeguro     ";

        }

        public static string converteBoolParaX(bool modoPagamento)
        {
            if (modoPagamento == true)
                return "x";
            else return "";
        }

        public static string retornarTipoPagamento(Approved approved)
        {
            if (approved.TipoPagamento == 0)
                return "À vista";
            else if (approved.TipoPagamento == 1)
                return "Parcelado em " + approved.QtdParcelas + " vezes";
            else return "Isento";
        }

        public static string EscreverExtenso(decimal valor, string codigoMoeda)
        {
            ConverterMoedas converter = new ConverterMoedas(codigoMoeda);

            if (valor == 0)
                return "Zero " + converter.MoedaPlural;
            else if (valor <= 0 | valor >= 1000000000000000)
                return "Valor não suportado pelo sistema.";
            else
            {
                string strValor = valor.ToString("000000000000000.00");
                string valor_por_extenso = string.Empty;
                for (int i = 0; i <= 15; i += 3)
                {
                    valor_por_extenso += Escrever_Valor_Extenso(Convert.ToDecimal(strValor.Substring(i, 3)));
                    if (i == 0 & valor_por_extenso != string.Empty)
                    {
                        if (Convert.ToInt32(strValor.Substring(0, 3)) == 1)
                            valor_por_extenso += " Trilhão" + ((Convert.ToDecimal(strValor.Substring(3, 12)) > 0) ? " e " : string.Empty);
                        else if (Convert.ToInt32(strValor.Substring(0, 3)) > 1)
                            valor_por_extenso += " Trilhões" + ((Convert.ToDecimal(strValor.Substring(3, 12)) > 0) ? " e " : string.Empty);
                    }
                    else if (i == 3 & valor_por_extenso != string.Empty)
                    {
                        if (Convert.ToInt32(strValor.Substring(3, 3)) == 1)
                            valor_por_extenso += " Bilhão" + ((Convert.ToDecimal(strValor.Substring(6, 9)) > 0) ? " e " : string.Empty);
                        else if (Convert.ToInt32(strValor.Substring(3, 3)) > 1)
                            valor_por_extenso += " Bilhões" + ((Convert.ToDecimal(strValor.Substring(6, 9)) > 0) ? " e " : string.Empty);
                    }
                    else if (i == 6 & valor_por_extenso != string.Empty)
                    {
                        if (Convert.ToInt32(strValor.Substring(6, 3)) == 1)
                            valor_por_extenso += " Milhão" + ((Convert.ToDecimal(strValor.Substring(9, 6)) > 0) ? " e " : string.Empty);
                        else if (Convert.ToInt32(strValor.Substring(6, 3)) > 1)
                            valor_por_extenso += " Milhões" + ((Convert.ToDecimal(strValor.Substring(9, 6)) > 0) ? " e " : string.Empty);
                    }
                    else if (i == 9 & valor_por_extenso != string.Empty)
                        if (Convert.ToInt32(strValor.Substring(9, 3)) > 0)
                            valor_por_extenso += " Mil" + ((Convert.ToDecimal(strValor.Substring(12, 3)) > 0) ? " e " : string.Empty);
                    if (i == 12)
                    {
                        if (valor_por_extenso.Length > 8)
                            if (valor_por_extenso.Substring(valor_por_extenso.Length - 6, 6) == "Bilhão" | valor_por_extenso.Substring(valor_por_extenso.Length - 6, 6) == "Milhão")
                                valor_por_extenso += " de";
                            else
                                if (valor_por_extenso.Substring(valor_por_extenso.Length - 7, 7) == "Bilhões" | valor_por_extenso.Substring(valor_por_extenso.Length - 7, 7) == "Milhões"
| valor_por_extenso.Substring(valor_por_extenso.Length - 8, 7) == "Trilhões")
                                valor_por_extenso += " de";
                            else
                                    if (valor_por_extenso.Substring(valor_por_extenso.Length - 8, 8) == "Trilhões")
                                valor_por_extenso += " de";
                        if (Convert.ToInt64(strValor.Substring(0, 15)) == 1)
                            valor_por_extenso += " " + converter.MoedaSingular;
                        else if (Convert.ToInt64(strValor.Substring(0, 15)) > 1)
                            valor_por_extenso += " " + converter.MoedaPlural;
                        if (Convert.ToInt32(strValor.Substring(16, 2)) > 0 && valor_por_extenso != string.Empty)
                            valor_por_extenso += " e ";
                    }
                    if (i == 15)
                        if (Convert.ToInt32(strValor.Substring(16, 2)) == 1)
                            valor_por_extenso += " Centavo";
                        else if (Convert.ToInt32(strValor.Substring(16, 2)) > 1)
                            valor_por_extenso += " Centavos";
                }
                return valor_por_extenso;
            }
        }
        static string Escrever_Valor_Extenso(decimal valor)
        {
            if (valor <= 0)
                return string.Empty;
            else
            {
                string montagem = string.Empty;
                if (valor > 0 & valor < 1)
                {
                    valor *= 100;
                }
                string strValor = valor.ToString("000");
                int a = Convert.ToInt32(strValor.Substring(0, 1));
                int b = Convert.ToInt32(strValor.Substring(1, 1));
                int c = Convert.ToInt32(strValor.Substring(2, 1));
                if (a == 1) montagem += (b + c == 0) ? "Cem" : "Cento";
                else if (a == 2) montagem += "Duzentos";
                else if (a == 3) montagem += "Trezentos";
                else if (a == 4) montagem += "Quatrocentos";
                else if (a == 5) montagem += "Quinhentos";
                else if (a == 6) montagem += "Seiscentos";
                else if (a == 7) montagem += "Setecentos";
                else if (a == 8) montagem += "Oitocentos";
                else if (a == 9) montagem += "Novecentos";
                if (b == 1)
                {
                    if (c == 0) montagem += ((a > 0) ? " e " : string.Empty) + "Dez";
                    else if (c == 1) montagem += ((a > 0) ? " e " : string.Empty) + "Onze";
                    else if (c == 2) montagem += ((a > 0) ? " e " : string.Empty) + "Doze";
                    else if (c == 3) montagem += ((a > 0) ? " e " : string.Empty) + "Treze";
                    else if (c == 4) montagem += ((a > 0) ? " e " : string.Empty) + "Quatorze";
                    else if (c == 5) montagem += ((a > 0) ? " e " : string.Empty) + "Quinze";
                    else if (c == 6) montagem += ((a > 0) ? " e " : string.Empty) + "Dezesseis";
                    else if (c == 7) montagem += ((a > 0) ? " e " : string.Empty) + "Dezessete";
                    else if (c == 8) montagem += ((a > 0) ? " e " : string.Empty) + "Dezoito";
                    else if (c == 9) montagem += ((a > 0) ? " e " : string.Empty) + "Dezenove";
                }
                else if (b == 2) montagem += ((a > 0) ? " e " : string.Empty) + "Vinte";
                else if (b == 3) montagem += ((a > 0) ? " e " : string.Empty) + "Trinta";
                else if (b == 4) montagem += ((a > 0) ? " e " : string.Empty) + "Quartenta";
                else if (b == 5) montagem += ((a > 0) ? " e " : string.Empty) + "Cinquenta";
                else if (b == 6) montagem += ((a > 0) ? " e " : string.Empty) + "Sessenta";
                else if (b == 7) montagem += ((a > 0) ? " e " : string.Empty) + "Setenta";
                else if (b == 8) montagem += ((a > 0) ? " e " : string.Empty) + "Oitenta";
                else if (b == 9) montagem += ((a > 0) ? " e " : string.Empty) + "Noventa";
                if (strValor.Substring(1, 1) != "1" & c != 0 & montagem != string.Empty) montagem += " e ";
                if (strValor.Substring(1, 1) != "1")
                    if (c == 1) montagem += "Um";
                    else if (c == 2) montagem += "Dois";
                    else if (c == 3) montagem += "Três";
                    else if (c == 4) montagem += "Quatro";
                    else if (c == 5) montagem += "Cinco";
                    else if (c == 6) montagem += "Seis";
                    else if (c == 7) montagem += "Sete";
                    else if (c == 8) montagem += "Oito";
                    else if (c == 9) montagem += "Nove";
                return montagem;
            }
        }
    }

}