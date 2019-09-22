using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountDownApp
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 theForm = new Form1();

            var Config = new Configuration();

            Config.ParseJSON(null);

            theForm.SetConfig(Config);

            Application.Run(theForm);

        }
    }
}
