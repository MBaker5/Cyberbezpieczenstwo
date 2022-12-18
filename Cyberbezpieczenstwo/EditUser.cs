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
        Account admin;
        public EditUser(Account User, Account Admin)
        {
            var dataHandler = new DataHandler();
            admin = Admin;
            user = User;
            InitializeComponent();
            LoginTxtb.Text = User.Login;
            PasswordTxtb.Text = User.Password;
            AdminChcbx.Checked = User.Admin;
            PassRestChcbx.Checked = User.PasswordRestrictions;
            AccLockedChcbx.Checked = User.Locked;
            PrintRestriction.Checked = User.PrintLocked;
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
                    var log = new LogHandler();
                    log.Log(admin, $"Edytowano uzytkownika id:{user.Id} login:{user.Login}");

                    if(UpdatedAccount.Password != PasswordTxtb.Text)
                    { log.Log(admin, $"Zmieniono haslo uzytkownika id:{user.Id} login:{user.Login}"); }
                    if (UpdatedAccount.Admin != AdminChcbx.Checked && UpdatedAccount.Admin) 
                    { log.Log(admin, $"Uzytkownik id:{user.Id} login:{user.Login} stracil role Administratora"); }
                    if (UpdatedAccount.Admin != AdminChcbx.Checked && !UpdatedAccount.Admin)
                    { log.Log(admin, $"Uzytkownik id:{user.Id} login:{user.Login} uzyskal role Administratora"); }

                    if (UpdatedAccount.Locked != AccLockedChcbx.Checked && UpdatedAccount.Locked)
                    { log.Log(admin, $"Uzytkownik id:{user.Id} login:{user.Login} zostal odblokowany"); }
                    if (UpdatedAccount.Locked != AccLockedChcbx.Checked && !UpdatedAccount.Locked)
                    { log.Log(admin, $"Uzytkownik id:{user.Id} login:{user.Login} zostal zablokowany"); }

                    if (UpdatedAccount.PrintLocked != PrintRestriction.Checked && UpdatedAccount.PrintLocked)
                    { log.Log(admin, $"Uzytkownik id:{user.Id} login:{user.Login} ma ograniczenia"); }
                    if (UpdatedAccount.PrintLocked != PrintRestriction.Checked && !UpdatedAccount.PrintLocked)
                    { log.Log(admin, $"Uzytkownik id:{user.Id} login:{user.Login} nie ma ograniczenia"); }

                    if (UpdatedAccount.PasswordRestrictions != PassRestChcbx.Checked && UpdatedAccount.PasswordRestrictions)
                    { log.Log(admin, $"Ograniczenia hasla zniesione dla id:{user.Id} login:{user.Login}"); }
                    if (UpdatedAccount.PasswordRestrictions != PassRestChcbx.Checked && UpdatedAccount.PasswordRestrictions)
                    { log.Log(admin, $"Dodano ograniczenia hasla dla id:{user.Id} login:{user.Login}"); }

                    UpdatedAccount.Id = user.Id;
                    UpdatedAccount.Login = LoginTxtb.Text;
                    UpdatedAccount.Password = PasswordTxtb.Text;
                    UpdatedAccount.Admin = AdminChcbx.Checked;
                    UpdatedAccount.PasswordRestrictions = PassRestChcbx.Checked;
                    UpdatedAccount.Locked = AccLockedChcbx.Checked;
                    UpdatedAccount.PrintLocked = PrintRestriction.Checked;
                    UpdatedAccount.PassChange = DateTime.Now.AddDays((int)PassChangeTimerInput.Value);
                    if (PrintRestriction.Checked == true)
                    {
                        UpdatedAccount.CipherPass = VigenereCipher.Encipher(textBox2.Text, textBox1.Text);
                    }
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
            var log = new LogHandler();
            log.Log(admin, $"Usunieto uzytkownika id:{user.Id} login:{user.Login}");
            var dataHandler = new DataHandler();
            var Accounts = dataHandler.GetAccounts();
            Accounts.Remove(Accounts.FirstOrDefault(x => x.Id == user.Id));
            dataHandler.UpdateData(Accounts);
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var log = new LogHandler();
            log.Log(admin, $"Nałożono ograniczenie na użytkownika id:{user.Id} login:{user.Login}");
            var dataHandler = new DataHandler();
            var Accounts = dataHandler.GetAccounts();
            Accounts.FirstOrDefault(x => x.Id == user.Id).PrintLocked.Equals(true);
            dataHandler.UpdateData(Accounts);
            
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }
        private void GenerateKeyBtn_Click(object sender, EventArgs e)
        {
            int keyLenght = Convert.ToInt32(numericUpDown1.Value);
            textBox1.Text = RandomProvider.CreateString(keyLenght);
            //textBox1.Text = VigenereCipher.Encipher(textBox2.Text,keyLenght) ;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox3.Text = VigenereCipher.Encipher(textBox2.Text, textBox1.Text);
            
            var dataHandler = new DataHandler();
            var Accounts = dataHandler.GetAccounts();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = VigenereCipher.Decipher(textBox3.Text, textBox1.Text);
        }
    }
}
