class Program
{
    static void Main()
    {
        Car car = new Car();
        car.Start();
        car.Stop();

        WebService ws = new WebService();
        ws.Start();
        ws.Stop();


        ISaveable is1 = new WebService();
        IStartable is2 = new WebService();

        is1.Load();
        is2.Start();

        WebService is3 = new WebService(); ;
        is3.Stop();

    }
}