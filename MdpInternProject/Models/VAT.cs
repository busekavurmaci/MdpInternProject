using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XRechnungViewer.Models
{
    public class VAT : SelectOption
    {
        public static List<VAT> GetVATs()
        {
            List<VAT> list = new List<VAT>();
            list.Add(new VAT() { Code = "1", Name = "19%" });
            list.Add(new VAT() { Code = "2", Name = "10,7%" });
            list.Add(new VAT() { Code = "3", Name = "7,5%" });
            list.Add(new VAT() { Code = "4", Name = "7%" });
            list.Add(new VAT() { Code = "5", Name = "5,5%" });
            list.Add(new VAT() { Code = "6", Name = "0%" });
            //list.Add(new VAT() { Code = "7", Name = "Steuerbefreit" });
            //list.Add(new VAT() { Code = "8", Name = "Umkehrung der Steuerschuldnerschaft" });
            //list.Add(new VAT() { Code = "9", Name = "Umsatzsteuerbefreit für innergemeinschaftliche Warenlieferungen und Dienstleistungen" });
            //list.Add(new VAT() { Code = "10F", Name = "reier Ausfuhrartikel, Steuer nicht erhoben" });
            //list.Add(new VAT() { Code = "11D", Name = "ienstleistungen außerhalb des Steueranwendungsbereichs" });
            //list.Add(new VAT() { Code = "12F", Name = "reie Eingabe" });

            return list;
        }
    }
}
