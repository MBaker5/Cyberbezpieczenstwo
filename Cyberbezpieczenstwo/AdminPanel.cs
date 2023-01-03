using Cyberbezpieczenstwo.Classes;
using Cyberbezpieczenstwo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cyberbezpieczenstwo
{
    public partial class AdminPanel : Form
    {
        DataHandler dataHandler;
        Account admin;
        public List<Account> accounts;
        public AdminPanel(Account Admin)
        {
            dataHandler = new DataHandler();
            admin = Admin;
            InitializeComponent();
            accounts = dataHandler.GetAccounts();
            AccoutsGV.DataSource = accounts;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{

        //    if (textBox4.Text == admin.Password)
        //    {
        //        var UpdatedAccounts = new List<Account>();
        //        for (int i = 0; i < AccoutsGV.RowCount; i++)
        //        {
        //            var Account = new Account();

        //            Account.Id = int.Parse(AccoutsGV.Rows[i].Cells[0].Value.ToString());
        //            Account.Login = AccoutsGV.Rows[i].Cells[1].Value.ToString();
        //            Account.Password = AccoutsGV.Rows[i].Cells[2].Value.ToString();
        //            Account.Admin = bool.Parse(AccoutsGV.Rows[i].Cells[3].Value.ToString());
        //            Account.PasswordRestrictions = bool.Parse(AccoutsGV.Rows[i].Cells[4].Value.ToString());
        //            Account.Locked = bool.Parse(AccoutsGV.Rows[i].Cells[5].Value.ToString());
        //            Account.PassChange = DateTime.Parse(AccoutsGV.Rows[i].Cells[5].Value.ToString());
        //            UpdatedAccounts.Add(Account);
        //        }
        //        label4.Text = "zapisano zmiany";
        //        dataHandler.UpdateData(UpdatedAccounts);
        //    }
        //    else
        //    { label4.Text = "podaj poprawne hasło by zapisac zmiany"; }


        //}

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            EditUser EU = new(accounts.Where(x=>x.Id == int.Parse(EditUserIDTxtb.Text)).First(),admin);
            EU.Location = this.Location;
            EU.StartPosition = FormStartPosition.Manual;
            EU.FormClosing += delegate { this.Show(); this.accounts = dataHandler.GetAccounts(); this.AccoutsGV.DataSource = this.accounts; };
            EU.Show();
            this.Hide();
          
            //accounts=dataHandler.GetAccounts()
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AddNewUserBtn_Click(object sender, EventArgs e)
        {
            if (dataHandler.CheckNewLogin(NewUserLoginTxtb.Text, ""))
            {
                if (GenOneTimePassChckBX.Checked || dataHandler.CheckPasswordRestriction(NewUserPassTxtb.Text))
                {

                    var Accounts = dataHandler.GetAccounts();
                    var newAccount = new Account();

                    newAccount.Id = Accounts.OrderByDescending(x => x.Id).First().Id + 1;
                    newAccount.Login = NewUserLoginTxtb.Text;
                    if (GenOneTimePassChckBX.Checked)
                    {
                        newAccount.Password = dataHandler.CalculateOneTimePassword(newAccount.Login.Length).ToString().Trim(',');
                    }
                    else
                    {
                        newAccount.Password = NewUserPassTxtb.Text;
                    }

                    newAccount.Admin = false;
                    newAccount.PasswordRestrictions = false;
                    newAccount.Locked = false;
                    newAccount.PrintLocked = false;
                    newAccount.PassChange = DateTime.Now;
                    newAccount.CipherPass = "";
                    Accounts.Add(newAccount);
                    dataHandler.UpdateData(Accounts);
                    AccoutsGV.DataSource = dataHandler.GetAccounts();
                    label4.Text = "";
                    var log = new LogHandler();
                    log.Log(admin, $"Dodano uzytkownika id:{newAccount.Id} login:{newAccount.Login}");
                }
                else
                { label4.Text = "hasło jest zbyt krotkie"; }
            }
            else
            { label4.Text = "Istieje juz uzytkownik o takiej nazwie"; }
        }
    }
}
