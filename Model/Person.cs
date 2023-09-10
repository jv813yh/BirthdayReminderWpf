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
        public DateTime DateOfBirth { get; set; }

        int age = -1;

        /// <summary>
        /// 
        /// </summary>
        public int Age 
        {
            get 
            {
                int comapreResult;

                DateTime today = DateTime.Now;
                comapreResult = DateTime.Compare(today, DateOfBirth);

                if(comapreResult > 0)
                {
                    age = today.Year - DateOfBirth.Year - 1;
                }
                else
                {
                    age = today.Year - DateOfBirth.Year;
                }

                return age;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double DaysLeft
        {
            get
            {
                double daysLeft = -1;

                DateTime nextBirthday = DateOfBirth.AddYears(Age + 1);

                TimeSpan timeSpan = nextBirthday - DateTime.Now;

                daysLeft = timeSpan.TotalDays;

                return daysLeft;
            }
        }

        public Person(string name, DateTime date)
        {
            Name = name;
            DateOfBirth = date;
        }

        public Person()
        {

        }

        public override string ToString()
        {
            return Name;
        }
    }
}
