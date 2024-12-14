using MagazineApp;
using System;
using System.Text;

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
        articles = new Article[2];
        articles[0] = new Article(); // Статья по умолчанию
        articles[1] = new Article(new Person("Арина", "Загородная", new DateTime(1999, 12, 20)), "Ещё_Статья", 5);
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
            double Sum = 0;
            for (int i = 0; i < articles.Length; i++)
            {
                Article currentArticle = articles[i];
                Sum = Sum + currentArticle.GetRate();
            }
            Sum = Sum / articles.Length;

            return Sum;
        }
    }

    public string ToFullString()
    {
        StringBuilder result = new StringBuilder();
        result.AppendLine($"\nНазвание журнала: {name}");
        result.AppendLine($"Периодичность: {frequency}");
        result.AppendLine($"Дата выхода: {releaseDate.ToShortDateString()}");
        result.AppendLine($"Тираж: {circulation}");
        result.AppendLine($"Средний рейтинг: {AverageRating}");

        result.AppendLine("Статьи этого журнала:");
        foreach (var article in articles)
        {
            if (article != null)
            {
                result.AppendLine(article.ToFullString());
            }
        }

        return result.ToString();
    }

    public string ToShortString()
    {
        return $"Название журнала: {name},\nПериодичность: {frequency},\nДата выхода: {releaseDate.ToShortDateString()},\nТираж: {circulation},\nСредний рейтинг: {AverageRating}";
    }
}
