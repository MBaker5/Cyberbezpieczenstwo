using Cyberbezpieczenstwo.Classes;
using Cyberbezpieczenstwo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cyberbezpieczenstwo
{
    public partial class EditUser : Form
    {
        Account user;
        public EditUser(Account User)
        {
            var dataHandler = new DataHandler();
            user = User;
            InitializeComponent();
            LoginTxtb.Text = User.Login;
            PasswordTxtb.Text = User.Password;
            AdminChcbx.Checked = User.Admin;
            PassRestChcbx.Checked = User.PasswordRestrictions;
            AccLockedChcbx.Checked = User.Locked;
            var DoZmiany = decimal.Parse((user.PassChange - DateTime.Now).Days.ToString());
            if(DoZmiany > 0)
            { PassChangeTimerInput.Value = DoZmiany; }
            else
            { PassChangeTimerInput.Value = 0; }
        }

        private void SaveChangesBtn_Click(object sender, EventArgs e)
        {
            var dataHandler = new DataHandler();
            var Accounts = dataHandler.GetAccounts();
            var UpdatedAccount = new Account();

            if (dataHandler.CheckNewLogin(LoginTxtb.Text, user.Login))
            {

                if (dataHandler.CheckNewPassword(PasswordTxtb.Text))
                {
                    UpdatedAccount.Id = user.Id;
                    UpdatedAccount.Login = LoginTxtb.Text;
                    UpdatedAccount.Password = PasswordTxtb.Text;
                    UpdatedAccount.Admin = AdminChcbx.Checked;
                    UpdatedAccount.PasswordRestrictions = PassRestChcbx.Checked;
                    UpdatedAccount.Locked = AccLockedChcbx.Checked;
                    UpdatedAccount.PassChange = DateTime.Now.AddDays((int)PassChangeTimerInput.Value);
                    Accounts[Accounts.FindIndex(ac => ac.Id == UpdatedAccount.Id)]=UpdatedAccount;
                    //Accounts.Add(UpdatedAccount);
                    dataHandler.UpdateData(Accounts);
                  
                
                }
                else
                {
                    Komunikat.Text = "hasło jest zbyt krotkie";
                }




            }
            else
            {
                Komunikat.Text = "Login jest zajety lub zbyt krotki";
            }
            
            
            dataHandler.UpdateData(Accounts);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var dataHandler = new DataHandler();
            var Accounts = dataHandler.GetAccounts();
            Accounts.Remove(Accounts.Where(x => x.Id == user.Id).FirstOrDefault());
            dataHandler.UpdateData(Accounts);
            this.Close();
        }
    }
}
