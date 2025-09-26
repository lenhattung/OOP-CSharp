using System;

class Program
{
    static void Main()
    {
        Car car = new Car();
        car.Start();
        car.Stop();

        Vehicle vehicle = new Car();
        car.Start();

        Webservice ws = new Webservice();
        ws.Start();
        ws.Stop();
        ws.Load();
        ws.Save();


        ISaveable is1 = new Webservice();
        IStartable is2 = new Webservice();

        is1.Load();
        is2.Start();

        Webservice is3 = new Webservice(); ;
        is3.Stop();
    }
}