using System.Data.Common;

class Book {
    private int ID;
    private string Title;
    private string Author;
    private string ISBN;
    private int PublicationYear;

    public Book(int iD, string title, string author, string iSBN, int publicationYear){
        ID = iD;
        Title = title;
        Author = author;
        ISBN = iSBN;
        PublicationYear = publicationYear;
    }

    public override string ToString()
    {
        return $"Title --> {Title}\nAuthor --> {Author}\nPublicationYear --> {PublicationYear}";
    }
}

class MediaItem {
    private int ID;
    private string Title;
    private string MediaType;
    private int Duration;

    public MediaItem(int iD, string title, string mediaType, int duration){
        ID = iD;
        Title = title;
        MediaType = mediaType;
        Duration = duration;
    }

    public override string ToString()
    {
        return $"Title --> {Title}\nMediaType --> {MediaType}\nDuration --> {Duration}";
    }

}

class Library {
    string Name;
    string Address;
    List<Book> Books;
    List<MediaItem> MediaItems;

    public Library(string name, string address){
        Name = name;
        Address = address;
        Books = new List<Book>();
        MediaItems = new List<MediaItem>();
    }

    public Book AddBook(Book book) {
        Books.Add(book);
        return book;
    }

    public object RemoveBook(Book book) {
        if (!Books.Remove(book)) {
            return "Book not found!!";
        }
        return book;
    }

    public MediaItem AddMediaItem(MediaItem mediaItem) {
        MediaItems.Add(mediaItem);
        return mediaItem;
    }

    public object RemoveMediaItem(MediaItem mediaItem) {
        if (!MediaItems.Remove(mediaItem)) {
            return "MediaItem not found!!";
        }
        return mediaItem;
    }

    public void PrintCatalog() {

        Console.WriteLine("Book ------------ ");
        for(int pointer = 0; pointer < Books.Count(); pointer++){
            Console.Write($"{pointer + 1}. ");
            Console.WriteLine(Books[pointer]);
        }

        if (Books.Count() == 0){
            Console.WriteLine("We do not have any book yet.");
        }

        Console.WriteLine("MediaItem ------------ ");
        for(int pointer = 0; pointer < MediaItems.Count(); pointer++){
            Console.Write($"{pointer + 1}. ");
            Console.WriteLine(MediaItems[pointer]);
        }

        if (MediaItems.Count() == 0){
            Console.WriteLine("We do not have any media items yet.");
        }

        Console.WriteLine("Thanks for visting us !!");
    }


}

// Main function implmentation.

// using System;
// class Program {
//     static void Main() {
//         Library library = new Library("Abrehot", "4 kilo");

//         Book book1 = new Book(1, "Harry Potter", "yuioio ", "ISBN", 2000);
//         Book book2 = new Book(2, "Harry Potter", "yuioio ", "ISBN", 2000);
//         Book book3 = new Book(3, "Harry Potter", "yuioio ", "ISBN", 2000);
//         Book book4 = new Book(4, "Harry Potter", "yuioio ", "ISBN", 2000);
//         Book book5 = new Book(5, "Harry Potter", "yuioio ", "ISBN", 2000);
//         Console.WriteLine(book1);

//         MediaItem mediaItem1 = new MediaItem(1, "music", "podcast", 200);
//         MediaItem mediaItem2 = new MediaItem(2, "music", "podcast", 200);
//         MediaItem mediaItem3 = new MediaItem(3, "music", "podcast", 200);
//         MediaItem mediaItem4 = new MediaItem(4, "music", "podcast", 200);
//         MediaItem mediaItem5 = new MediaItem(5, "music", "podcast", 200);
//         Console.WriteLine(mediaItem1);
//         Console.WriteLine("Add Book----------------------------");
//         Console.WriteLine(library.AddBook(book1));
//         Console.WriteLine("Add Book-------------------------");
//         Console.WriteLine(library.AddBook(book2));
//         Console.WriteLine("Remove Book ------------------------------------");
//         Console.WriteLine(library.RemoveBook(book1));
//         Console.WriteLine("Remove Book ------------------------------------");
//         Console.WriteLine(library.RemoveBook(book3));

//         Console.WriteLine("Add MediaItem ------------------------------------");
//         Console.WriteLine(library.AddMediaItem(mediaItem1));
//         Console.WriteLine("Add MediaItem ------------------------------------");
//         Console.WriteLine(library.AddMediaItem(mediaItem2));
//         Console.WriteLine("Remove MediaItem ------------------------------------");
//         Console.WriteLine(library.RemoveMediaItem(mediaItem1));
//         Console.WriteLine("Remove MediaItem ------------------------------------");
//         Console.WriteLine(library.RemoveMediaItem(mediaItem3));
//         Console.WriteLine("Print Library ------------------------------------");
//         library.PrintCatalog();

//     }

    
// }