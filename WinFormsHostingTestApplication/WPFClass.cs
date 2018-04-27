using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsHostingTestApplication
{
    public class WPFClass : ObservableObject
    {
        private SnackbarMessageQueue m_messagequeue;

        public WPFClass()
        {
            MessageQueue = new SnackbarMessageQueue();
        }
        public SnackbarMessageQueue MessageQueue { get { return m_messagequeue; } set { m_messagequeue = value; OnPropertyChanged("MessageQueue"); } }


        public void On_button_Click()
        {
            Task.Factory.StartNew(() => MessageQueue.Enqueue("We did it!!"));
        }
    }
}
