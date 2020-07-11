using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace MailSender
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            EMailInfo info = new EMailInfo();
            info.Sender = cbFrom.Text;
            info.Body = tbBody.Text;
            info.Password = pbPassword.Password;
            info.Port = int.Parse(tbPort.Text);
            info.SMTPClient = tbServer.Text;
            info.Subject = tbSubject.Text;
            info.From = cbFrom.Text;
            info.To = cbTo.Text;
            EmailSendServiceClass emailSendServiceClass = new EmailSendServiceClass();
            emailSendServiceClass.Send(info);
            tbLog.Text += DateTime.Now + "r\n";
            tbLog.Text += emailSendServiceClass.Status + Environment.NewLine;
            tbLog.Text += emailSendServiceClass.ErrorInfo + Environment.NewLine;
        }

        private void tscTabSwitcherControl_btnNextClick(object sender, RoutedEventArgs e)
        {
            tabControl.SelectedIndex = (tabControl.SelectedIndex + 1) % tabControl.Items.Count;
        }

        private void tscTabSwitcherControl_btnPreviousClick(object sender, RoutedEventArgs e)
        {
            if (tabControl.SelectedIndex==0)
            {
              tabControl.SelectedIndex =  tabControl.Items.Count - 1;
            }
            else
            {
                tabControl.SelectedIndex--;
            }

        }



        //private void TscTabSwitcher_btnNextClick(object sender, RoutedEventArgs e)
        //{
        //    tabControl.SelectedIndex = 1;
        //}

        //private void btnPrevios_Click(object sender, RoutedEventArgs e)
        //{

        //}
    }
}
