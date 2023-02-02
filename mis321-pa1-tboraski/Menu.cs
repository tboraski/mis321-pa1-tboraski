namespace mis321_pa1_tboraski
{
    public class Menu
    {
        private void DisplayMainMenu()
        {
            System.Console.WriteLine("  PRESS ANY KEY TO CONINUE");
            Console.ReadKey();
            Console.Clear();
            System.Console.WriteLine(" ~ MAIN MENU ~ ");
            System.Console.WriteLine("  1. Show all songs");
            System.Console.WriteLine("  2. Add a new song");
            System.Console.WriteLine("  3. Favorite a song");
            System.Console.WriteLine("  4. Delete a song");
            System.Console.WriteLine("  5. Exit");
        }

        public string GetMainMenuChoice()
        {
            DisplayMainMenu();
            System.Console.WriteLine("  ENTER YOUR CHOICE:");
            return Console.ReadLine();
        }
    }
}