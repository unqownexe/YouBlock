using System;
using System.Diagnostics;
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
            Application.Run(new Form1());
            while (true)
            {
                Process[] procsChrome = Process.GetProcesses();

                foreach (Process proc in procsChrome)
                {
                    if (!String.IsNullOrEmpty(proc.MainWindowTitle))
                    {
                        if (proc.MainWindowTitle.Contains("YouTube"))
                        {
                            proc.Kill();
                            MessageBox.Show("MEB.Certificate is Undefined","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
            
        }
    }
}
