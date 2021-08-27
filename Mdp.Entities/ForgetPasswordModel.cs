using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mdp.Entities
{
    public class ForgetPasswordModel
    {
        public string email { get; set; }
        public string ReturnToken { get; set; }
        public string Password { get; set; }
    }
}
