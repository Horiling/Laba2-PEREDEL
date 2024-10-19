using System;
using System.Text;

namespace MagazineApp
{
   
    class Program
    {
        static void Main(string[] args)
        {

           



            Magazine magazine = new Magazine("Книга1", Frequency.Weekly, new DateTime(2024, 10, 19), 5000);
            Console.WriteLine(magazine.ToShortString());

            // Присваиваем значения всем свойствам и выводим данные с помощью ToFullString
            magazine.Name = "Книга2";
            magazine.Frequency = Frequency.Monthly;
            magazine.ReleaseDate = new DateTime(2024, 11, 1);
            magazine.Circulation = 10000;
            Console.WriteLine(magazine.ToFullString());

            // Добавляем статьи в журнал с помощью AddArticles и выводим полные данные
            Person author1 = new Person("Дмитрий", "Тихонов", new DateTime(2000, 9, 15));
            Person author2 = new Person("Арина", "Загародная", new DateTime(1999, 12, 20));
            Article article1 = new Article(author1, "Книга1", 3.9);
            Article article2 = new Article(author2, "Книга2", 4.8);

            Console.WriteLine(magazine.ToFullString());
        }
    }
}
