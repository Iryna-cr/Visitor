using System;

class Flower
{
    public void Accept(Action<Flower> visitor) => visitor(this);
}

class Program
{
    static void Main()
    {
        var flower = new Flower();
        flower.Accept(f => Console.WriteLine("Перевірено якість квітки "));
    }
}















