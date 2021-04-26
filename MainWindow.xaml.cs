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
using hci2021.Tables;
using hci2021.Dialogs;

namespace hci2021
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

        private void ShowEventTable(object sender, RoutedEventArgs e)
        {
            var s = new EventTable();
            s.Show();
        }

        private void ShowTypeTable(object sender, RoutedEventArgs e)
        {
            var s = new TypeTable();
            s.Show();
        }

        private void ShowTagTable(object sender, RoutedEventArgs e)
        {
            var s = new TagTable();
            s.Show();
        }

        private void ShowEventDialog(object sender, RoutedEventArgs e)
        {
            var s = new EventDialog();
            s.Show();
        }

        private void ShowTypeDialog(object sender, RoutedEventArgs e)
        {
            var s = new TypeDialog();
            s.Show();
        }

        private void ShowTagDialog(object sender, RoutedEventArgs e)
        {
            var s = new TagDialog();
            s.Show();
        }
    }

    
}
