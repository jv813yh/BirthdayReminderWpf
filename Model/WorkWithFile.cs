/*
 * WorkWithFile.cs
 * 
 *
 * 
 * Author: Jozef Vendel
 * Version: 1.0.0
 * Date: 10/09/2023
 * 
 */

using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Xml.Serialization;

namespace BirthdayReminderWpf.Model
{
    public class WorkWithFile
    {
        /// <summary>
        /// 
        /// </summary>
        private string pathFile = "persons.xml";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="people"></param>
        /// <exception cref="Exception"></exception>
        public void SavePersons(ObservableCollection<Person> people)
        {
            try
            {
                //
                XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Person>));

                //
                using (StreamWriter sw = new StreamWriter(pathFile))
                {
                    serializer.Serialize(sw, people);
                }
            }
            catch (Exception)
            {

                throw new Exception("Failed to save people to file");
            }
        }

    }
}
