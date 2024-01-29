using PraticaClassi.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace PraticaClassi
{
    internal class Program
    {
        static void ShowPerson(Person person)
        {
            Console.WriteLine("First name: " + person.FirstName + "\nLast name: " + person.LastName + "\nAge: " + person.Age + "\nJob: " + person.Job);
        }

        static void Main(string[] args)
        {          
            string path = "MOCK_DATA.csv";
            List<AltPerson> altPeople = new List<AltPerson>();
            string[] stringArray = File.ReadAllLines(path);
            for (int i = 1; i < stringArray.Length; i++)
            {
                string[] arrayDiStringhine = stringArray[i].Split(',');
                AltPerson createdPerson = new AltPerson();
                createdPerson.FirstName = arrayDiStringhine[1];
                createdPerson.LastName = arrayDiStringhine[2];
                createdPerson.EmailAddress = arrayDiStringhine[3];
                createdPerson.Gender = arrayDiStringhine[4];
                altPeople.Add(createdPerson);
            }
            Console.WriteLine("Search our database of wonderful people");
            string input = Console.ReadLine()!;
            AltPerson foundPerson = null;
            List<AltPerson> filteredAltPeople = new List<AltPerson>();
            foreach (var person in altPeople)
            {
                if (person.LastName.ToLower() == input.ToLower() 
                    || person.FirstName.ToLower() == input.ToLower() 
                    || person.Gender.ToLower() == input.ToLower() 
                    || person.EmailAddress == input.ToLower())
                {
                    foundPerson = person;
                    //ShowAltPerson(foundPerson);
                    filteredAltPeople.Add(foundPerson);
                };
            }

            for (int k = 0; k < filteredAltPeople.Count; k++)
            {
                for (int l = k; l < filteredAltPeople.Count; l++)
                {
                    if (string.Compare(filteredAltPeople[k].LastName, filteredAltPeople[l].LastName) != -1)
                    {
                       AltPerson filteredPerson = filteredAltPeople[l];
                        filteredAltPeople[l] = filteredAltPeople[k];
                        filteredAltPeople[k] = filteredPerson;
                    }
                }
                Console.WriteLine("First name: " + filteredAltPeople[k].FirstName + 
                    "\n" + "Last name: " + filteredAltPeople[k].LastName + 
                    "\n" + "Gender: " + filteredAltPeople[k].Gender + 
                    "\n" + "Email address: " + filteredAltPeople[k].EmailAddress +
                    "\n" + "-------------------------------------------------------"
                    );
            }

            if (foundPerson == null)
            {
                Console.WriteLine("No such person exists");
            }
        }
    }
}