using Mdp.DataLayer.DAL.SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mdp.Entities
{
    public class user
    {
        public string username { get; set; }
        public string passwd { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string dept { get; set; }
        public string title { get; set; }
        public DateTime create_date { get; set; }
        public short role_id { get; set; }
        public short status { get; set; }

       

    }
}
