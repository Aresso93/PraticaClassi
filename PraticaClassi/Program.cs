using PraticaClassi.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.IO;

namespace PraticaClassi
{
    internal class Program
    {
        static void ShowAltPerson(AltPerson person)
        {
            Console.WriteLine("First name: " + person?.FirstName +
                "\nLast name: " + person?.LastName +
                "\nGender: " + person?.Gender +
                "\nEmail address: " + person?.EmailAddress +
                "\nID: " + person?.ID +
                "\n----------------------------------------"
                );
        }

        static int CountResults(AltPerson[] altPeople, string str)
        {
            int count = 0;
            foreach (var person in altPeople)
            {
                if (person?.LastName.ToLower() == str.ToLower()
                    || person?.FirstName.ToLower() == str.ToLower()
                    || person?.Gender.ToLower() == str.ToLower()
                    || person?.EmailAddress.ToLower() == str.ToLower())
                {
                    count++;
                };
            }
            return count;
        }

        static void Main(string[] args)
        {
            string path = "C:\\Users\\fiumicelli\\source\\repos\\PraticaClassi\\PraticaClassi\\bin\\Debug\\net8.0\\MOCK_DATA.csv";
            string[] stringArray = File.ReadAllLines(path);
            AltPerson[] altPeople = new AltPerson[stringArray.Length];
            
            for (int i = 1; i < stringArray.Length; i++)
            {
                string[] arrayDiStringhine = stringArray[i].Split(',');
                AltPerson createdPerson = new AltPerson();
                createdPerson.ID = arrayDiStringhine[0];
                createdPerson.FirstName = arrayDiStringhine[1];
                createdPerson.LastName = arrayDiStringhine[2];
                createdPerson.EmailAddress = arrayDiStringhine[3];
                createdPerson.Gender = arrayDiStringhine[4];
                altPeople[i] = createdPerson;
            }
            Console.WriteLine("Search our database of wonderful people");
            string input = Console.ReadLine()!;
            AltPerson foundPerson = null;
            int arrayLength = CountResults(altPeople, input);
            AltPerson[] filteredAltPeople = new AltPerson[arrayLength];
            AltPerson[] nonFilteredPeople = new AltPerson[altPeople.Length - arrayLength -1];
            Console.WriteLine(filteredAltPeople.Length);
            Console.WriteLine(nonFilteredPeople.Length);
            int indexResult = 0;
            int indexNonResult = 0;
            for (int i = 0; i < altPeople.Length; i++)
                
            {
                AltPerson person = altPeople[i];
                if (person?.LastName.ToLower() == input.ToLower() 
                    || person?.FirstName.ToLower() == input.ToLower() 
                    || person?.Gender.ToLower() == input.ToLower() 
                    || person?.EmailAddress.ToLower() == input.ToLower())
                {
                    foundPerson = person;
                    //ShowAltPerson(foundPerson);
                    filteredAltPeople[indexResult] = person;
                    indexResult++;


                } 
                else
                {
                    nonFilteredPeople[indexNonResult] = altPeople[i];
                    //indexNonResult++;
                }
            }
            Console.WriteLine("Lunghezzine" + filteredAltPeople.Length + nonFilteredPeople.Length);
            if (foundPerson == null)
            {
                Console.WriteLine("No such person exists");
            }

            for (int i = 0; i < filteredAltPeople.Length; i++)
            {
                for (int j = i+1; j < filteredAltPeople.Length; j++)
                {
                    if (string.Compare(filteredAltPeople[i]?.LastName, filteredAltPeople[j]?.LastName) != -1)
                    {
                        AltPerson filteredPerson = filteredAltPeople[j];
                        filteredAltPeople[j] = filteredAltPeople[i];
                        filteredAltPeople[i] = filteredPerson;
                    }
                }
                ShowAltPerson(filteredAltPeople[i]);             
            }
        }
    }
}