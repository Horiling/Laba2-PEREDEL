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
    
    public string ToFullString()
    {
        string result = $"\nНазвание журнала: {name},\nериодичность: {frequency},\nДата выхода: {releaseDate.ToShortDateString()},\nТираж: {circulation},\nСредний рейтинг: {AverageRating}\n";
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Статьи этого автора:");
        for (int i=0; i< articles.Length; i++)
        {
         result +=  articles[i].ToFullString();
        }
        string str = sb.ToString();
        Console.WriteLine(str);

        return result;
    }

    public string ToShortString()
    {
        return $"Название журнала: {name},\nПериодичность: {frequency},\nДата выхода: {releaseDate.ToShortDateString()},\nТираж: {circulation},\nСредний рейтинг: {AverageRating}";
    }
}