using InvitationConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvitationConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Gegevens opvragen van de organisator:
            Organizer organizer = new Organizer();
            organizer.FullName = GetUserInput("naam van de organisator");
            organizer.Email = GetUserInput("email van de organisator");

            //Gegevens opvragen van de activiteit:
            string activityTitle = GetUserInput("titel van de activiteit");
            //Zorg ervoor dat er om een datum invoer gevraagd wordt en deze als zodaning verwerkt wordt
            DateTime activityDate = DateTime.Parse(GetUserInput("datum van de activiteit"));
            string activityDescription = GetUserInput("omschrijving van de activiteit", false);


            //Aantal personen uitnodigen ( 'vraag wilt u meer uitnodigen..')
            List<Invitee> invitees = new List<Invitee>();

            do
            {
                var invitee = new Invitee();
                invitee.FullName = GetUserInput("naam van de genodigde");
                invitee.Email = GetUserInput("email van de genodigde");
                invitees.Add(invitee);
            } while (GetUserInput("Invoer 'y' als u nog een invitee wilt aanmaken") == "y");

            //Weergeven van alle uitnodigingen per genodigde aan de hand van de StringBuilder
            var sb = new StringBuilder();

            foreach (var invitee in invitees)
            {

            }
            Console.WriteLine($"De activiteit {activityTitle} wordt georganiseerd op {activityDate} door {organizer.FullName}\nOrganisator Email:{organizer.Email}\n\nOmschrijving van de activiteit:\n{activityDescription}");

            Console.WriteLine("Press <ENTER> to exit...");
            Console.ReadLine();
        }
        private static string GetUserInput(string description)
        {
            return GetUserInput(description, true);
        }
        private static string GetUserInput(string description, bool required)
        {
            //Vragen om gebruiker invoer/ tekst
            //Een gebruiker dient te weten welke invoer gevraagd wordt: omschrijving tonen
            //Wanneer er geen input is gegeven dan dient de gebruiker opnieuw invoer te geven wanneer deze verplicht is (zolang er geen input is gegeven dient om input gevraagd te worden)
            //Tonen wanneer invoer verplicht is

            string input;
            do
            {
                Console.WriteLine($"Geef de {description} op{(required ? " (verplicht)" : string.Empty)}:");
                input = Console.ReadLine();
                Console.Clear();

            } while (required && string.IsNullOrWhiteSpace(input));

            return input;
        }


    }

}
