using System;
using System.Text;

namespace MagazineApp
{
   
    class Program
    {
        static void Main(string[] args)
        {

           



            Magazine magazine = new Magazine();
            Console.WriteLine(magazine.ToShortString());

            magazine.Name = "Книга2";
            magazine.Frequency = Frequency.Monthly;
            magazine.ReleaseDate = new DateTime(2024, 11, 1);
            magazine.Circulation = 10000;
            Console.WriteLine(magazine.ToShortString());

            Person author1 = new Person("Дмитрий", "Тихонов", new DateTime(2000, 9, 15));
            Person author2 = new Person("Арина", "Загародная", new DateTime(1999, 12, 20));


            Article article1 = new Article(author1, "Абвгдейка", 3.9);
            Article article2 = new Article(author2, "Букварь", 4.8);

            Console.WriteLine(magazine.ToFullString());
        }
    }
}
