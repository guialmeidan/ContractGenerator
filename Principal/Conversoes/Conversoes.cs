using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Principal.Conversoes
{
    public static class Conversoes
    {

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

        public static bool convertePortuguesBool(string valor)
        {
            if (valor.Equals("Sim"))
                return true;
            else return false;
        }

        public static string converteAlimentacaoCoberta(string valor)
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

        public static string converteAcomodacaoProvida(string valor)
        {
            if (valor.Equals("Provided"))
                return "Sim";
            else if (valor.Equals("Not provided"))
                return "Não";
            else return "Não foi possível verificar";
        }

        public static string converteStringBoolParaPortugues(string valor)
        {
            if (valor.Equals("false"))
                return "Não";
            else if (valor.Equals("true"))
                return "Sim";
            else return "Não foi possível verificar";
        }

        public static string converteIntStringTipoProduto(int valor)
        {
            if (valor == 0)
                return "GV";
            else if (valor == 1)
                return "GE";
            else return "GT";
        }


        public static int converteStringIntTipoProduto(string produto)
        {
            if (produto.Equals("GV"))
                return 0;
            else if (produto.Equals("GE"))
                return 1;
            else return 2;
        }
    }
}
