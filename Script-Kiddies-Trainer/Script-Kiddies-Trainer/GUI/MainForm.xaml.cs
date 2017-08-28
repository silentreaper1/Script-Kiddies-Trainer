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
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;
using SKaob;
using System.IO;
using System.Net;
using Script_Kiddies_Trainer.CS;

namespace Script_Kiddies_Trainer.GUI
{
    public partial class MainForm : Window
    {
        private AOB AoBsCaN = new AOB();
        private Browser Browser = new Browser();
        private Httprequests httprequests = new Httprequests();

        private int processID;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Close_MouseDown(object sender, MouseButtonEventArgs e) { Application.Current.Shutdown(); }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e) { if (e.ChangedButton == MouseButton.Left) this.DragMove(); }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int num = this.Browser.Chrome();
            if (num > 0)
            {
                this.AoBsCaN.OpenProcessid(num);
                processID = num;
                this.label1.Content = "Attached To Chrome Pid : " + num + " / " + num.ToString("X"); ;
            }
            else
            {
                this.label1.Content = "Failed To Attached";
                this.AoBsCaN.processhandle = IntPtr.Zero;
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //AoBsCaN.ReadAOB("E7 E7 E8 E8 E9");
            //AoBsCaN.WriteAOB("11 22 33 44 55");
            //AoBsCaN.ResumeProcess(processID);
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string[] split = httprequests.getgamelist().Split(',');
            foreach (string word in split) { GameList_ListBox.Items.Add(word); }
        }

        private void getsetcodes(int gamenumber)
        {
            string codes = httprequests.gethacklist();
            string vals = codes.Split(',')[gamenumber--];
            MessageBox.Show(vals);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int lala = GameList_ListBox.SelectedIndex;
            //System.Diagnostics.Debug.WriteLine(lala);
            getsetcodes(lala);
        }
    }
}
