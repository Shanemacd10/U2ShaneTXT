//Shane MacDonald
//March 29, 2018
//U2ShaneTXTMSG
//Program takes input text and translate shortforms on the translation table
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

namespace U2ShaneTXTMSG
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
        
         
        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
                if (txtInput.Text == "TTYL")
                {
                MessageBox.Show("talk to you later");
                Environment.Exit(0);
                }
                txtInput.Text = txtInput.Text.Replace("TTYL", "talk to you later");
                txtInput.Text = txtInput.Text.Replace(":-)", "I'm happy");
                txtInput.Text = txtInput.Text.Replace(":-(", "I'm sad");
                txtInput.Text = txtInput.Text.Replace(";-)", "wink");
                txtInput.Text = txtInput.Text.Replace(":-P", "stick out my toungue");
                txtInput.Text = txtInput.Text.Replace("~.~", "sleepy");
                txtInput.Text = txtInput.Text.Replace("TA", "totally awesome");
                txtInput.Text = txtInput.Text.Replace("CCC", "Canadian Computing Competition");
                txtInput.Text = txtInput.Text.Replace("CUZ", "because");
                txtInput.Text = txtInput.Text.Replace("TY", "thank-you");
                txtInput.Text = txtInput.Text.Replace("YW", "you're welcome");
                txtInput.Text = txtInput.Text.Replace("CU", "see you");
          
        }
    }
}
