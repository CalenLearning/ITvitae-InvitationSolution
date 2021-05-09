using System;

namespace InvitationConsoleApp
{
    class Program_V1
    {
        static void Main_V1(string[] args)
        {
            //Gegevens opvragen van de organisator:
            Console.WriteLine("Geef de naam van de organisator op:");
            string organisorName = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Geef de email van de organisator op:");
            string organisorEmail = Console.ReadLine();
            Console.Clear();

            //Gegevens opvragen van de activiteit:
            //(Datum, Titel en Omschrijving van de Activiteit

            Console.WriteLine("Geef de titel van de activiteit op:");
            string activityTitle = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Geef de datum van de activiteit op:");
            string activityDate = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Geef de omschrijving van de activiteit op:");
            string activityDescription = Console.ReadLine();
            Console.Clear();



            Console.WriteLine($"De activiteit wordt georganiseerd door: {organisorName}\nEmail:{organisorEmail}\n");

            Console.WriteLine("Press <ENTER> to exit...");
            Console.ReadLine();
        }

        private static string GetUserInput(string description)
        {
            //Een gebruiker dient te weten welke invoer gevraagd wordt
            Console.WriteLine($"Geef de {description} op:");
            string input = Console.ReadLine();
            Console.Clear();

            return input;
        }
    }

}
