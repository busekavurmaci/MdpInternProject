﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XRechnungViewer.Models
{
    public class Currency : SelectOption
    {

        public static List<Currency> GetCurrencies()
        {
            List<Currency> list = new List<Currency>();
            list.Add(new Currency() { Code = "AFN", Name = "Afghani" });
            list.Add(new Currency() { Code = "EGP", Name = "Ägyptisches Pfund" });
            list.Add(new Currency() { Code = "DZD", Name = "Algerischer Dinar" });
            list.Add(new Currency() { Code = "ANG", Name = "Antillen-Gulden" });
            list.Add(new Currency() { Code = "ARS", Name = "Argentinischer Peso" });
            list.Add(new Currency() { Code = "MGA", Name = "Ariary" });
            list.Add(new Currency() { Code = "AMD", Name = "Armenischer Dram" });
            list.Add(new Currency() { Code = "AWG", Name = "Aruba-Florin" });
            list.Add(new Currency() { Code = "AZN", Name = "Aserbaidschan-Manat" });
            list.Add(new Currency() { Code = "ETB", Name = "Äthiopischer Birr" });
            list.Add(new Currency() { Code = "AUD", Name = "Australischer Dollar" });
            list.Add(new Currency() { Code = "BSD", Name = "Bahama-Dollar" });
            list.Add(new Currency() { Code = "BHD", Name = "Bahrain-Dinar" });
            list.Add(new Currency() { Code = "THB", Name = "Baht" });
            list.Add(new Currency() { Code = "PAB", Name = "Balboa" });
            list.Add(new Currency() { Code = "BBD", Name = "Barbados-Dollar" });
            list.Add(new Currency() { Code = "BZD", Name = "Belize-Dollar" });
            list.Add(new Currency() { Code = "BMD", Name = "Bermuda-Dollar" });
            list.Add(new Currency() { Code = "VEF", Name = "Bolívar" });
            list.Add(new Currency() { Code = "BOB", Name = "Boliviano" });
            list.Add(new Currency() { Code = "BND", Name = "Brunei-Dollar" });
            list.Add(new Currency() { Code = "BIF", Name = "Burundi-Franc" });
            list.Add(new Currency() { Code = "GHS", Name = "Cedi" });
            list.Add(new Currency() { Code = "XOF", Name = "CFA-Franc BCEAO" });
            list.Add(new Currency() { Code = "CLF", Name = "Chilenische Unidades de Fomento" });
            list.Add(new Currency() { Code = "CLP", Name = "Chilenischer Peso" });
            list.Add(new Currency() { Code = "CNY", Name = "Chinesischer Yuan" });
            list.Add(new Currency() { Code = "NIO", Name = "Córdoba Oro" });
            list.Add(new Currency() { Code = "CRC", Name = "Costa-Rica-Colón" });
            list.Add(new Currency() { Code = "GMD", Name = "Dalasi" });
            list.Add(new Currency() { Code = "DKK", Name = "Dänische Krone" });
            list.Add(new Currency() { Code = "MKD", Name = "Denar" });
            list.Add(new Currency() { Code = "STD", Name = "Dobra" });
            list.Add(new Currency() { Code = "DOP", Name = "Dominikanischer Peso" });
            list.Add(new Currency() { Code = "DJF", Name = "Dschibuti-Franc" });
            list.Add(new Currency() { Code = "XSU", Name = "Ecuadorianischer Sucre" });
            list.Add(new Currency() { Code = "SVC", Name = "El-Salvador-Colón" });
            list.Add(new Currency() { Code = "EUR", Name = "Euro" });
            list.Add(new Currency() { Code = "FKP", Name = "Falkland-Pfund" });
            list.Add(new Currency() { Code = "FJD", Name = "Fidschi-Dollar" });
            list.Add(new Currency() { Code = "HUF", Name = "Forint" });
            list.Add(new Currency() { Code = "GEL", Name = "Georgischer Lari" });
            list.Add(new Currency() { Code = "GIP", Name = "Gibraltar-Pfund" });
            list.Add(new Currency() { Code = "HTG", Name = "Gourde" });
            list.Add(new Currency() { Code = "PYG", Name = "Guaraní" });
            list.Add(new Currency() { Code = "GNF", Name = "Guinea-Franc" });
            list.Add(new Currency() { Code = "GYD", Name = "Guyana-Dollar" });
            list.Add(new Currency() { Code = "HKD", Name = "Hongkong-Dollar" });
            list.Add(new Currency() { Code = "UAH", Name = "Hrywnja" });
            list.Add(new Currency() { Code = "INR", Name = "Indische Rupie" });
            list.Add(new Currency() { Code = "IDR", Name = "Indonesische Rupiah" });
            list.Add(new Currency() { Code = "IQD", Name = "Irakischer Dinar" });
            list.Add(new Currency() { Code = "IRR", Name = "Iranischer Rial" });
            list.Add(new Currency() { Code = "ISK", Name = "Isländische Krone" });
            list.Add(new Currency() { Code = "JMD", Name = "Jamaika-Dollar" });
            list.Add(new Currency() { Code = "YER", Name = "Jemen-Rial" });
            list.Add(new Currency() { Code = "JOD", Name = "Jordanischer Dinar" });
            list.Add(new Currency() { Code = "KYD", Name = "Kaiman-Dollar" });
            list.Add(new Currency() { Code = "CAD", Name = "Kanadischer Dollar" });
            list.Add(new Currency() { Code = "CVE", Name = "Kap-Verde-Escudo" });
            list.Add(new Currency() { Code = "QAR", Name = "Katar-Riyal" });
            list.Add(new Currency() { Code = "KES", Name = "Kenia-Schilling" });
            list.Add(new Currency() { Code = "PGK", Name = "Kina" });
            list.Add(new Currency() { Code = "COP", Name = "Kolumbianischer Peso" });
            list.Add(new Currency() { Code = "COU", Name = "Kolumbische Unidad de Valor Real" });
            list.Add(new Currency() { Code = "KMF", Name = "Komoren-Franc" });
            list.Add(new Currency() { Code = "CDF", Name = "Kongo-Franc" });
            list.Add(new Currency() { Code = "BAM", Name = "Konvertible Mark" });
            list.Add(new Currency() { Code = "HRK", Name = "Kroatische Kuna" });
            list.Add(new Currency() { Code = "CUP", Name = "Kubanischer Peso" });
            list.Add(new Currency() { Code = "KWD", Name = "Kuwait-Dinar" });
            list.Add(new Currency() { Code = "AOA", Name = "Kwanza" });
            list.Add(new Currency() { Code = "MMK", Name = "Kyat" });
            list.Add(new Currency() { Code = "LAK", Name = "Laotischer Kip" });
            list.Add(new Currency() { Code = "ALL", Name = "Lek" });
            list.Add(new Currency() { Code = "HNL", Name = "Lempira" });
            list.Add(new Currency() { Code = "BGN", Name = "Lew" });
            list.Add(new Currency() { Code = "LBP", Name = "Libanesisches Pfund" });
            list.Add(new Currency() { Code = "LRD", Name = "Liberianischer Dollar" });
            list.Add(new Currency() { Code = "LYD", Name = "Libyscher Dinar" });
            list.Add(new Currency() { Code = "SZL", Name = "Lilangeni" });
            list.Add(new Currency() { Code = "LSL", Name = "Loti" });
            list.Add(new Currency() { Code = "MWK", Name = "Malawi-Kwacha" });
            list.Add(new Currency() { Code = "MYR", Name = "Malaysischer Ringgit" });
            list.Add(new Currency() { Code = "MAD", Name = "Marokkanischer Dirham" });
            list.Add(new Currency() { Code = "MUR", Name = "Mauritius-Rupie" });
            list.Add(new Currency() { Code = "MZN", Name = "Metical" });
            list.Add(new Currency() { Code = "MXN", Name = "Mexikanischer Peso" });
            list.Add(new Currency() { Code = "MDL", Name = "Moldauischer Leu" });
            list.Add(new Currency() { Code = "BOV", Name = "Mvdol" });
            list.Add(new Currency() { Code = "NGN", Name = "Naira" });
            list.Add(new Currency() { Code = "ERN", Name = "Nakfa" });
            list.Add(new Currency() { Code = "NAD", Name = "Namibia-Dollar" });
            list.Add(new Currency() { Code = "NPR", Name = "Nepalesische Rupie" });
            list.Add(new Currency() { Code = "TWD", Name = "Neuer Taiwan-Dollar" });
            list.Add(new Currency() { Code = "NZD", Name = "Neuseeland-Dollar" });
            list.Add(new Currency() { Code = "BTN", Name = "Ngultrum" });
            list.Add(new Currency() { Code = "KPW", Name = "Nordkoreanischer Won" });
            list.Add(new Currency() { Code = "NOK", Name = "Norwegische Krone" });
            list.Add(new Currency() { Code = "OMR", Name = "Omanischer Rial" });
            list.Add(new Currency() { Code = "XCD", Name = "Ostkaribischer Dollar" });
            list.Add(new Currency() { Code = "MRO", Name = "Ouguiya" });
            list.Add(new Currency() { Code = "TOP", Name = "Pa’anga" });
            list.Add(new Currency() { Code = "PKR", Name = "Pakistanische Rupie" });
            list.Add(new Currency() { Code = "MOP", Name = "Pataca" });
            list.Add(new Currency() { Code = "CUC", Name = "Peso convertible" });
            list.Add(new Currency() { Code = "GBP", Name = "Pfund Sterling" });
            list.Add(new Currency() { Code = "PHP", Name = "Philippinischer Peso" });
            list.Add(new Currency() { Code = "BWP", Name = "Pula" });
            list.Add(new Currency() { Code = "GTQ", Name = "Quetzal" });
            list.Add(new Currency() { Code = "ZAR", Name = "Rand" });
            list.Add(new Currency() { Code = "BRL", Name = "Real" });
            list.Add(new Currency() { Code = "KHR", Name = "Riel" });
            list.Add(new Currency() { Code = "RWF", Name = "Ruanda-Franc" });
            list.Add(new Currency() { Code = "MVR", Name = "Rufiyaa" });
            list.Add(new Currency() { Code = "RON", Name = "Rumänischer Leu" });
            list.Add(new Currency() { Code = "RUB", Name = "Russischer Rubel" });
            list.Add(new Currency() { Code = "SBD", Name = "Salomonen-Dollar" });
            list.Add(new Currency() { Code = "ZMW", Name = "Sambischer Kwacha" });
            list.Add(new Currency() { Code = "WST", Name = "Samoanischer Tala" });
            list.Add(new Currency() { Code = "SAR", Name = "Saudi-Riyal" });
            list.Add(new Currency() { Code = "ILS", Name = "Schekel" });
            list.Add(new Currency() { Code = "SEK", Name = "Schwedische Krone" });
            list.Add(new Currency() { Code = "CHF", Name = "Schweizer Franken" });
            list.Add(new Currency() { Code = "RSD", Name = "Serbischer Dinar" });
            list.Add(new Currency() { Code = "SCR", Name = "Seychellen-Rupie" });
            list.Add(new Currency() { Code = "SLL", Name = "Sierra-leonischer Leone" });
            list.Add(new Currency() { Code = "ZWL", Name = "Simbabwe-Dollar" });
            list.Add(new Currency() { Code = "SGD", Name = "Singapur-Dollar" });
            list.Add(new Currency() { Code = "PEN", Name = "Sol" });
            list.Add(new Currency() { Code = "KGS", Name = "Som" });
            list.Add(new Currency() { Code = "SOS", Name = "Somalia-Schilling" });
            list.Add(new Currency() { Code = "TJS", Name = "Somoni" });
            list.Add(new Currency() { Code = "XDR", Name = "Sonderziehungsrecht" });
            list.Add(new Currency() { Code = "LKR", Name = "Sri-Lanka-Rupie" });
            list.Add(new Currency() { Code = "SHP", Name = "St.-Helena-Pfund" });
            list.Add(new Currency() { Code = "SDG", Name = "Sudanesisches Pfund" });
            list.Add(new Currency() { Code = "KRW", Name = "Südkoreanischer Won" });
            list.Add(new Currency() { Code = "SSP", Name = "Südsudanesisches Pfund" });
            list.Add(new Currency() { Code = "SRD", Name = "Suriname-Dollar" });
            list.Add(new Currency() { Code = "SYP", Name = "Syrisches Pfund" });
            list.Add(new Currency() { Code = "BDT", Name = "Taka" });
            list.Add(new Currency() { Code = "TZS", Name = "Tansania-Schilling" });
            list.Add(new Currency() { Code = "KZT", Name = "Tenge" });
            list.Add(new Currency() { Code = "TTD", Name = "Trinidad-und-Tobago-Dollar" });
            list.Add(new Currency() { Code = "CZK", Name = "Tschechische Krone" });
            list.Add(new Currency() { Code = "MNT", Name = "Tugrik" });
            list.Add(new Currency() { Code = "TND", Name = "Tunesischer Dinar" });
            list.Add(new Currency() { Code = "TRY", Name = "Türkische Lira" });
            list.Add(new Currency() { Code = "TMT", Name = "Turkmenistan-Manat" });
            list.Add(new Currency() { Code = "UGX", Name = "Uganda-Schilling" });
            list.Add(new Currency() { Code = "UYI", Name = "Uruguay Peso En Unidades Indexadas (Uruiurui)" });
            list.Add(new Currency() { Code = "UYU", Name = "Uruguayischer Peso" });
            list.Add(new Currency() { Code = "UZS", Name = "Usbekischer Soʻm" });
            list.Add(new Currency() { Code = "USD", Name = "US-Dollar" });
            list.Add(new Currency() { Code = "AED", Name = "VAE-Dirham" });
            list.Add(new Currency() { Code = "VUV", Name = "Vatu" });
            list.Add(new Currency() { Code = "VND", Name = "Vietnamesischer Đồng" });
            list.Add(new Currency() { Code = "BYN", Name = "Weißrussische Rubel" });
            list.Add(new Currency() { Code = "JPY", Name = "Yen" });
            list.Add(new Currency() { Code = "PLN", Name = "Zloty" });

            return list;

        }
    }
}
