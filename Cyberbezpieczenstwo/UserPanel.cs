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
            this.Welcome.Text = "Witaj " + User.Login;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != this.user.Password){ Welcome.Text = "bledne hasło!"; }
            if (textBox2.Text == this.user.Password)
            {
                var datahandler = new DataHandler();
                var Accounts = datahandler.GetAccounts();
                Accounts.Where(x=>x.Id==this.user.Id).FirstOrDefault().Password= textBox1.Text;
                datahandler.UpdateData(Accounts);
                Welcome.Text = "haslo zmienione";
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
    }
}
