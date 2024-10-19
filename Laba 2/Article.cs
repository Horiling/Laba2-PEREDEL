using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Article
{
    public Person Author { get; set; }
    public string Title { get; set; }
    public double Rating { get; set; }

    public Article(Person author, string title, double rating)
    {
        Author = author;
        Title = title;
        Rating = rating;
    }

    public Article()
    {
        Author = new Person();
        Title = "Название статьи по умолчанию";
        Rating = 0.0;
    }

    public string ToFullString()
    {
        return $"Автор: {Author.ToShortString()}, Название: {Title}, Рейтинг: {Rating}";
    }
}