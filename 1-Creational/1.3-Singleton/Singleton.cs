
using System;

public class Singleton
{
    private static Singleton _singleton;
    public Guid ID { get; private set; }    

    protected Singleton() 
    {
        ID = Guid.NewGuid();
    }

    public static Singleton Instance()
    {
        if (_singleton == null)
        {
             _singleton = new Singleton();
        }

        return _singleton;
    }
}