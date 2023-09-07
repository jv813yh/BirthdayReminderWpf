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

namespace BirthdayReminderWpf.View
{
    /// <summary>
    /// Interaction logic for PersonWindow.xaml
    /// </summary>
    public partial class PersonWindow : Window
    {
        public PersonWindow()
        {
            InitializeComponent();
        }

        private void AddPerson_ClickBtn(object sender, RoutedEventArgs e)
        {

        }

        private void CloseWindow_ClickBtn(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
