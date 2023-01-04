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
    public partial class AdminPage : Form
    {

        DataHandler dataHandler;
        Account admin;
        List<Account> accounts;
        public AdminPage(Account Admin)
        {

            dataHandler = new DataHandler();
            admin = Admin;
            accounts = dataHandler.GetAccounts();
        

            InitializeComponent();
           
        }




        private void MngUserBtn_Click(object sender, EventArgs e)
        {
            AdminPanel AP = new AdminPanel(admin);
            AP.Location = this.Location;
            AP.StartPosition = FormStartPosition.Manual;
            AP.FormClosing += delegate { this.Show(); };
            AP.Show();
            this.Hide();
        }

        private void ChangepassBtn_Click(object sender, EventArgs e)
        {
          
                EditUser EU = new(accounts.Where(x => x.Id == admin.Id).First(), admin);
                EU.Location = this.Location;
                EU.StartPosition = FormStartPosition.Manual;
                EU.FormClosing += delegate { this.Show(); this.admin = admin;};
                EU.Show();
                this.Hide();

       
        }
    }
}
