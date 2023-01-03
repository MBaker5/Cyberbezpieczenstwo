using Cyberbezpieczenstwo.Classes;
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
    public partial class CaptchaForm : Form
    {
        CaptchaHandler cHandler;
        public CaptchaForm()
        {
            cHandler = new CaptchaHandler();
            InitializeComponent();
            CaptchapicBox.Image = cHandler.GetImg();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (Check() == true)
            {
               this.Close();
            }
            else 
            {
                CaptchapicBox.Image = cHandler.GetImg();
            }
        }

        public bool Check () 
        {
            int answer = Int32.Parse(textBox4.Text);
            if (cHandler.CheckAnwser(textBox2.Text, answer) == true)
            {
                return true;
            }
            else return false;
        }
        

        
    }
}
