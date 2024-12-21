using System;
using System.Collections.Generic;
struct VinylRecord
{
    public string Artist;
    public string Genre;
    public string AlbumTitle;
    public int Circulation;
    public VinylRecord(string artist,string genre,string albumTitle,int circulation)
    {
        Artist = artist;
        Genre = genre;
        AlbumTitle = albumTitle;
        Circulation = circulation;
    }
}
class Program
{
    static void Main(string[] args)
    {
        List<VinylRecord>records = new List<VinylRecord>();
        {
            new VinylRecord("Artist 1", "Rock", "Album 1", 15000);
            new VinylRecord("Artist 2", "Pop", "Album 2", 9000);
           new VinylRecord("Artist 3", "Jazz", "Album 3", 12000);
           new VinylRecord("Artist 4", "Classic", "Album 4", 8000);
                
        }
        Console.WriteLine("Пластинки с тиражом более 10000 экземпляров");
        foreach(var record in records)
        {
            if (record.Circulation>10000)
            {
                Console.WriteLine($"Исполнитель:{record.Artist},Жанр:{record.Genre},Название альбома:{record.AlbumTitle},Тираж:{record.Circulation}");
            }
        }
    }
}
