using Cyberbezpieczenstwo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberbezpieczenstwo.Classes
{
    internal class DataHandler
    {
        public string DataLoc = AppDomain.CurrentDomain.BaseDirectory + "data.txt";
        public string DataLocAlt = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName,"data.txt");

        public List<Account> GetAccounts() 
        {
            var lines = new List<string>();
            lines = File.ReadAllLines(DataLocAlt).ToList();
            var Accounts = new List<Account>();
           
            foreach(var line in lines) 
            {
               var splitedLine=line.Split(";");

                var Account = new Account();
                Account.Id = int.Parse(splitedLine[0]);
                Account.Login = splitedLine[1];
                Account.Password = splitedLine[2];
                Account.Admin = bool.Parse(splitedLine[3]);
                Account.PasswordRestrictions = bool.Parse(splitedLine[4]);
                Account.Locked = bool.Parse(splitedLine[5]);
                Account.PrintLocked = bool.Parse(splitedLine[6]);
                Account.PassChange = DateTime.Parse(splitedLine[7]);
                Account.CipherPass = splitedLine[8];

                Accounts.Add(Account);
            }

            return Accounts;
        }

        public void UpdateData(List<Account> AccList)
        {
            string[] Lines= new string[AccList.Count()]; 

            for(int i = 0; i<AccList.Count(); i++) 
            {
                Lines[i] = 
                    AccList[i].Id.ToString() + ";" + 
                    AccList[i].Login + ";" + 
                    AccList[i].Password + ";"+ 
                    AccList[i].Admin.ToString() + ";" + 
                    AccList[i].PasswordRestrictions.ToString() + ";" + 
                    AccList[i].Locked.ToString() + ";" + 
                    AccList[i].PrintLocked.ToString() + ";" + 
                    AccList[i].PassChange.ToString() + ";" +
                    AccList[i].CipherPass.ToString();

            }

            File.WriteAllLines(DataLocAlt, Lines);
        }

        public bool CheckNewLogin(string login, string loginold)
        {
            var accounts = GetAccounts();
            foreach(var acc in accounts)
            {
                if (acc.Login == login && acc.Login != loginold|| acc.Login=="") { return false; }
            }

            return true;
        }

        public int CountDays( DateTime dataDoResetu) 
        {
            var teraz = new DateTime();
            
            return int.Parse(teraz.Subtract(dataDoResetu).Days.ToString());
        }


        public bool CheckNewPassword(string password)
        {
            if (password.Length>2)
            { return true; }
            else
            { return false; }
        }

        public bool CheckRestriction(bool PrintLocked)
        {
            return PrintLocked;
        }

        public bool CheckPasswordRestriction(string password) 
        {
            if(password.Distinct().Count() == password.Count())
                { return true; }
            else 
                { return false; }
        }

    }
}
