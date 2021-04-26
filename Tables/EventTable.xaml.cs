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

using hci2021.Dialogs;

namespace hci2021.Tables
{
    /// <summary>
    /// Interaction logic for EventTable.xaml
    /// </summary>
    public partial class EventTable : Window
    {
        public EventTable()
        {
            InitializeComponent();
        }

        private void ShowTypeDialog(object sender, RoutedEventArgs e)
        {
            var s = new TypeDialog();
            s.Show();
        }

    }
}
