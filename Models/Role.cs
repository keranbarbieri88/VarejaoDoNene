using System.Collections.Generic;

namespace VarejaoDoNene.Models
{
    public class Role
    {
        public string RoleName { get; set; }

        public string CPF { get; set; }
        public ICollection<Account> Accounts { get; set; }

        
    }
}