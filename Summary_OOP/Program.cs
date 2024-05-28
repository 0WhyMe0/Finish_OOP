using Summary_OOP;
using System.Runtime.CompilerServices;
using System.Transactions;

class Program
{
    private static MusicManager musicManager = new MusicManager();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Select an options! ");
            Console.WriteLine("1, Added track!");
            Console.WriteLine("2, Added Author!");
            Console.WriteLine("3, Added Playlist");
            Console.WriteLine("4, View tracks!");
            Console.WriteLine("5, Update tracks!");
            Console.WriteLine("6, Delete track!");
            Console.WriteLine("7, Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddTrack();
                    break;
                case 2:
                    AddAuthor();
                    break;
                case 3:
                    AddPlaylist();
                    break;
                case 4:
                    ViewAllTracks();
                    break;              
                case 5:
                    UpdateTrack();
                    break;
                case 6:
                    DeleteTrack();
                    break;
                case 7:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Failed");
                    break;
            }
        }
    }
    private static void AddTrack()
    {
        Console.WriteLine("Enter name track! ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter duraation traack! ");
        int duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter name Author track! ");
        string nameAuthor = Console.ReadLine();

        Console.WriteLine("Enter pseudonym Author! ");
        string pseudonym = Console.ReadLine();

        Author author = new Author(nameAuthor, pseudonym);

        Track track = new Track(name, duration, author);

        musicManager.AddTrack(track);
        Console.WriteLine("Track good added!");
    }

    private static void AddAuthor()
    {
        Console.WriteLine("Enter name Author");
        string name = Console.ReadLine();

        Console.WriteLine("Enter alias Author");
        string alias = Console.ReadLine();

        Author author = new Author(name, alias);
        musicManager.AddAuthor(author);
        Console.WriteLine("Author good added");
    }

    private static void ViewAllTracks()
    {
    }

    private static void UpdateTrack()
    {
        Console.WriteLine("Enter name Track");
        string name = Console.ReadLine();

        Console.WriteLine("Enter new name! ");
        string newName = Console.ReadLine();

        Console.WriteLine("Enter new Duration! ");
        int newDuration = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter new name for Author!");
        string nameAuthor = Console.ReadLine();

        Console.WriteLine("Enter new Alias for Author! ");
        string newAlias = Console.ReadLine();

        Author author = new Author(nameAuthor, newAlias);
        
        musicManager.UpdateTrack(name, newName, newDuration, author);

        Console.WriteLine($"New name Track: {newName}");
        Console.WriteLine($"New duration: {newDuration}");
        Console.WriteLine($"New name and alias Author is: {author}");
    }

    private static void AddPlaylist()
    {
        Console.WriteLine("Enter name Playlist! ");
        string name = Console.ReadLine();

        Playlist playlists = new Playlist(name);

        musicManager.AddPlaylast(playlists);
    }

    private static void DeleteTrack()
    {
        Console.WriteLine("Enter name Trac for delete! ");
        string name = Console.ReadLine();

        musicManager.DeleteTrack(name);
        Console.WriteLine($"Delete is Track: {name}");
    }
}