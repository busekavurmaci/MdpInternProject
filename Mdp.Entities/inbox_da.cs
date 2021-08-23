using Mdp.DataLayer.DAL.SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mdp.Entities
{
    public class inbox_da
    {
        public int id { get; set; }
        public string number { get; set; }
        public Guid uuid { get; set; }
        public DateTime issue_date { get; set; }
        public DateTime issue_time { get; set; }
        public DateTime desp_date { get; set; }
        public DateTime desp_time { get; set; }
        public string type { get; set; }
        public string profile { get; set; }
        public string sender { get; set; }
        public string sender_vn { get; set; }
        public string receiver { get; set; }
        public string receiver_vn { get; set; }
        public string xmlcontent { get; set; }
        public Int16 status { get; set; }
        public Int16 cor_status { get; set; }
        public DateTime insert_date { get; set; }
        public Guid sbd_uuid { get; set; }
        public Int16 sbd_element_id { get; set; }
        public Int16 gib_status { get; set; }
        public Guid bar_uuid { get; set; }
        public string bar_respcode { get; set; }
        public DateTime sr_date { get; set; }
        public byte d { get; set; }
        public byte a { get; set; }
        public decimal payable_amount { get; set; }
        public string payable_amount_cur { get; set; }
        public string file_dir { get; set; }
        public string file_name { get; set; }
        public string bar_file_name { get; set; }
        public string bc_name { get; set; }
        public string bc_company_id { get; set; }
        public string gtb_ref_no { get; set; }
        public string gtb_tescil_no { get; set; }
        public DateTime gtb_ihrac_tar { get; set; }
        public Int16 year { get; set; }
        public string erp_doc_no { get; set; }
        //-------------------------------------------------------
        public string start_date { get; set; }
        public string end_date { get; set; }

        public static DataTable GetDataTable(string profile, string type, string sender, string sender_vn, string receiver, string receiver_vn, string start_date, string end_date, DateTime? issue_date, short? gib_status)
        {
            string sql = "SELECT * FROM inbox_da WHERE 1=1 ";

            if (profile != "TÜMÜ")
                sql += " AND profile=@profile ";

            if (type != "TÜMÜ")
                sql += " AND type=@type ";

            if (!string.IsNullOrEmpty(sender))
                sql += "AND sender LIKE '%" + @sender + "%'";

            if (!string.IsNullOrEmpty(sender_vn))
                sql += " AND sender_vn=@sender_vn ";

            if (!string.IsNullOrEmpty(receiver_vn))
                sql += " AND receiver_vn=@receiver_vn ";

            if (!string.IsNullOrEmpty(receiver))
                sql += " AND receiver LIKE '%" + receiver + "%'";

            if (!string.IsNullOrEmpty(gib_status.ToString()))
                sql += " AND gib_status=@gib_status ";

            sql += " AND issue_date between @start_date and @end_date";


            return SQLHelper.GetDataTable(sql, new string[] { "@profile", "@type", "@sender", "@sender_vn", "@receiver_vn", "@receiver", "@start_date", "@end_date", "@gib_status" }, new object[] { profile, type, sender, sender_vn, receiver_vn, receiver, start_date, end_date, gib_status });
        }
        //----------------------------------------------

        public static DataTable GetDataTable2(string number)
        {
            string sql = "SELECT * FROM inbox_da WHERE 1=1 ";

            if (!string.IsNullOrEmpty(number))
                sql += " AND number=@number ";



            return SQLHelper.GetDataTable2(sql, new string[] { "@number" }, new object[] { number });
        }

    }
}
