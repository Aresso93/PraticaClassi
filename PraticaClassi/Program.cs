using PraticaClassi.Models;
using System.Collections.Generic;

namespace PraticaClassi
{
    internal class Program
    {
        static void ShowPerson(Person person)
        {
            Console.WriteLine("First name: " + person.FirstName + "\nLast name: " + person.LastName + "\nAge: " + person.Age + "\nJob: " + person.Job);
        }

        static Person CreatePerson()
        {
            Console.WriteLine("Insert your name");
            string nameInput = Console.ReadLine()!.Trim();
            Console.WriteLine("Insert your last name");
            string lastNameInput = Console.ReadLine()!.Trim();
            Console.WriteLine("Insert your occupation");
            string occupationInput = Console.ReadLine()!.Trim();
            Console.WriteLine("Insert your age");
            string ageInput = Console.ReadLine()!.Trim();
            Person createdPerson = new Person();
            createdPerson.FirstName = nameInput;
            createdPerson.LastName = lastNameInput;
            createdPerson.Job = occupationInput;
            int parsedAge;
            bool parsableAge = int.TryParse(ageInput, out parsedAge);
            if (parsableAge)
            {
                createdPerson.Age = parsedAge;

            } else
            {
                Console.WriteLine("Please insert a valid age");
               
            }
            return createdPerson;
        }
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            Console.WriteLine("How many people do you want to add?");
            //string numberOfPeople = Console.ReadLine()!;
            //int convertedNumber = Convert.ToInt32(numberOfPeople);
            for (int i = 0; i < 3; i++)
            {
                people.Add(CreatePerson());

            }
            Console.WriteLine("Insert the last name of the person you want to doxx");
            string input = Console.ReadLine()!;
            Person foundPerson = null;
            foreach (var person in people)
            {
                if (person.LastName.ToLower() == input.ToLower())
                {
                    foundPerson = person;
                    ShowPerson(foundPerson);
                    break;
                };
            }
            if (foundPerson == null)
            {
                Console.WriteLine("No such person exists");
            }
        }
    }
}
