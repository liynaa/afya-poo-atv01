using System;

class Program
{
    static void Main(string[] args)
    {
        Lampada lampada = new Lampada("Philips", "LED");

        lampada.Alternar();
        lampada.AjustarBrilho(80);

        Console.WriteLine(lampada.ToString());
    }
}