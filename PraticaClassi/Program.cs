using PraticaClassi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Versioning;

namespace PraticaClassi
{
    internal class Program
    {
        static void ShowPerson(Person person)
        {
            Console.WriteLine("First name: " + person.FirstName + "\nLast name: " + person.LastName + "\nAge: " + person.Age + "\nJob: " + person.Job);
        }

        static void ShowAltPerson(AltPerson altPerson)
        {
            Console.WriteLine("First name: " + altPerson.FirstName + "\nLast name: " + altPerson.LastName + "\nGender: " + altPerson.Gender + "\nEmail address: " + altPerson.EmailAddress);
        }
        //static Person CreatePerson()
        //{
        //    Console.WriteLine("Insert your name");
        //    string nameInput = Console.ReadLine()!.Trim();
        //    Console.WriteLine("Insert your last name");
        //    string lastNameInput = Console.ReadLine()!.Trim();
        //    Console.WriteLine("Insert your occupation");
        //    string occupationInput = Console.ReadLine()!.Trim();
        //    Console.WriteLine("Insert your age");
        //    string ageInput = Console.ReadLine()!.Trim();
        //    Person createdPerson = new Person();
        //    createdPerson.FirstName = nameInput;
        //    createdPerson.LastName = lastNameInput;
        //    createdPerson.Job = occupationInput;
        //    int parsedAge;
        //    bool parsableAge = int.TryParse(ageInput, out parsedAge);
        //    if (parsableAge)
        //    {
        //        createdPerson.Age = parsedAge;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Please insert a valid age");
        //        //mettere un while che controlla se è un numero e sennò cicla finché non lo è
        //    }
        //    return createdPerson;
        //}
        static void Main(string[] args)
        {
            //List<Person> people = new List<Person>();           
            string path = "C:\\Users\\fiumicelli\\source\\repos\\PraticaClassi\\PraticaClassi\\MOCK_DATA.csv";
            //string path = ".\\MOCK_DATA.csv";
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
                //Console.WriteLine("First name: " + createdPerson.FirstName + "\nLast name: " + createdPerson.LastName + "\nGender: " + createdPerson.Gender + "\nEmail address: " + createdPerson.EmailAddress);
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
                    {//ordina dal cognome più corto al più lungo
                       AltPerson filteredPerson = filteredAltPeople[l];
                        filteredAltPeople[l] = filteredAltPeople[k];
                        filteredAltPeople[k] = filteredPerson;
                    }
                }
                Console.WriteLine(filteredAltPeople[k].FirstName + " " + filteredAltPeople[k].LastName);
            }

            if (foundPerson == null)
            {
                Console.WriteLine("No such person exists");
            }
        }
    }
}




//Console.WriteLine("How many people do you want to add?");
//string numberOfPeople = Console.ReadLine()!;
//int convertedNumber = Convert.ToInt32(numberOfPeople);
//for (int i = 0; i < 3; i++)
//{
//    people.Add(CreatePerson());

//}
//Console.WriteLine("Insert the last name of the person you want to doxx");
//string input = Console.ReadLine()!;
//Person foundPerson = null;
//foreach (var person in people)
//{
//    if (person.LastName.ToLower() == input.ToLower())
//    {
//        foundPerson = person;
//        ShowPerson(foundPerson);
//        break;
//    };
//}
//if (foundPerson == null)
//{
//    Console.WriteLine("No such person exists");
//}