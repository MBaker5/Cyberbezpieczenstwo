using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberbezpieczenstwo.Classes
{
    internal class CaptchaHandler
    {
        Random rnd;
        int a, b;
        string Question,Operation;
        string Operations = "-+*";

        public CaptchaHandler()
        {
            rnd = new Random();
            a = rnd.Next(0, 11);
            b = rnd.Next(0, 11);
            Operation = Operations[rnd.Next(0, Operations.Length)].ToString();
            Question = "" + a.ToString() + Operation + b.ToString() + "=?";
        }
    
       public bool CheckAnwser(string operation,int x)
        {
            int y=-99;
            switch (operation) 
            {
                case "+": 
                {
                        y = a + b;
                        break;  
                }

                case "-":
                    {
                        y = a - b;
                        break;
                    }

                case "*":
                    {
                        y = a * b;
                        break;
                    }

            }

            if (x == y & x!=-99) { return true; }
            else { return false; }

        }

        public Bitmap GetImg()
        {
            var img = new Bitmap(300, 100);
            var font = new Font("Arial", 60, FontStyle.Bold, GraphicsUnit.Pixel);
            var graphic = Graphics.FromImage(img);
            graphic.DrawString(Question, font, Brushes.BlueViolet, new Point(50, 10));
            int counter = 0;
            SolidBrush sb;
            while(counter<4000)
            {
                sb = new SolidBrush(Color.BurlyWood);
                graphic.FillEllipse(sb, rnd.Next(0, 300), rnd.Next(0, 100), 4, 2);
                counter++;
            }
            while(counter > 3960) 
            {
                graphic.DrawLine(new Pen(Color.Red), rnd.Next(0, 300), rnd.Next(0, 100), rnd.Next(0, 300), rnd.Next(0, 100));
                counter--;
            }
            while (counter > 3920)
            {
                graphic.DrawLine(new Pen(Color.Cyan), rnd.Next(0, 300), rnd.Next(0, 100), rnd.Next(0, 300), rnd.Next(0, 100));
                counter--;
            }

            return img;
        
        }



    
    }
}
