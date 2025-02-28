namespace Topis_5___If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Joel

            Console.WriteLine("Hello, World!");
            // while (int.TryParse(Console.ReadLine(), out age))
            // Console.WriteLine("Invalid onput, please try again,");
            string choice = "";

            while (choice != "q")
            {
                Console.Clear();
                Console.WriteLine("┌──────┐");
                Console.WriteLine("  MENU  ");
                Console.WriteLine("└──────┘");
                Console.WriteLine("Please select an option from below:");
                Console.WriteLine();
                Console.WriteLine("1 - Compass Bearings");
                Console.WriteLine("2 - Parking Garage Cost");
                Console.WriteLine("3 - Hurricane");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (choice == "1")
                {
                    Console.WriteLine("You chose option 1");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();

                    compassBearings();
                }
                else if (choice == "2")
                {
                    Console.WriteLine("You chose option 2");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();

                    parkingGarageCost();
                }
                else if (choice == "3")
                {
                    Console.WriteLine("You chose option 2");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();

                    hurricane();
                }
                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                }
            }
        }

        static void compassBearings()
        {
            int compassDegree;

            Console.Clear();

            Console.WriteLine("┌────────────────┐");
            Console.WriteLine(" COMPASS BEARINGS  ");
            Console.WriteLine("└────────────────┘");
            Console.WriteLine();
            Console.WriteLine("This program will convert your degree into a compass direction.");
            Console.Write("Please enter a degree (Up to 360): ");

            while (!int.TryParse(Console.ReadLine(), out compassDegree))
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input, please try again. Input must only contain numbers can must not contain letters or special characters.");
                Console.WriteLine();
            }

            if (compassDegree > 360)
                compassDegree = 360;

            if (compassDegree < 0)
                compassDegree = 0;

            if (compassDegree > 345 || compassDegree <= 45)
                Console.Write("North");

            else if (compassDegree >= 135 && compassDegree <= 225)
                Console.Write("South");

            else if (compassDegree >= 45 && compassDegree <= 135)
                Console.Write("East");

            else if (compassDegree >= 135 && compassDegree <= 360) 
                Console.Write("West"); 

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
        }

        static void parkingGarageCost()
        {
            Console.Clear();

            Console.WriteLine("┌───────────────────┐");
            Console.WriteLine(" PARKING GARAGE COST  ");
            Console.WriteLine("└───────────────────┘");
            Console.WriteLine();
            Console.WriteLine("This program will convert your degree into a compass direction.");
        }

        static void hurricane()
        {
            Console.Clear();

            Console.WriteLine("┌─────────┐");
            Console.WriteLine(" HURRICANE");
            Console.WriteLine("└─────────┘");
            Console.WriteLine();
            Console.WriteLine("This program will convert your degree into a compass direction.");
        }
    }
}
