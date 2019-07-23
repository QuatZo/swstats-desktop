using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Summoners_War_Statistics
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            XmlConfigurator.Configure();
            Logger.log.Info($"Starting app....");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IView view = new FormMain();
            Model model = new Model();

            Presenter presenter = new Presenter(view, model);
            Application.Run((FormMain)view);
            Logger.log.Info($"Closing app....");
            Logger.log.Info($"-----------------------------------");
        }
    }
}
