﻿using Cyberbezpieczenstwo.Classes;
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
    public partial class AdminPanel : Form
    {
        DataHandler dataHandler;
        Account Admin;
        public AdminPanel(Account Admin)
        {
            dataHandler = new DataHandler();
            Admin = Admin;
            InitializeComponent();
            dataGridView1.DataSource = dataHandler.GetAccounts();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var UpdatedAccounts = new List<Account>();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                var Account = new Account();

                Account.Id = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                Account.Login = dataGridView1.Rows[i].Cells[1].Value.ToString();
                Account.Password = dataGridView1.Rows[i].Cells[2].Value.ToString();
                Account.Admin = bool.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                Account.Locked = bool.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                Account.PassChange = DateTime.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                UpdatedAccounts.Add(Account);
            }
            dataHandler.UpdateData(UpdatedAccounts);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Accounts = dataHandler.GetAccounts();
            var newAccount = new Account();

            newAccount.Id = Accounts.OrderByDescending(x => x.Id).First().Id + 1;
            newAccount.Login = textBox2.Text;
            newAccount.Password = textBox1.Text;
            newAccount.Admin = false;
            newAccount.Locked = false;
            newAccount.PassChange = DateTime.Now;
            Accounts.Add(newAccount);
            dataHandler.UpdateData(Accounts);
            dataGridView1.DataSource = dataHandler.GetAccounts();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Accounts = dataHandler.GetAccounts();

            Accounts.Remove(Accounts.Where(x => x.Id.ToString() == textBox3.Text).First());
            dataHandler.UpdateData(Accounts);
            dataGridView1.DataSource = dataHandler.GetAccounts();
        }
    }
}
