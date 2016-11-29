using System;
using Car;

class Program
{
    static void Main()
    {
        SportCar obj = new SportCar();
        obj.InfoSportCar();

        // Здесь будет загружаться модуль auto.netmodule
        Auto obj1 = new Auto();
        obj1.AutoInfo();
        Console.ReadLine();
    }
}