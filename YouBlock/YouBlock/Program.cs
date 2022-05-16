using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouBlock
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            Console.WriteLine("Started");
            for (int i = 0; i < 1;)
            {
                Process[] procsChrome = Process.GetProcessesByName("chrome");
                if (procsChrome.Length >= 1)
                {

                    foreach (Process proc in procsChrome)
                    {
                        if (!String.IsNullOrEmpty(proc.MainWindowTitle))
                        {
                            if (proc.MainWindowTitle.Contains("YouTube"))
                            {
                                proc.Kill();
                                MessageBox.Show("MEB.Certificate is Undefined", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                    }
                }
            }
            Application.Run(new Form1());

        }
    }
}
