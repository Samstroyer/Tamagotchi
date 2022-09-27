using System;
using System.Collections.Generic;

class Tamagotchi
{
    private int hunger;
    private int boredom;
    private List<string> words;
    private bool isAlive;
    private Random r;
    public string name;

    public Tamagotchi()
    {
        words = new();
    }

    public void Feed()
    {
        hunger -= r.Next(1, 3);
    }

    public void Hi()
    {
        ReduceBoredom();
    }

    public void Teach(string word)
    {
        words.Add(word);
        ReduceBoredom();
    }

    public void Tick()
    {
        hunger += r.Next(1, 3);
        boredom += r.Next(1, 3);
    }

    public void PrintStats()
    {
        Console.WriteLine("Tamagotchi {name} is ", name);
    }

    public void GetAlive()
    {

    }

    private void ReduceBoredom()
    {
        boredom -= r.Next(1, 4);
    }
}