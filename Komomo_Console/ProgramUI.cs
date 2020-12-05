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
        private DevTeamRepository _contentRepo = new DevTeamRepository();

        // method that runs/starts the application
    public void Run()
        {
            SeedContentList();
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
            Console.Clear();
            DevTeam newContent = new DevTeam();

            //name
            Console.WriteLine("Enter your Name");
            newContent.TeamMember = Console.ReadLine();

            //identification number
            Console.WriteLine("Enter your ID number");
            string idAsString = Console.ReadLine();
            newContent.IdNumber = int.Parse(idAsString);


            //access to plural sight
            Console.WriteLine("Do they have access to pluralsight (y/n)");
            string pluralSightString = Console.ReadLine();
            
            if(pluralSightString == "y")
            {
                newContent.PluralSight = true;
            }
            else
            {
                newContent.PluralSight = false;
            }

            _contentRepo.AddContentToList(newContent);

            /*bool anotherName = Console.WriteLine("Would you like to add another name?");
            if (anotherName == "y")
            {
                anotherName = CreateNewContent();
            }
            else
            {
                return false;
            }
            */
            



        }

        // vew current devteam that is saved
        private void DisplayAllContent()
        {
            Console.Clear();
            List<DevTeam> listOfContent = _contentRepo.GetContentList();
            foreach(DevTeam content in listOfContent)
            {
                Console.WriteLine($"Team member: {content.TeamMember}\n" +
                    $"ID Number: {content.IdNumber}\n" +
                    $"Access to Plural Sight?: {content.PluralSight}");
            }
        }
        //view existing content by name
        private void DisplayContentByName()
        {
            Console.Clear();
            //prompt user to give me a name
            Console.WriteLine("Enter the name you would like to see:");

            // get the users input
            string teamMember = Console.ReadLine();

            // find the content for the name
            DevTeam content = _contentRepo.GetContentByName(teamMember);

            //display said content if it isnt null
            if(content != null)
            {
                Console.WriteLine($"Team member: {content.TeamMember}\n" +
                    $"ID Number: {content.IdNumber}\n" +
                    $"Access to Plural Sight?: {content.PluralSight}");
            }
            else
            {
                Console.WriteLine("name is not in this list");
            }

        }
        //update existing content
        private void UpdateExistingContent()
        {
            //display all content
            DisplayAllContent();

            //ask for the name of the content to update
            Console.WriteLine("enter the name you would like to update:");
            //get the name
            string oldName = Console.ReadLine();

            DevTeam newContent = new DevTeam();

            //name
            Console.WriteLine("Enter your Name");
            newContent.TeamMember = Console.ReadLine();

            //identification number
            Console.WriteLine("Enter your ID number");
            string idAsString = Console.ReadLine();
            newContent.IdNumber = int.Parse(idAsString);


            //access to plural sight
            Console.WriteLine("Do they have access to pluralsight (y/n)");
            string pluralSightString = Console.ReadLine();

            if (pluralSightString == "y")
            {
                newContent.PluralSight = true;
            }
            else
            {
                newContent.PluralSight = false;
            }

            //verify the updated work
            bool wasUpdated = _contentRepo.UpdateExistingContent(oldName, newContent);

            if (wasUpdated)
            {
                Console.WriteLine("content successfully updated.");
            }
            else
            {
                Console.WriteLine("could not update.");
            }

        }
        //delete existing content
        private void DeleteExistingContent()
        {

            DisplayAllContent();


            //get name they want to remove

            Console.WriteLine("\nenter the name you want to remove");

            string input = Console.ReadLine();
            //call delete method
            bool wasDeleted = _contentRepo.RemoveContentFromList(input);


            //if content was deleted, say so
            //otherwise say it wasnt deleted
            if (wasDeleted){
                Console.WriteLine("content was deleted succesfully");
            }
            else
            {
                Console.WriteLine("content was not deleted");
            }

            
        }

        //see method
        private void SeedContentList()
        {
            DevTeam memberOne = new DevTeam("Ben", 1, true);
            DevTeam memberTwo = new DevTeam("Ryan", 2, false);
            DevTeam memberThree = new DevTeam("Andrew", 3, true);

            _contentRepo.AddContentToList(memberOne);
            _contentRepo.AddContentToList(memberTwo);
            _contentRepo.AddContentToList(memberThree);
        }
    }
}
