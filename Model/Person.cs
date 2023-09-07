/*
 * Person.cs
 * 
 *  The code defines the person class, 
 *  which is used to store data for persons
 * 
 * Author: Jozef Vendel
 * Version: 1.0.0
 * Date: 07/09/2023
 * 
 */

using System;

namespace BirthdayReminderWpf.Model
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public Person(string name, DateTime date)
        {
            Name = name;
            Date = date;
        }
    }
}
