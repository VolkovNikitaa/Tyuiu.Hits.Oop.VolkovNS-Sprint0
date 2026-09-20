/*
using System.Drawing;
Вариант задания № 5 
Описание задачи: 
Создать базовый класс Book в C#, который будет представлять информацию о 
книгах. На основе этого класса разработать 2-3 производных класса, 
демонстрирующих принципы наследования и полиморфизма. В каждом из классов 
должны быть реализованы новые атрибуты и методы, а также переопределены 
некоторые методы базового класса для демонстрации полиморфизма. 
Требования к базовому классу Book: 
• Атрибуты: Название (Title), Автор (Author), Год издания (YearOfPublication). 
• Методы: 
o GetInfo(): метод для получения информации о книге в виде строки. 
o Read(): метод для вывода сообщения о чтении книги. 
o Borrow(): метод для вывода сообщения о выдаче книги на чтение. 
Требования к производным классам: 
1. Учебник (Textbook): Должен содержать дополнительные атрибуты, такие как 
Предмет (Subject). Метод Read() должен быть переопределен для 
добавления информации о предмете при чтении учебника. 
2. Художественная литература (Fiction): Должен содержать дополнительные 
атрибуты, такие как Жанр (Genre). Метод Borrow() должен быть 
переопределен для добавления информации о жанре при выдаче книги на 
чтение. 
3. Научная литература (ScientificLiterature) (если требуется третий класс): 
Должен содержать дополнительные атрибуты, такие как Область науки 
(FieldOfScience). Метод GetInfo() должен быть переопределен для включения 
информации об области науки в описании книги.  */

using System;

Book book = new Book{Title = "Как правильно жить?", Author = "Иванов", YearOfPublication = "2020"};
Textbook textbook = new Textbook{Subject = "Математика", Title = "Геометрия", Author = "Петров", YearOfPublication = "2019"};
Fiction fiction = new Fiction{Genre = "Драма", Title = "Не пролитая слеза", Author = "Сидоров", YearOfPublication = "2021"};
ScientificLiterature scientificLiterature = new ScientificLiterature{FieldOfScience = "Физика", Title = "Наука", Author = "Кузнецов", YearOfPublication = "2018"};

book.Read();
textbook.Read();
fiction.Read();
scientificLiterature.Read();

book.Borrow(10);
textbook.Borrow(32);
fiction.Borrow(15);
scientificLiterature.Borrow(6);

textbook.Read();
fiction.Borrow(12);
scientificLiterature.GetInfo();

public class Book
{
    public string Title;
    public string Author;
    public string YearOfPublication;

    public virtual string GetInfo()
    {
        string info = $"Название книги: {Title}, автор: {Author}, год издания: {YearOfPublication}";
        return info;

    }

    public virtual void Read()
    {
        Console.WriteLine($"Сейчас читаю книгу: {Title}");
    }

    public virtual void Borrow (int days)
    {
        Console.WriteLine($"Выдана книга: {Title}, автор: {Author} на {days} дней");
    }

}

public class Textbook:Book
{
    public string Subject;

    public override void Read()
    {
        Console.WriteLine($"Сейчас читаю учебник: {Title}, предмет: {Subject}");
    }
}
public class Fiction : Book
{
    public string Genre;

    public override void Borrow(int days)
    {
        Console.WriteLine($"Выдана книга: {Title}, автор: {Author}, жанр: {Genre} на {days} дней");
    }
}

public class ScientificLiterature : Book
{
    public string FieldOfScience;

    public override string GetInfo()
    {
        return base.GetInfo() + $", область науки: {FieldOfScience}";
    }
}