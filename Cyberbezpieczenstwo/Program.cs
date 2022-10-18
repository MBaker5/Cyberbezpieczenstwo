
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cyberbezpieczenstwo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        public static string LogFromTxt(string log, string pass)
        {
            //string startupPath = Environment.CurrentDirectory;
            //string txtPath = startupPath + @"pass.txt";
            //string[] lines = File.ReadAllLines(pass);
            StreamReader ab = new StreamReader("pass.txt");

            string line1 = ab.ReadLine();
            string line2 = ab.ReadLine();
            
            while ((line1 != null) && (line2 != null))
            {
                if ((line1 == username) && (line2 == pass))
                {
                    Console.WriteLine("Welcome");
                    break;
                }
                Console.WriteLine("Try Again");

                username = Console.ReadLine();
                pass = Console.ReadLine();
            }
        }
       
            

            
    }
}