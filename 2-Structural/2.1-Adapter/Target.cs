using System;

public class Target : ITarget
{
    public virtual void Requests()
    {
        Console.WriteLine("Target Requests");
    }
}
