using Dev_Team_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komomo_Console
{


    class ProgramUI
    {

        // method that runs/starts the application
    public void Run()
        {
            Menu();
        }

        //menu

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {




                // display our options to the user
                Console.WriteLine("Select a menu option:\n" +
                        "1. Create New Content\n" +
                        "2. View All Content\n" +
                        "3. View Content By Name\n" +
                        "4. Update Existing Content\n" +
                        "5. Delete Existing Content\n" +
                        "6. Exit");

                // get the users input
                string input = Console.ReadLine();

                //evalutate the users input and act accordingly
                switch (input)
                {
                    case "1":
                        //create new content
                        CreateNewContent();
                        break;
                    case "2":
                        //view all content
                        DisplayAllContent();
                        break;
                    case "3":
                        //view content by title
                        DisplayContentByName();
                        break;
                    case "4":
                        //update existing content
                        UpdateExistingContent();
                        break;
                    case "5":
                        //delete existing content
                        DeleteExistingContent();
                        break;
                    case "6":
                        //exit
                        Console.WriteLine("Goodbye!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;

                }

                Console.WriteLine("please press any key to continue...");
                Console.ReadKey();
                Console.Clear();

            }
        }

        //creat new devTeam
        private void CreateNewContent()
        {
            DevTeam newContent = new DevTeam();

            //name
            Console.WriteLine("Enter your Name");
            newContent.TeamMember = Console.ReadLine();

            //identification number
            Console.WriteLine("Enter your ID number");
            string idAsString = Console.ReadLine();
            newContent.IdNumber = int.Parse(idAsString);


            //access to plural sight
            Console.WriteLine("Enter the Id number for the people with access to pluralsight");
            string pluralSightString = Console.ReadLine();
            
            if(pluralSightString == "1")
            {
                newContent.PluralSight = true;
            }
            else
            {
                newContent.PluralSight = false;
            }
        }

        // vew current devteam that is saved
        private void DisplayAllContent()
        {

        }
        //view existing content by name
        private void DisplayContentByName()
        {

        }
        //update existing content
        private void UpdateExistingContent()
        {

        }
        //delete existing content
        private void DeleteExistingContent()
        {

        }
    }
}
