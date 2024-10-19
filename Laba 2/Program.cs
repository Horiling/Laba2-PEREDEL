using System;

namespace MagazineApp
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Magazine magazine = new Magazine("Tech Today", Frequency.Weekly, new DateTime(2024, 10, 19), 5000);
            Console.WriteLine(magazine.ToShortString());

            // Присваиваем значения всем свойствам и выводим данные с помощью ToFullString
            magazine.Name = "Science Monthly";
            magazine.Frequency = Frequency.Monthly;
            magazine.ReleaseDate = new DateTime(2024, 11, 1);
            magazine.Circulation = 10000;
            Console.WriteLine(magazine.ToFullString());

            // Добавляем статьи в журнал с помощью AddArticles и выводим полные данные
            Person author1 = new Person("Василий", "Павлецов", new DateTime(2000, 9, 15));
            Person author2 = new Person("Мария", "Нефедова", new DateTime(1999, 12, 20));
            Article article1 = new Article(author1, "Книга1", 3.9);
            Article article2 = new Article(author2, "Книга2", 4.8);

            magazine.AddArticles(article1, article2);
            Console.WriteLine(magazine.ToFullString());
        }
    }
}
