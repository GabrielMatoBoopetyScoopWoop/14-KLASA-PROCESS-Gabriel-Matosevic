using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GabrielMatosevicKlasaProcess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InternetExplorerButton_Click(object sender, EventArgs e)
        {
            Process.Start("IExplore.exe");
        }

        private void WordButton_Click(object sender, EventArgs e)
        {
            Process.Start("winword.exe");
        }

        private void ExcelButton_Click(object sender, EventArgs e)
        {
            Process.Start("excel.exe");
        }

        private void StartInfoButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("IExplore.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.Arguments = "www.sser.hr";
            Process.Start(startInfo);
        }
    }
}
