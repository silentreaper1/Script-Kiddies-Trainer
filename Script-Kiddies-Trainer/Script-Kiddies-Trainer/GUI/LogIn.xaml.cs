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
using Script_Kiddies_Trainer.GUI;

namespace Script_Kiddies_Trainer.GUI
{

    public partial class LogIn : Window
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e) { if (e.ChangedButton == MouseButton.Left) this.DragMove(); }

        private void LogIn_Close_MouseDown(object sender, MouseButtonEventArgs e) { this.Close(); }

        private void LogIn_Button_Click(object sender, RoutedEventArgs e)
        {
            MainForm MainForm = new MainForm();
            MainForm.Show();
            this.Close();
        }
    }
}
