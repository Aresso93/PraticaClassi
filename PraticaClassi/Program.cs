using PraticaClassi.Models;

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
            Person steveStevenson = new Person();
            steveStevenson.FirstName = "Steve";
            steveStevenson.LastName = "Stevenson";
            steveStevenson.Age = 32;
            steveStevenson.Job = "Programmer";

            Person johnJohnson = new Person();
            johnJohnson.FirstName = "John";
            johnJohnson.LastName = "Johnson";
            johnJohnson.Age = 24;
            johnJohnson.Job = "Professional thief";

            Person mariannaRossi = new Person();
            mariannaRossi.FirstName = "Marianna";
            mariannaRossi.LastName = "Rossi";
            mariannaRossi.Age = 19;
            mariannaRossi.Job = "Serial killer";

            Person ermannoErmannini = new Person();
            ermannoErmannini.FirstName = "Ermanno";
            ermannoErmannini.LastName = "Ermannini";
            ermannoErmannini.Age = 56;
            ermannoErmannini.Job = "God";

            Person andrewMowlinars = new Person();
            andrewMowlinars.FirstName = "Andrew";
            andrewMowlinars.LastName = "Mowlinars";
            andrewMowlinars.Age = 29;
            andrewMowlinars.Job = "Cutscene watcher";

            Person[] people = [ steveStevenson, andrewMowlinars, ermannoErmannini, mariannaRossi, johnJohnson ];

            Console.WriteLine("Insert the last name of the person you want to doxx");
            string input = Console.ReadLine()!;
            Person foundPerson = null;
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].LastName.ToLower() == input.ToLower()) {
                    foundPerson = people[i]; 
                    ShowPerson(foundPerson);
                    break;
                } 
                    
                };
            if (foundPerson == null)
            {
                Console.WriteLine("No such person exists");
            }
            
        }
    }
}
