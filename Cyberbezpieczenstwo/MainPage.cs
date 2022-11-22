using Cyberbezpieczenstwo.Classes;

namespace Cyberbezpieczenstwo
{
    public partial class MainPage : Form
    {
        public int BadLoginCounter = 0;
        public bool Lockout = false;
        public DateTime LockoutEnd = DateTime.Now;
        public bool LockoutCheck() 
        {
            if(Lockout&&LockoutEnd < DateTime.Now) { Lockout = false;}

            return Lockout;
        }

        public void LockoutApp() 
        {
            if (!Lockout && BadLoginCounter>=4)
            {
                Lockout = true;
                LockoutEnd = DateTime.Now.AddMinutes(1);
                BadLoginCounter = 0;
                return;
            }
            else
            {
                BadLoginCounter++;
                return;
            }
        }

        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LockoutCheck()) { KomunikatLbl.Text = "Zablokowano logowanie przez zbyt duza ilosc prob\nlogowania wroc pozniej."; }
            else
            {
                var dataHandler = new DataHandler();
                var CurAccount = dataHandler.GetAccounts().Where(x => x.Login == LoginTxtbx.Text && x.Password == passwordTxtbx.Text);
                if (CurAccount.Count() == 0) { KomunikatLbl.Text = "b³edny login lub has³o"; LockoutApp(); }
                else
                {
                    if (CurAccount.First().Locked) { KomunikatLbl.Text = "To konto jest zablokowane!"; }
                    else
                    {
                        var LogHandler = new LogHandler();
                        LogHandler.Log(CurAccount.First(), "Logowanie");

                        if (CurAccount.First().Admin)
                        {
                            AdminPage AP = new AdminPage(CurAccount.First());
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
                        passwordTxtbx.Text = "";
                        LoginTxtbx.Text = "";
                    }
                }

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}