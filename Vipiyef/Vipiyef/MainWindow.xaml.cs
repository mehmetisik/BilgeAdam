using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Vipiyef
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                ListBoxItem lbi = new ListBoxItem();
                lbi.Content = Guid.NewGuid().ToString().Substring(0, 8);
                lbi.Foreground = new SolidColorBrush(Colors.White);
                lbi.Background = new SolidColorBrush(Colors.Blue);
                lbi.Padding = new Thickness(4);
                listBoxGuid.Items.Add(lbi);
            }
        }
    }
}
