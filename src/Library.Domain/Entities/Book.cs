namespace Library.Domain.Entities;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public int Count { get; set; }
    public int Pages { get; set; }
    public int Year { get; set; }
    public double Price { get; set; }
}