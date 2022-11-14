using Cyberbezpieczenstwo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberbezpieczenstwo.Classes
{
    internal class LogHandler
    {
        public string LogLoc = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "log.txt");
      

        public void Log(Account user, string Akcja)
        {
            string log = user.Id.ToString() + ";" + user.Login + ";" + Akcja + ";" + DateTime.Now.ToString()+"\n";
            File.AppendAllText(LogLoc, log);
        }

    }
}
