using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
