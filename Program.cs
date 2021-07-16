using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPhoneDic
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DBContext db = DBContext.Instance();
            //Utility util = new Utility();
            //MessageBox.Show(util.LevenshteinDistance("aloalo","whatthehell").ToString());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PhoneBook());
            
        }
    }
}
