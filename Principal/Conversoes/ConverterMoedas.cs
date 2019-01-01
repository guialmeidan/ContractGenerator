using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Conversoes
{
    public class ConverterMoedas
    {
        public string Codigo;
        public string MoedaSingular;
        public string MoedaPlural;

        public ConverterMoedas(string codigo)
        {
            descobrirMoeda(codigo);
        }

        private void descobrirMoeda(string codigo)
        {
            switch (codigo)
            {
                case "BRL":
                    MoedaSingular = "Real";
                    MoedaPlural = "Reais";
                    break;

                case "AED":
                    MoedaSingular = "Dirham dos Emirados Árabes Unidos";
                    MoedaPlural = "Dirhams  dos Emirados Árabes Unidos";
                    break;

                case "AFN":
                    MoedaSingular = "Rupia Afegã";
                    MoedaPlural = "Rupias Afegãs";
                    break;

                case "ALL":
                    MoedaSingular = "Lek";
                    MoedaPlural = "Lekes";
                    break;

                case "AMD":
                    MoedaSingular = "Dracma Armênio";
                    MoedaPlural = "Dracmas Armênios";
                    break;

                case "AOA":
                    MoedaSingular = "Kwanza";
                    MoedaPlural = "Kwanzaz";
                    break;

                case "ARS":
                    MoedaSingular = "Peso Argentino";
                    MoedaPlural = "Pesos Argentinos";
                    break;

                case "AUD":
                    MoedaSingular = "Dólar Australiano";
                    MoedaPlural = "Dólares Australianos";
                    break;

                case "AZN":
                    MoedaSingular = "Manat do Azerbaijão";
                    MoedaPlural = "Manats do Azerbaijão";
                    break;

                case "BAM":
                    MoedaSingular = "Marco Conversível";
                    MoedaPlural = "Marcos Conversíveis";
                    break;

                case "BBD":
                    MoedaSingular = "Dólar de Barbados";
                    MoedaPlural = "Dólares de Barbados";
                    break;

                case "BDT":
                    MoedaSingular = "Taka";
                    MoedaPlural = "Takas";
                    break;

                case "BGN":
                    MoedaSingular = "Lev Búlgaro";
                    MoedaPlural = "Leves Búlgaros";
                    break;

                case "BHD":
                    MoedaSingular = "Dinar do Bahrain";
                    MoedaPlural = "Dinares do Bahrein";
                    break;

                case "BOB":
                    MoedaSingular = "Boliviano";
                    MoedaPlural = "Bolivianos";
                    break;

                case "BSD":
                    MoedaSingular = "Dólar das Bahamas";
                    MoedaPlural = "Dólares de Bahamas";
                    break;

                case "BWP":
                    MoedaSingular = "Pula";
                    MoedaPlural = "Pulas";
                    break;

                case "BYR":
                    MoedaSingular = "Rublo Bielorrusso";
                    MoedaPlural = "Rublos Bielorrusso";
                    break;

                case "CAD":
                    MoedaSingular = "Dólar Canadense";
                    MoedaPlural = "Dólares Canadenses";
                    break;

                case "CHF":
                    MoedaSingular = "Franco Suíço";
                    MoedaPlural = "Francos Suíços";
                    break;

                case "CLP":
                    MoedaSingular = "Peso Chileno";
                    MoedaPlural = "Pesos Chilenos";
                    break;

                case "CNY":
                    MoedaSingular = "Iuan";
                    MoedaPlural = "Iuanes";
                    break;

                case "COP":
                    MoedaSingular = "Peso Colombiano";
                    MoedaPlural = "Pesos Colombianos";
                    break;

                case "CRC":
                    MoedaSingular = "Colón Costariquenho";
                    MoedaPlural = "Colones Costa Riquenhos";
                    break;

                case "CUP":
                    MoedaSingular = "Peso Cubano";
                    MoedaPlural = "Pesos Cubanos";
                    break;

                case "CZK":
                    MoedaSingular = "Coroa Tcheca";
                    MoedaPlural = "Coroas Tchecas";
                    break;

                case "DKK":
                    MoedaSingular = "Coroa Dinamarquesa";
                    MoedaPlural = "Coroas Dinamarquesas";
                    break;

                case "DOP":
                    MoedaSingular = "Peso Dominicano";
                    MoedaPlural = "Pesos Dominicanos";
                    break;

                case "DZD":
                    MoedaSingular = "Dinar Argelino";
                    MoedaPlural = "Dinares Argelinos";
                    break;

                case "EGP":
                    MoedaSingular = "Libra Egípcia";
                    MoedaPlural = "Libras Egípcias";
                    break;

                case "ETB":
                    MoedaSingular = "Birr Etíope";
                    MoedaPlural = "Birres Etíopes";
                    break;

                case "EUR":
                    MoedaSingular = "Euro";
                    MoedaPlural = "Euros";
                    break;

                case "FJD":
                    MoedaSingular = "Dólar de Fiji";
                    MoedaPlural = "Dólares de Fiji";
                    break;

                case "GBP":
                    MoedaSingular = "Libra Esterlina";
                    MoedaPlural = "Libras Esterlinas";
                    break;

                case "GEL":
                    MoedaSingular = "Lari";
                    MoedaPlural = "Láris";
                    break;

                case "GHS":
                    MoedaSingular = "Cedi";
                    MoedaPlural = "Cedis";
                    break;

                case "GTQ":
                    MoedaSingular = "Quetzal";
                    MoedaPlural = "Quetzais";
                    break;

                case "HKD":
                    MoedaSingular = "Dólar de Hong Kong";
                    MoedaPlural = "Dólares de Hong Kong";
                    break;

                case "HNL":
                    MoedaSingular = "Lempira";
                    MoedaPlural = "Lempiras";
                    break;

                case "HRK":
                    MoedaSingular = "Kuna Croata";
                    MoedaPlural = "Kunas Croatas";
                    break;

                case "HUF":
                    MoedaSingular = "Forint";
                    MoedaPlural = "Forintes";
                    break;

                case "IDR":
                    MoedaSingular = "Rupia";
                    MoedaPlural = "Rupias";
                    break;

                case "INR":
                    MoedaSingular = "Rupia Indiana";
                    MoedaPlural = "Rupias Indianas";
                    break;

                case "IRR":
                    MoedaSingular = "Rial Iraniano";
                    MoedaPlural = "Rials Iranianos";
                    break;

                case "ISK":
                    MoedaSingular = "Coroa Islandesa";
                    MoedaPlural = "Coroas Islandesas";
                    break;

                case "JOD":
                    MoedaSingular = "Dinar Jordaniano";
                    MoedaPlural = "Dinares Jordanianos";
                    break;

                case "JPY":
                    MoedaSingular = "Iene";
                    MoedaPlural = "Ienes";
                    break;

                case "KES":
                    MoedaSingular = "Shilling Queniano";
                    MoedaPlural = "Shillings Quenianos ";
                    break;

                case "KGS":
                    MoedaSingular = "Som";
                    MoedaPlural = "Som";
                    break;

                case "KHR":
                    MoedaSingular = "Riel";
                    MoedaPlural = "Riéis";
                    break;

                case "KRW":
                    MoedaSingular = "Won";
                    MoedaPlural = "Wones";
                    break;

                case "KZT":
                    MoedaSingular = "Tenge";
                    MoedaPlural = "Tenge";
                    break;

                case "LAK":
                    MoedaSingular = "Kip";
                    MoedaPlural = "Kipes";
                    break;

                case "LBP":
                    MoedaSingular = "Libra Libanesa";
                    MoedaPlural = "Libras Libanesas";
                    break;

                case "LKR":
                    MoedaSingular = "Rupia do Sri Lanka";
                    MoedaPlural = "Rupias Cinegalesas";
                    break;

                case "LRD":
                    MoedaSingular = "Dólar Liberiano";
                    MoedaPlural = "Dólares Liberianos";
                    break;

                case "MAD":
                    MoedaSingular = "Dirham Marroquino";
                    MoedaPlural = "Dirham Marroquinos";
                    break;

                case "MDL":
                    MoedaSingular = "Leu Moldávio";
                    MoedaPlural = "Lei Moldávios";
                    break;

                case "MKD":
                    MoedaSingular = "Denar";
                    MoedaPlural = "Denars Macedônios";
                    break;

                case "MMK":
                    MoedaSingular = "Kyat Birmanês";
                    MoedaPlural = "Kyates";
                    break;

                case "MNT":
                    MoedaSingular = "Tugrik";
                    MoedaPlural = "Tugriks";
                    break;

                case "MUR":
                    MoedaSingular = "Rupia Mauriciana";
                    MoedaPlural = "Rupias Mauricianas";
                    break;

                case "MVR":
                    MoedaSingular = "Rupia Maldiva";
                    MoedaPlural = "Rupias Maldivas";
                    break;

                case "MWK":
                    MoedaSingular = "Kwacha Malawaiana";
                    MoedaPlural = "Kwachas Malawaianas";
                    break;

                case "MXN":
                    MoedaSingular = "Peso Mexicano";
                    MoedaPlural = "Pesos Mexicanos";
                    break;

                case "MYR":
                    MoedaSingular = "Ringgit Malaio";
                    MoedaPlural = "Ringuites Malaios";
                    break;

                case "MZN":
                    MoedaSingular = "Metical";
                    MoedaPlural = "Meticais";
                    break;

                case "NAD":
                    MoedaSingular = "Dólar da Namíbia";
                    MoedaPlural = "Dólares da Namíbia";
                    break;

                case "NGN":
                    MoedaSingular = "Naira";
                    MoedaPlural = "Naira";
                    break;

                case "NIO":
                    MoedaSingular = "Córdoba Nicaraguense";
                    MoedaPlural = "Córdobas Nicaraguenses";
                    break;

                case "NOK":
                    MoedaSingular = "Coroa Norueguesa";
                    MoedaPlural = "Coroas Norueguesas";
                    break;

                case "NPR":
                    MoedaSingular = "Rupia Nepalesa";
                    MoedaPlural = "Rúpias Nepalesas";
                    break;

                case "NZD":
                    MoedaSingular = "Dólar Neozelandês";
                    MoedaPlural = "Dólares Neozelandezes";
                    break;

                case "OMR":
                    MoedaSingular = "Rial Omanese";
                    MoedaPlural = "Riais Omaneses";
                    break;

                case "PAB":
                    MoedaSingular = "Balboa";
                    MoedaPlural = "Balboas Panhamenhos";
                    break;

                case "PEN":
                    MoedaSingular = "Novo Sol";
                    MoedaPlural = "Soles";
                    break;

                case "PHP":
                    MoedaSingular = "Peso Filipinio";
                    MoedaPlural = "Pesos Filipinos";
                    break;

                case "PKR":
                    MoedaSingular = "Rupia Paquistanesa";
                    MoedaPlural = "Rupias Paquistanesas";
                    break;

                case "PLN":
                    MoedaSingular = "Zloty";
                    MoedaPlural = "Zlotis";
                    break;

                case "PYG":
                    MoedaSingular = "Guarani";
                    MoedaPlural = "Guaranies";
                    break;

                case "QAR":
                    MoedaSingular = "Rial Catarense";
                    MoedaPlural = "Rials Catarenses";
                    break;

                case "RON":
                    MoedaSingular = "Leu";
                    MoedaPlural = "Lei";
                    break;

                case "RSD":
                    MoedaSingular = "Dinar Sérvio";
                    MoedaPlural = "Dinares Sérvios";
                    break;

                case "RUB":
                    MoedaSingular = "Rublo Russo";
                    MoedaPlural = "Rublos Russos";
                    break;

                case "RWF":
                    MoedaSingular = "Franco Ruandês";
                    MoedaPlural = "Francos Ruandeses";
                    break;

                case "SAR":
                    MoedaSingular = "Rial Saudita";
                    MoedaPlural = "Riais Árabes";
                    break;

                case "SCR":
                    MoedaSingular = "Rúpia de Seycheles";
                    MoedaPlural = "Rúpias de Seycheles";
                    break;

                case "SDG":
                    MoedaSingular = "Libra Sudanesa";
                    MoedaPlural = "Libras Sudanesas";
                    break;

                case "SEK":
                    MoedaSingular = "Coroa Sueca";
                    MoedaPlural = "Coroas Suecas";
                    break;

                case "SVC":
                    MoedaSingular = "Colón Salvadorenho";
                    MoedaPlural = "Colons Salvadorenhos";
                    break;

                case "THB":
                    MoedaSingular = "Baht";
                    MoedaPlural = "Bahtes";
                    break;

                case "TJS":
                    MoedaSingular = "Somoni";
                    MoedaPlural = "Somonis";
                    break;

                case "TND":
                    MoedaSingular = "Dinar Tunisiano";
                    MoedaPlural = "Dinares Tunisianos";
                    break;

                case "TRY":
                    MoedaSingular = "Lira Turca";
                    MoedaPlural = "Liras Turcas";
                    break;

                case "TWD":
                    MoedaSingular = "Dólar de Taiwan";
                    MoedaPlural = "Dólares de Taiwan";
                    break;

                case "TZS":
                    MoedaSingular = "Xelim Tanzaniano";
                    MoedaPlural = "Xelins Tanzanianos";
                    break;

                case "UAH":
                    MoedaSingular = "Grívnia";
                    MoedaPlural = "Grívnias";
                    break;

                case "UGX":
                    MoedaSingular = "Xelim Ugandês";
                    MoedaPlural = "Xelins Ugandeses";
                    break;

                case "USD":
                    MoedaSingular = "Dólar Norte-Americano";
                    MoedaPlural = "Dólares Norte-Americanos";
                    break;

                case "UYU":
                    MoedaSingular = "Peso Uruguaio";
                    MoedaPlural = "Pesos Uruguaios";
                    break;

                case "UZS":
                    MoedaSingular = "Som Uzbeque";
                    MoedaPlural = "Somes Uzbeques";
                    break;

                case "VEF":
                    MoedaSingular = "Bolivar Venezuelano";
                    MoedaPlural = "Bolívares Venezuelanos";
                    break;

                case "VND":
                    MoedaSingular = "Dong";
                    MoedaPlural = "Dongues";
                    break;

                case "XAF":
                    MoedaSingular = "Franco da África Central";
                    MoedaPlural = "Francos da África Central";
                    break;

                case "XOF":
                    MoedaSingular = "Franco da África Ocidental";
                    MoedaPlural = "Francos da África Ocidental";
                    break;

                case "ZAR":
                    MoedaSingular = "Rand";
                    MoedaPlural = "Randes";
                    break;

                case "ZMW":
                    MoedaSingular = "Kwacha Zambiano";
                    MoedaPlural = "Kwachas Zambianos";
                    break;

                default:
                    MoedaSingular = " ";
                    MoedaPlural = " ";
                    break;
            }
        }
    }
}
