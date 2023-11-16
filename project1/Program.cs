using System.Collections.Specialized;

namespace madlibs
{
    class program
    {

        public static void Main(String[] args)
        {
              

            {
                AskToPlay();

                Console.WriteLine($"This is the story of wacky words larry you must provide words for five silly questions that will help wacky larry write his favorite wacky book to read to his son.");

                UserFavAnimal();
                UseryourDragon();
                UsertheOwls();
                UserbestSinger();
                UserparrotAge();            
               
                PlayAgain();
                
            }

            static void AskToPlay()
            {
                Console.WriteLine("Would you like to play Madlibs?");
                string response = Console.ReadLine().ToLower();

                if( response == "yes" )
                {
                    Console.WriteLine("Awesome let's start!");
                    //starting method
                }
                else if( response == "no" )
                {
                    Console.WriteLine("bye fool");
                }
                else
                {
                    Console.WriteLine("I didn't understand that response try again.");
                    AskToPlay();
                }
            } 

             static void UserFavAnimal()
             {
                Console.WriteLine("what is your favorite animal?");
                string favAnimal = Console.ReadLine();

                Console.WriteLine($"There is a world filled with magical {favAnimal}, they loved to frolic and play.");
            }

            static void UseryourDragon()
            {
                Console.WriteLine("where those your dragon dance?");
                string yourDragon = Console.ReadLine();

                Console.WriteLine($"There were also big {yourDragon} flying and dancing every which way you could see there were all types fire, ice, water, and wind.");
            }

            static void UsertheOwls()
            {
                Console.WriteLine("when do the owls wake up daytime/nighttime?");
                string theOwls = Console.ReadLine();

                Console.WriteLine($"There was only a certain time of day when the owls would wake up it was always at {theOwls}");
            }

            static void UserbestSinger()
            {
                Console.WriteLine("who has the best singing voice?");
                string bestSinger = Console.ReadLine();

                Console.WriteLine($"The was a {bestSinger} that would sing lovely melodys that all the creatures would dance to and have wonderful ceremonys too");
            }

            static void UserparrotAge()
            {
                Console.WriteLine("how old is your parrot?");
                string parrotAge = Console.ReadLine();

               Console.WriteLine($"The parrot was the oldest and wildest and most graceful of them all it would have the most wonderful dance despit it ripe old age of {parrotAge}");
            }


            static void PlayAgain()

            {
                Console.WriteLine($"Do you want to play again?");
                string UserInput = Console.ReadLine();

                if (UserInput == "Yes")
                {
                    Console.WriteLine("Ok let's begin!");
                    AskToPlay();
                }
                else 
                { 
                    Console.WriteLine("See ya later Alligator!"); 
                    Environment.Exit(0);
                }

            }

        }
        


    }

} 
