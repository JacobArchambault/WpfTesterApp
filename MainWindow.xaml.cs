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

namespace WpfTesterApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Closed += MainWindow_OnClosed;
            Closing += MainWindow_Closing;
        }

        private void MainWindow_OnClosed(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye!");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You clicked the button!");
            if ((bool) Application.Current.Properties["GodMode"]){
                MessageBox.Show("Cheater!");
            }
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            Title = $"Current mouse position: {e.GetPosition(this)}";
        }
        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // See if the user really wants to shud down this window.
            string msg = "Do you really want to close without saving?";
            MessageBoxResult result = MessageBox.Show(msg, "My App", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
