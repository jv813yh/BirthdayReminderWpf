/*
 * WorkWithPersons.cs
 * 
 *
 * 
 * Author: Jozef Vendel
 * Version: 1.0.0
 * Date: 08/09/2023
 * 
 */

using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;

namespace BirthdayReminderWpf.Model
{
    public class WorkWithPersons: INotifyPropertyChanged
    {
        public  ObservableCollection<Person> Persons { get; set; }

        public DateTime todayDate
        {
            get
            {
                return DateTime.Now;
            }
        }

        public Person ClosestPerson { get; set; }

        public WorkWithPersons()
        {
            Persons = new ObservableCollection<Person>();
        }

        /// <summary>
        /// 
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="property"></param>
        protected void WasChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        /// <summary>
        /// 
        /// </summary>
        private void FindClosestPerson()
        {
            var orderedPersons = Persons.OrderBy(person => person.DaysLeft);
            if (orderedPersons.Any())
            {
                ClosestPerson = orderedPersons.First();
            }
            else
                ClosestPerson = null;

            WasChanged(nameof(ClosestPerson));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dateOfBirth"></param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        public void AddPerson(string name, DateTime? dateOfBirth)
        {
            if (name.Length < 2)
                throw new ArgumentException("Name is too short, enter more than 2 characters");
            if (dateOfBirth == null)
                throw new ArgumentNullException("Date of birth was not entered");
            if (dateOfBirth.Value.Date > DateTime.Today)
                throw new ArgumentException("The date of birth must not be in the future");

            Persons.Add(new Person(name, dateOfBirth.Value.Date));

            FindClosestPerson();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="person"></param>
        public void RemovePerson(Person person)
        {
            Persons.Remove(person);
            FindClosestPerson();
        }
    }
}
