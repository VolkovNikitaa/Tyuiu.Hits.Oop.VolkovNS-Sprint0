/* 1.Ниже в блоке реализуйте принцип Single Responsibility Principle (Принцип единственной обязанности) на базе класса Animal

Cat cat = new Cat();
Animal animal = new Animal();
cat.Move();
cat.MakeSound();
animal.Move();

public class Animal
{
    public void Move()
    {
        Console.WriteLine("Бегает");
    }
}

public interface IMakeSound
{
    public void MakeSound();
}


public class Cat: Animal,IMakeSound
{
    public void MakeSound()
    {
        Console.WriteLine("Мурчит");
    }
}
*/
/* 2. Ниже в блоке реализуйте принцип Open/Closed Principle (Принцип открытости/закрытости) на базе класса Animal

Animal animal = new Animal();
Cat cat = new Cat();

animal.Move();
cat.Move();


public interface IMovable
{
    void Move();
}

public class Animal:IMovable
{
    public virtual void Move()
    {
        Console.WriteLine("Бегает");
    }
}

public class Cat : Animal, IMovable
{
    public override void Move()
    {
        Console.WriteLine("Бегает на 4 лапах");
    }
}
*/
/* 3. Ниже в блоке реализуйте принцип Liskov Substitution Principle (Принцип подстановки Барбары Лисков) на базе класса Animal
Cat cat = new Cat();
Bird bird = new Bird();
cat.Sound();
bird.Sound();
cat.Move();
bird.Fly();
public interface IFly
{
    void Fly();
}

public interface IMove
{
    void Move();
}

public class Animal
{
    public void Sound()
    {
        Console.WriteLine("Издает звуки");
    }
}

public class Cat: Animal,IMove
{
    public void Move()
    {
        Console.WriteLine("Бегает на 4 лапах");
    }
}

public class Bird : Animal, IMove, IFly
{
    public void Fly()
    {
        Console.WriteLine("Летает");
    }

    public void Move()
    {
        Console.WriteLine("Передвигается по земле на 2 лапах");
    }
}
*/
/* 4. Ниже в блоке реализуйте принцип Interface Segregation Principle (Принцип разделения интерфейса) на базе класса Animal


Cat cat = new Cat();
Whale whale = new Whale();
cat.Sound();
cat.Move();
cat.Swim();
whale.Sound();
whale.Swim();

public interface ISwim
{
    void Swim();
}

public interface IMove
{
    void Move();
}

public class Animal
{
    public void Sound()
    {
        Console.WriteLine("Издает звуки");
    }
}

public class Cat: Animal,IMove,ISwim
{
    public void Move()
    {
        Console.WriteLine("Передвигается по земле на 4 лапах");
    }
    public void Swim()
    {
        Console.WriteLine("Плавает");
    }
}

public class Whale: Animal,ISwim
{
    public void Swim()
    {
        Console.WriteLine("Плавает");
    }
}
*/
/* 5. Ниже в блоке реализуйте принцип Dependency Inversion Principle (Принцип инверсии зависимостей) на базе класса Animal

IMove fourlegs = new FourLegs();
Cat cat = new Cat(fourlegs);
cat.StartMove();

public interface ISound
{
    public void Sound();
}

public interface IMove
{
   public void Move(); 
}

public class TwoLegs:IMove
{
    public void Move()
    {
        Console.WriteLine("Передвигается на 2 конечностях");
    }
}

public class FourLegs:IMove
{
    public void Move()
    {
        Console.WriteLine("Передвигается на 4 конечностях");
    }
}

public class Animal:ISound
{
    public void Sound()
    {
        Console.WriteLine("Издает звуки");
    }
}

public class Cat:Animal
{
    private IMove _move;
    public Cat(IMove move)
    {
        _move = move;
    }

    public void StartMove()
    {
        _move.Move();
    }
}
*/


