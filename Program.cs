using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheConversation
{


    //*************************************************************
    // Application: The Conversation
    // Author: Hodges, Nate C
    // Description: An app that you have a small conversation with
    // about Pets.
    // Created: 8/27/19 10:37 p.m.
    // Revised: 8/28/19 1:24 p.m.
    //*************************************************************

    class Program
    {
        static void Main(string[] args)
        {
            //
            // variables
            //
            string username;
            string catOrDog;
            string petName;
            string breed;
            string userResponse = "yes";

            //
            // enter conversation with user
            //
            Console.WriteLine("Hello!!");
            Console.WriteLine("My Name is Wattson!");
            Console.WriteLine(":D");

            //
            // aquire name
            //
            Console.WriteLine();
            Console.WriteLine("What is your name?");
            username = Console.ReadLine();
            Console.WriteLine("It is nice to meet you " + username + ".");
            //Console.WriteLine("It is nice to meet you {0}.", username);
            //Console.WriteLine($"It is nice to meet you {username}.");

            //
            // determine if the user has pets
            // if user say yes, ask questions. 
            // if no, say goodbye
            //

            Console.WriteLine();
            Console.WriteLine("Do you own a pet " + username + "?");
            userResponse = Console.ReadLine();

            Console.WriteLine();
            {
                if (userResponse == "no")
                    Console.WriteLine("Alright "+ username + ".");
                    Console.ReadKey();
            }

            Console.WriteLine();
            if (userResponse == "yes")
            {
                //
                //Get user's animal type
                //
                Console.WriteLine();
                Console.WriteLine("Glad to hear you own a pet, They're the best companions!");
                Console.WriteLine("Do you own a Cat or Dog?");
                catOrDog = Console.ReadLine();

                //
                // get the user's breed of animal.
                //
                Console.WriteLine();
                Console.WriteLine("What kind of breed is your pet?");
                breed = Console.ReadLine();

                //
                // get the user's pet name.
                //
                Console.WriteLine();
                Console.WriteLine("What is the pet's name?");
                petName = Console.ReadLine();
                Console.WriteLine("That's a cute name, I love it!");
            }
            {
                Console.WriteLine();
                Console.WriteLine($"{username}, it has been nice meeting you and talking about your pet! Have a nice day!");
                Console.WriteLine(":D");
            }
            {
                Console.WriteLine();
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
        }
    }
}





            