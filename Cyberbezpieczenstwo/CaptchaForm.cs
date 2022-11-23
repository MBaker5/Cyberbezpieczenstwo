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
    }
}
