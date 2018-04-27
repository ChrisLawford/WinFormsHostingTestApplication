using System;
using System.Windows.Forms;

namespace WinFormsHostingTestApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddWPF_Click(object sender, EventArgs e)
        {
            HostingForm form1 = new HostingForm();
            form1.AttachControl(new WPFcontrol());

            form1.Show();
        }

        private void AddWinForms_Click(object sender, EventArgs e)
        {

            HostingForm form1 = new HostingForm();
            form1.AttachControl(new WinFormsControl());

            form1.Show();
        }
    }
}
