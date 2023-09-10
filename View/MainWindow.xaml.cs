using System.Windows;
using System.Windows.Input;
using BirthdayReminderWpf.View;
using BirthdayReminderWpf.ViewModel;
using BirthdayReminderWpf.Model;
using System.Linq;

namespace BirthdayReminderWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// 
        /// </summary>
        private BirthDayReminderViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();

            viewModel = new BirthDayReminderViewModel();

            DataContext = viewModel._workWithPersons;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPersonClickBtn(object sender, RoutedEventArgs e)
        {
            PersonWindow person = new PersonWindow(viewModel);
            person.ShowDialog();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemovePersonClickBtn(object sender, RoutedEventArgs e)
        {
            if(personListBox.SelectedItem != null)
            {
                viewModel.RemovePerson((Person)personListBox.SelectedItem);
            }
        }
    }

    
}
