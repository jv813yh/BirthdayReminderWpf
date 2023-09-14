/*
 * WorkWithCalendar.cs
 * 
 *  
 * 
 * Author: Jozef Vendel
 * Version: 1.0.0
 * Date: 12/09/2023
 * 
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace BirthdayReminderWpf.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class NameDay
    {
        public string Date { get; set; }

        public string Names { get; set; }

        public NameDay(string date, string names)
        {
            Date = date;
            Names = names;
        }
    }

    public class WorkWithCalendar
    {
        /// <summary>
        /// 
        /// </summary>
        private string pathCalendar = "inputCalendar.txt";

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string WhoHasNameDay()
        {
            List<NameDay> nameDays = ReturnNamesList();

            return ReturnNames(nameDays);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="namesList"></param>
        /// <returns></returns>
        private string ReturnNames(List<NameDay> namesList)
        {
            string dateString = "d. MMMM";
            DateTime today = DateTime.Now;
            StringBuilder namesBuilder = new StringBuilder();

            //
            foreach (var nameDay in namesList)
            {
                if (DateTime.TryParseExact(nameDay.Date, dateString,
                    CultureInfo.GetCultureInfo("sk-SK"), DateTimeStyles.None,
                    out DateTime parseDate))
                {
                    if (today.Day == parseDate.Day && today.Month == parseDate.Month)
                    {

                        namesBuilder.Append(nameDay.Names);
                    }
                }
            }

            return namesBuilder.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private List<NameDay> ReturnNamesList()
        {

            List<NameDay> days = new List<NameDay>();

            try
            {
                using (StreamReader sr = new StreamReader(pathCalendar))
                {
                    string s, date = "", names = "";
                    int aDate = 0, bNames = 0;

                    while ((s = sr.ReadLine()) != null)
                    {

                        if (!string.IsNullOrEmpty(s))
                        {
                            if (s.Contains('.'))
                            {
                                date = String.Empty;
                                date = s.Trim();
                                aDate++;
                            }
                            else
                            {
                                names = String.Empty;
                                names = s.Trim();
                                bNames++;
                            }
                        }
                        if
                            ((aDate == 1) && (bNames == 1))
                        {
                            days.Add(new NameDay(date, names));

                            aDate = 0;
                            bNames = 0;
                        }

                    }
                }
            }
            catch (Exception)
            {

                throw new Exception("There was a problem detecting who has name day");
            }

            return days;
        }
    }
}

