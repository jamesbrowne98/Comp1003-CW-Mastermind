using System;
using System.IO;
namespace Crawler
{
    /**
     * The main class of the Dungeon Crawler Application
     * 
     * You may add to your project other classes which are referenced.
     * Complete the templated methods and fill in your code where it says "Your code here".
     * Do not rename methods or variables which already exist or change the method parameters.
     * You can do some checks if your project still aligns with the spec by running the tests in UnitTest1
     * 
     * For Questions do contact us!
     */
    public class CMDCrawler
    {
        /**
         * use the following to store and control the next movement of the yser
         */
        public enum PlayerActions { NOTHING, Red, Blue, Green, Yellow, Orange, Black, White, Pink, Purple, Quit };
        private PlayerActions action = PlayerActions.NOTHING;
        bool play = false;
        bool running = false;
        bool numOfPoss = false;
        bool numOfColours = false;
        int N;
        int M;
        /**
         * tracks if the game is running
         */
        private bool active = true;


        /**
         * Reads user input from the Console
         * 
         * Please use and implement this method to read the user input.
         * 
         * Return the input as string to be further processed
         * 
         */
      private string ReadUserInput()
        {
            string inputRead = Console.ReadLine();

            return inputRead;
         
        }
      
        /**
         * Processed the user input string
         * 
         * takes apart the user input and does control the information flow
         *  * initializes the map ( you must call InitializeMap)
         *  * starts the game when user types in Play
         *  * sets the correct playeraction which you will use in the GameLoop
         */
        public void ProcessUserInput(string input)
        {
            // Your Code here         
            string inputLower = input.ToLower(); //changes all inputs to lower case 

            if (!numOfPoss && numOfColours) //lets the player choose how many colours and stores it in the M variable
            {
                M = Convert.ToInt32(input);

                numOfPoss = false;
                numOfColours = false;
                Console.Clear();

                int[] randomNum = new int[N];
                Random RandomNumber = new Random();


                for (int i = 0; i < N; i++)
                {
                    randomNum[i] = RandomNumber.Next(1, M);
                }


                

                for(int i = 0; i<N; i++)
                {
                    Console.WriteLine(randomNum[i]);
                }

            }

            if (numOfPoss && !numOfColours) //lets the player choose how many positions and stores it in the N variable
            {
              
                N = Convert.ToInt32(input);
                
                running = true;
                numOfColours = true;
                numOfPoss = false;
                Console.Clear();
                Console.WriteLine("Choose how many colours you want 1-9");
            }

            

            switch (inputLower) //reads the users inputs in lower case
            {
                default: action = PlayerActions.NOTHING; break;
                case "start": if (!running) //will only work if the play bool is false and will load it to be true
                    {
 
                        Console.WriteLine("Select the number of positions, 1-9");
                        numOfPoss = true;
                    } break;
                    
            }

           
            
        }

        
        public void GameLoop(bool active)
        {

            // Your code here
           
            
          
            if (play)
            {
                try
                {
                    Console.Clear();
                }
                catch (Exception)
                {

                }
                
            }
        }

        

        

        

        

        /**
         * Main method and Entry point to the program
         
        */
        static void Main(string[] args)
        {
            CMDCrawler crawler = new CMDCrawler();
            string input = string.Empty;
            Console.WriteLine("Welcome to Mastermind!" + Environment.NewLine +
                "To start type play" + Environment.NewLine);

            // test area



            // test area
            // Loops through the input and determines when the game should quit
            while (crawler.active && crawler.action != PlayerActions.Quit)
            {
                Console.WriteLine("Your Command: ");
                input = crawler.ReadUserInput();
                Console.WriteLine(Environment.NewLine);

                crawler.ProcessUserInput(input);

                crawler.GameLoop(crawler.active);


            }

            Console.WriteLine("See you again" + Environment.NewLine +
                "For another game of Mastermind! ");


        }


    }
}
