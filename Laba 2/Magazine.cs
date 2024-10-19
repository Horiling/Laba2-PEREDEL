using MagazineApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Magazine
{

    private string name;
    private Frequency frequency;
    private DateTime releaseDate;
    private int circulation;
    private Article[] articles;


    public Magazine(string name, Frequency frequency, DateTime releaseDate, int circulation)
    {
        this.name = name;
        this.frequency = frequency;
        this.releaseDate = releaseDate;
        this.circulation = circulation;
        this.articles = new Article[0]; 
    }

    public Magazine()
    {
        name = "Название журнала по умолчанию";
        frequency = Frequency.Monthly;
        releaseDate = new DateTime(2000, 1, 1);
        circulation = 1000;
        articles = new Article[0];
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Frequency Frequency
    {
        get { return frequency; }
        set { frequency = value; }
    }

    public DateTime ReleaseDate
    {
        get { return releaseDate; }
        set { releaseDate = value; }
    }

    public int Circulation
    {
        get { return circulation; }
        set { circulation = value; }
    }

    public Article[] Articles
    {
        get { return articles; }
        set { articles = value; }
    }

    public double AverageRating
    {
        get
        {
            if (articles.Length == 0)
                return 0.0;

            double totalRating = 0.0;
            foreach (var article in articles)
            {
                totalRating += article.Rating;
            }
            return totalRating / articles.Length;
        }
    }
    public void AddArticles(params Article[] newArticles)
    {
        int oldLength = articles.Length;
        Array.Resize(ref articles, oldLength + newArticles.Length);
        for (int i = 0; i < newArticles.Length; i++)
        {
            articles[oldLength + i] = newArticles[i];
        }
    }
    public string ToFullString()
    {
        string result = $"Название журнала: {name}, Периодичность: {frequency}, Дата выхода: {releaseDate.ToShortDateString()}, Тираж: {circulation}, Средний рейтинг: {AverageRating}\nСтатьи:\n";
        foreach (var article in articles)
        {
            result += $"- {article.ToFullString()}\n";
        }
        return result;
    }

    public string ToShortString()
    {
        return $"Название журнала: {name}, Периодичность: {frequency}, Дата выхода: {releaseDate.ToShortDateString()}, Тираж: {circulation}, Средний рейтинг: {AverageRating}";
    }
}