using System.Collections.Generic;

namespace VarejaoDoNene.Models
{
    public class Account
    {
        public string CPF { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public string RoleName { get; set; }
        public Role Role { get; set; }

        public ICollection<Sale> Sale { get; set; }
    }
}