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

        public List<Account> GetAccounts() 
        {
            var lines = new List<string>();
            lines = File.ReadAllLines(DataLoc).ToList();
            var Accounts = new List<Account>();
           
            foreach(var line in lines) 
            {
               var splitedLine=line.Split(";");

                var Account = new Account();
                Account.Id = int.Parse(splitedLine[0]);
                Account.Login = splitedLine[1];
                Account.Password = splitedLine[2];
                Account.Admin = bool.Parse(splitedLine[3]);
                Account.Locked = bool.Parse(splitedLine[4]);
                Account.PassChange =  DateTime.Parse(splitedLine[5]);

                Accounts.Add(Account);
            }

            return Accounts;
        }

        public void UpdateData(List<Account> AccList)
        {
            string[] Lines= new string[AccList.Count()]; 

            for(int i = 0; i<AccList.Count(); i++) 
            {
                Lines[i] = AccList[i].Id.ToString() + ";" + AccList[i].Login + ";" + AccList[i].Password + ";"
                + AccList[i].Admin.ToString() + ";" + AccList[i].Locked.ToString() + ";" + AccList[i].PassChange.ToString();
            }

            File.WriteAllLines(DataLoc, Lines);
        }
        



    }
}
