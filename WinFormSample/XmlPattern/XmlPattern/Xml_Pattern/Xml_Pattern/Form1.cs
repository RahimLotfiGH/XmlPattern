using System;
using System.Windows.Forms;
using Xml_Pattern.AppCode;

namespace Xml_Pattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var appName = SystemSetting.AppName;

            MessageBox.Show(appName);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var ports = ServerSetting.Ports;

            foreach (var port in ports)
            {
                MessageBox.Show(port.ToString());
            }
        }
    }
}
