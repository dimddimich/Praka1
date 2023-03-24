using System;
namespace Praka1;

class programma
{
    public static double CalculateTime(double distance, double speed)
    {
        return (distance / speed) * 60;
    }
    static void Main()
    {
        double Speed1; double Speed2; double Speed3; double Speed4;
        string Name1; string Name2; string Name3; string Name4;

        Cars car1 = new Cars("BMW M5 E60", 300);
        Speed1 = car1.Speed;
        Name1 = car1.Car;
        car1.DataCar();

        Cars car2 = new Cars("Пятнашка");
        car2.Speed = 200;
        Speed2 = car2.Speed;
        Name2 = car2.Car;
        car2.DataCar();

        Cars car3 = new Cars("Nissan Skyline 2jz", 320);
        Speed3 = car3.Speed;
        Name3 = car3.Car;
        car3.DataCar();

        Cars car4 = new Cars("Копейка(ну тут без шансов)");
        car4.Speed = 450;
        Speed4 = car4.Speed;
        Name4 = car4.Car;
        car4.DataCar();

        double distance = 500;

        double t1; double t2; double t3; double t4;

        t1 = CalculateTime(distance, Speed1);
        t2 = CalculateTime(distance, Speed2);
        t3 = CalculateTime(distance, Speed3);
        t4 = CalculateTime(distance, Speed4);

        string Name; double Speed; double t;
        if (t1 < t2) { t = t1; Name = Name1; Speed = Speed1; }
        else { t = t2; Name = Name2; Speed = Speed2; }
        if (t > t3) { t = t3; Name = Name3; Speed = Speed3; }
        if (t > t4) { t = t4; Name = Name4; Speed = Speed4; }

        Console.WriteLine("\nПобедитель: {0}\nМаксималка машины: {1} км/ч\nВремя пути: {2} минут\n", Name, Speed, t);
    }
}

class Cars
{
    public double Speed;
    public string Car;


    public Cars(string car)
    {
        this.Car = car;
    }
    public Cars(string car, double Speed)
    {
        this.Car = car;
        this.Speed = Speed;
    }
    public void DataCar()
    {
        Console.WriteLine("Название автомобиля: {0}\nСкорость: {1} км/ч\n", Car, Speed);
    }
}