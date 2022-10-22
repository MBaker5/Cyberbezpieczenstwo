using Cyberbezpieczenstwo.Classes;

namespace Cyberbezpieczenstwo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                        var dataHandler = new DataHandler();
                        var CurAccount = dataHandler.GetAccounts().Where(x=>x.Login==textBox2.Text && x.Password==textBox1.Text);
                        if(CurAccount.Count() == 0) { label3.Text = "b³edny login lub has³o"; }
                        else 
                        {
                if (CurAccount.First().Locked) { label3.Text = "To konto jest zablokowane!"; }
                else
                {
                    if (CurAccount.First().Admin)
                    {
                        AdminPanel AP = new AdminPanel(CurAccount.First());
                        AP.Location = this.Location;
                        AP.StartPosition = FormStartPosition.Manual;
                        AP.FormClosing += delegate { this.Show(); };
                        AP.Show();
                    }
                    else
                    {
                        UserPanel UP = new UserPanel(CurAccount.First());
                        UP.Location = this.Location;
                        UP.StartPosition = FormStartPosition.Manual;
                        UP.FormClosing += delegate { this.Show(); };
                        UP.Show();
                    }

                    this.Hide();
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                        }
         
        }

        private void label3_Click(object sender, EventArgs e)
        { 
           
        }
    }
}