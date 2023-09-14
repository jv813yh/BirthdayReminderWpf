/*
 * BirthDayReminderViewModel.cs
 * 

 * 
 * Author: Jozef Vendel
 * Version: 1.0.0
 * Date: 09/09/2023
 * 
 */

using BirthdayReminderWpf.Model;
using System;
using System.Collections.ObjectModel;

namespace BirthdayReminderWpf.ViewModel
{
    public class BirthDayReminderViewModel
    {
        public WorkWithPersons _workWithPersons { get; set; }

        private WorkWithFile _workWithFile { get; set; }

        private WorkWithCalendar _workWithCalendar { get; set; }

        public BirthDayReminderViewModel()
        {
            _workWithPersons = new WorkWithPersons();

            _workWithFile = new WorkWithFile();

            _workWithCalendar = new WorkWithCalendar();
        }

        public void AddPerson(string name, DateTime? dateOfBirth)
        {
            _workWithPersons.AddPerson(name, dateOfBirth);
        }

        public void RemovePerson(Person person)
        {
            _workWithPersons.RemovePerson(person);
        }

        public void SavePersons(WorkWithPersons workPersons)
        {
            _workWithFile.SavePersons(workPersons.Persons);
        }

        public void LoadPersons(WorkWithPersons workPersons)
        {
            _workWithFile.LoadPersons(workPersons);
        }

        public string WhoHasNameDay()
        {
            return _workWithCalendar.WhoHasNameDay();
        }
    }
}
