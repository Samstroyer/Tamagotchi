class Engine
{
    private Thread tick = new(Tick);

    public Engine()
    {
        tick.Start();
    }

    private static void Tick()
    {

    }

}
