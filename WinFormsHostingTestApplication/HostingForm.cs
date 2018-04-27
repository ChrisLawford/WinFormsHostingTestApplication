using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsHostingTestApplication
{
    public partial class HostingForm : Form
    {
        public HostingForm()
        {
            InitializeComponent();
        }

        public void AttachControl(System.Windows.Forms.UserControl win_forms_user_control)
        {
            Controls.Add(Activator.CreateInstance(win_forms_user_control.GetType()) as System.Windows.Forms.Control);
        }

        public void AttachControl(System.Windows.Controls.UserControl wpf_user_control)
        {

            System.Windows.Forms.Integration.ElementHost element_host = new System.Windows.Forms.Integration.ElementHost() { Dock = System.Windows.Forms.DockStyle.Fill };

            Controls.Add(element_host);

            element_host.Child = wpf_user_control;
        }
    }
}
