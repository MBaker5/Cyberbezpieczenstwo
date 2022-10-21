using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberbezpieczenstwo.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool Admin { get; set; }
        public bool Locked { get; set; }
        public DateTime PassChange { get; set; }

    }
}
