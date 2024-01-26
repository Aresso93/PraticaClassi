using PraticaClassi.Models;

namespace PraticaClassi
{
    internal class Program
    {
        static string ShowPerson(Person person)
        {          
            Console.WriteLine("First name: " + person.FirstName);
            Console.WriteLine("Last name: " + person.LastName);
            Console.WriteLine("Age: " + person.Age);
            Console.WriteLine("Job: " + person.Job);
            
            string stringedLastname = person.LastName.ToString();
            return stringedLastname;
        }

        static void Main(string[] args)
        {
            Person stevenson = new Person();
            stevenson.FirstName = "Steve";
            stevenson.LastName = "Stevenson";
            stevenson.Age = 32;
            stevenson.Job = "Programmer";

            Person johnson = new Person();
            johnson.FirstName = "John";
            johnson.LastName = "Johnson";
            johnson.Age = 24;
            johnson.Job = "Professional thief";

            Person rossi = new Person();
            rossi.FirstName = "Marianna";
            rossi.LastName = "Rossi";
            rossi.Age = 19;
            rossi.Job = "Serial killer";

            Person ermannini = new Person();
            ermannini.FirstName = "Ermanno";
            ermannini.LastName = "Ermannini";
            ermannini.Age = 56;
            ermannini.Job = "God";

            Person mowlinars = new Person();
            mowlinars.FirstName = "Andrew";
            mowlinars.LastName = "Mowlinars";
            mowlinars.Age = 29;
            mowlinars.Job = "Cutscene watcher";

            //Person[] people = [ steveStevenson, andrewMowlinars, ermannoErmannini, mariannaRossi, johnJohnson ];

            Console.WriteLine("Insert the last name of the person you want to doxx");
            //DoxPerson()
            Console.ReadLine();
            
        }




    }
}
