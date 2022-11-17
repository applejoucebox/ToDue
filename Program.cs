using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDue
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // starting out with empty taskList
            ToDue.Models.TaskList tasks = new ToDue.Models.TaskList();

            Application.Run(new HomePage(tasks));
        }
    }
}
