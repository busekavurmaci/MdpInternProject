using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mdp.Entities
{
    public class outbox_ra
    {

        public int id { get; set; }
        public string number { get; set; }
        public System.Guid uuid { get; set; }
        public DateTime issue_date { get; set; }
        public DateTime issue_time { get; set; }
        public DateTime dlv_date { get; set; }
        public DateTime dlv_time { get; set; }
        public string type { get; set; }
        public string profile { get; set; }
        public string sender { get; set; }
        public string sender_vn { get; set; }
        public string receiver { get; set; }
        public string receiver_vn { get; set; }
        public string xmlcontent { get; set; }
        public int status { get; set; }
        public int cor_status { get; set; }
        public DateTime insert_date { get; set; }
        public System.Guid sbd_uuid { get; set; }
        public int sbd_element_id { get; set; }
        public int gib_status { get; set; }
        public System.Guid bar_uuid { get; set; }
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
        public int year { get; set; }
        public string erp_doc_no { get; set; }

    }
}
