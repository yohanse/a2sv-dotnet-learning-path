using System;
class Program {
    static void Main() {
        Library library = new Library("Abrehot", "4 kilo");

        Book book1 = new Book(1, "Harry Potter", "yuioio ", "ISBN", 2000);
        Book book2 = new Book(2, "Harry Potter", "yuioio ", "ISBN", 2000);
        Book book3 = new Book(3, "Harry Potter", "yuioio ", "ISBN", 2000);
        Book book4 = new Book(4, "Harry Potter", "yuioio ", "ISBN", 2000);
        Book book5 = new Book(5, "Harry Potter", "yuioio ", "ISBN", 2000);
        Console.WriteLine(book1);

        MediaItem mediaItem1 = new MediaItem(1, "music", "podcast", 200);
        MediaItem mediaItem2 = new MediaItem(2, "music", "podcast", 200);
        MediaItem mediaItem3 = new MediaItem(3, "music", "podcast", 200);
        MediaItem mediaItem4 = new MediaItem(4, "music", "podcast", 200);
        MediaItem mediaItem5 = new MediaItem(5, "music", "podcast", 200);
        Console.WriteLine(mediaItem1);
        Console.WriteLine("Add Book----------------------------");
        Console.WriteLine(library.AddBook(book1));
        Console.WriteLine("Add Book-------------------------");
        Console.WriteLine(library.AddBook(book2));
        Console.WriteLine("Remove Book ------------------------------------");
        Console.WriteLine(library.RemoveBook(book1));
        Console.WriteLine("Remove Book ------------------------------------");
        Console.WriteLine(library.RemoveBook(book3));

        Console.WriteLine("Add MediaItem ------------------------------------");
        Console.WriteLine(library.AddMediaItem(mediaItem1));
        Console.WriteLine("Add MediaItem ------------------------------------");
        Console.WriteLine(library.AddMediaItem(mediaItem2));
        Console.WriteLine("Remove MediaItem ------------------------------------");
        Console.WriteLine(library.RemoveMediaItem(mediaItem1));
        Console.WriteLine("Remove MediaItem ------------------------------------");
        Console.WriteLine(library.RemoveMediaItem(mediaItem3));
        Console.WriteLine("Print Library ------------------------------------");
        library.PrintCatalog();

    }

    
}