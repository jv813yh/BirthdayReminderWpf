using System.Windows;
using System.Windows.Input;
using BirthdayReminderWpf.View;

namespace BirthdayReminderWpf
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

        private void MainWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Click_XButton(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddPersonClickBtn(object sender, RoutedEventArgs e)
        {
            PersonWindow person = new PersonWindow();
            person.ShowDialog();
        }
    }

    
}
