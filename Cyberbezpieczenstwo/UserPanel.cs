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
    public partial class UserPanel : Form
    {
        Account user;
        public UserPanel(Account User)
        {
            user = User;
            InitializeComponent();
            if((DateTime.Now - user.PassChange).Days>=0) { WelcomeLbl.Text = "Wymagana zmiana hasla"; }
            else { this.WelcomeLbl.Text = "Witaj " + User.Login; }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {   
            if (oldpassTxtbx.Text != this.user.Password){ WelcomeLbl.Text = "bledne hasło!"; }
            if (oldpassTxtbx.Text == newpassTxtbx.Text) { WelcomeLbl.Text = "hasło musi sie roznic od poprzedniego!"; }
            else
            {
                if (oldpassTxtbx.Text == this.user.Password)
                {
                    if (newpassTxtbx.Text == newpassrepeatTxtbx.Text)
                    {
                        var datahandler = new DataHandler();
                        if (datahandler.CheckPasswordRestriction(newpassTxtbx.Text))
                        {
                            var log = new LogHandler();
                            log.Log(user, "zmienil swoje haslo");
                            var Accounts = datahandler.GetAccounts();
                            Accounts.FirstOrDefault(x => x.Id == this.user.Id).Password = newpassTxtbx.Text;
                            datahandler.UpdateData(Accounts);
                            WelcomeLbl.Text = "haslo zmienione";
                            newpassTxtbx.Text = "";
                            newpassrepeatTxtbx.Text = "";
                            oldpassTxtbx.Text = "";
                        }
                        else
                        { WelcomeLbl.Text = "bedny fomrat hasla"; }
                    }
                    else
                    { WelcomeLbl.Text = "Nowe hasło zostało zle powtorzone "; }

                }
            }
        }

        private void DoSthBtn_Click(object sender, EventArgs e)
        {
            bool isPL = this.user.PrintLocked;


            if (isPL == false)
            {
                WelcomeLbl.Text = "Drukuje";
            }
            else
            {
                WelcomeLbl.Text = "Masz nałożone ograniczenie!";
            }


        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            //string CText = VigenereCipher.DoStuff();
            //textBox2_TextChanged.Text = CText;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == user.CipherPass)
            {
                var dataHandler = new DataHandler();
                var Accounts = dataHandler.GetAccounts();
                user.PrintLocked = false;
                user.CipherPass = "";
                Accounts[Accounts.FindIndex(ac => ac.Id == user.Id)] = user;
                dataHandler.UpdateData(Accounts);
            }
        }
    }
}
