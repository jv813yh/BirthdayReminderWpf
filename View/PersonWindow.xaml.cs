/*
 * PersonWindow.cs
 * 
 *
 * 
 * Author: Jozef Vendel
 * Version: 1.0.0
 * Date: 10/09/2023
 * 
 */

using BirthdayReminderWpf.ViewModel;
using System;
using System.Windows;

namespace BirthdayReminderWpf.View
{
    /// <summary>
    /// Interaction logic for PersonWindow.xaml
    /// </summary>
    public partial class PersonWindow : Window
    {
        /// <summary>
        /// 
        /// </summary>
        private BirthDayReminderViewModel viewModelPersonWindow;
        public PersonWindow(BirthDayReminderViewModel viewModel)
        {
            InitializeComponent();
            //
            viewModelPersonWindow = viewModel;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPerson_ClickBtn(object sender, RoutedEventArgs e)
        {
            try
            {
                viewModelPersonWindow.AddPerson(nameTextBox.Text, birthdayDatePicker.SelectedDate);
                viewModelPersonWindow.SavePersons(viewModelPersonWindow._workWithPersons);
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void CloseWindow_ClickBtn(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
