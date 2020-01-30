using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics
namespace janjoZadatakKlasaProces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Process.Start("IExplore.exe"); 
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Process.Start("winword.exe");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Process.Start("winexcel.exe");
        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }
        ProcessStartInfo startInfo = new
            ProcessStartInfo("IExplore.exe");
        startInfo.WindowStyle = ProcessWindowStyle.Normal;
        startInfo.Arguments = "www.sser.hr";
        Process.Start(startInfo);

    }
}
