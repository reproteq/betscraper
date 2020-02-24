using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace wsb724
{
    class Program
    {

        [STAThread]
        static void Main()
        {
            Console.WriteLine("Bet History Scraper");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());            

        }
    }
}



