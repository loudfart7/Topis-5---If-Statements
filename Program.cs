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


            static void Main(string[] args)
            {
                string choice = "";

                while (choice != "q")
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to my generic menu.  Please select an option:");
                    Console.WriteLine();
                    Console.WriteLine("1 - Menu Option 1");
                    Console.WriteLine("2 - Menu Option 2");
                    Console.WriteLine("...");
                    Console.WriteLine("x - Menu Option x");
                    Console.WriteLine("Q - Quit");
                    Console.WriteLine();
                    choice = Console.ReadLine().ToLower().Trim();
                    Console.WriteLine();

                    if (choice == "1")
                    {
                        Console.WriteLine("You chose option 1");
                        Console.WriteLine("Hit ENTER to continue.");
                        Console.ReadLine();
                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine("You chose option 2");
                        Console.WriteLine("Hit ENTER to continue.");
                        Console.ReadLine();
                    }
                   
                    else
                    {
                        Console.WriteLine("Invalid choice, press ENTER to continue.");
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}
