using mis321_pa1_tboraski;

SongUtility utils = new SongUtility();
Menu menu = new Menu();

string menuChoice = menu.GetMainMenuChoice();
while (menuChoice != "5")
{
    MoveUser(menuChoice);
    menuChoice = menu.GetMainMenuChoice();
}

void MoveUser(string menuChoice)
{
    switch (menuChoice)
    {
        case "1":
            utils.DisplaySongs();
            break;

        case "2":
            utils.AddSong();
            break;

        case "3":
            utils.FavoriteSong();
            break;

        case "4":
            utils.DeleteSong();
            break;

        case "5":
            System.Console.WriteLine("Goodbye");
            break;

        default:
            System.Console.WriteLine("  Invalid Choice");
            break;
    }
}