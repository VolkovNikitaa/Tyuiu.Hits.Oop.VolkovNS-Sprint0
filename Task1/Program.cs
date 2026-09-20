/*1. Классы и Объекты
Animal Cat = new Animal();
class Animal
{

}
*/

/*2. Инкапсуляция
Animal Cat = new Animal();
Cat.Color = "Рыжий";
Cat.Sound();
Console.WriteLine(Cat.Color)

class Animal
{
    private string color;

    public string Color 
    {
        get { return color; }
        set { color = value; }
    }

    public void Sound()
    {
        Console.WriteLine("Издает звуки");
    }
}
*/
/*3. Наследование

Animal animal = new Animal();
Cat cat = new Cat();

animal.Color = "Рыжий";
Console.WriteLine(animal.Color);
animal.Sound();

cat.Color = "Серый";
Console.WriteLine(cat.Color);
cat.Sound();

class Animal
{
    private string color;

    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public void Sound()
    {
        Console.WriteLine("Мурчит");
    }
}
class Cat: Animal
{

}
*/
/*4. Полиморфизм
Animal Myanimal = new Animal();
Cat cat = new Cat();

Myanimal.Sound();
cat.Sound();

class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Мурчит");
    }
}

class Cat: Animal
{
    public override void Sound()
    {
        Console.WriteLine("Мяукает");
    }
}
*/
/*5. Абстракция

Cat cat = new Cat();
cat.Sound();
cat.Move();

abstract class Animal
{
    public abstract void Sound();

    public void Move()
    {
        Console.WriteLine("Бежит");
    }
}

class Cat: Animal
{
    public override void Sound()
    {
        Console.WriteLine("Мурчит");
    }
}
*/
/*6. Ассоциация (Композиция и Агрегация)
using System;
Activity activities = new Activity();
Animal animal = new Animal(activities);
animal.TimeSpending();

public class Activity
{
    public void StartDay() => Console.WriteLine("Просыпается");
    public void EndDay() => Console.WriteLine("Засыпает");
}

public class Animal
{
    private Activity activity;

    public Animal(Activity activity)
    {
        this.activity = activity;
    }

    public void TimeSpending()
    {
        activity.StartDay();
        Console.WriteLine("Охотится");
        activity.EndDay();
    }
}
*/
/*7. Ассоциация (Композиция и Агрегация)


using System;

Name myAnimalName  = new Name("Жучка");
Dog myDog = new Dog(myAnimalName);
myAnimalName.ShowName();
myDog.MakeSound();
public abstract class Animal
{
    public abstract void MakeSound();
}

public class Dog: Animal
{
    private Name Name;
    public Dog(Name Name)
    {
        this.Name = Name;
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name.name} Лает");
    }
}

public class Name
{
    public string name {get;set;}
    public Name(string name)
    {
        this.name = name;
    }
    public void ShowName()
    {
        Console.WriteLine($"Имя животного: {name}");
    }
}
*/



