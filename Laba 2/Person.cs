using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Person
{
    private string Name;
    private string Surname;
    private DateTime birthDate;

    public Person(string firstName, string lastName, DateTime birthDate)
    {
        this.Name = firstName;
        this.Surname = lastName;
        this.birthDate = birthDate;
    }

    public Person()
    {
        this.Name = "Имя по умолчанию";
        this.Surname = "Фамилия по умолчанию";
        this.birthDate = new DateTime(2000, 1, 1);
    }

    public string FirstName
    {
        get { return Name; }
        set { Name = value; }
    }

    public string LastName
    {
        get { return Surname; }
        set { Surname = value; }
    }

    public DateTime BirthDate
    {
        get { return birthDate; }
        set { birthDate = value; }
    }

    public int BirthYear
    {
        get { return birthDate.Year; }
        set { birthDate = new DateTime(value, birthDate.Month, birthDate.Day); }
    }

    public string ToFullString()
    {
        return $"Имя: {Name}, Фамилия: {Surname}, Дата рождения: {birthDate.ToShortDateString()}";
    }

    public string ToShortString()
    {
        return $"{Name} {Surname}";
    }
}
