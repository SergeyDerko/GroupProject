using System;
using Car;

class Program
{
    static void Main()
    {
        SportCar obj = new SportCar();
        obj.InfoSportCar();

        // ����� ����� ����������� ������ auto.netmodule
        Auto obj1 = new Auto();
        obj1.AutoInfo();
        Console.ReadLine();
    }
}