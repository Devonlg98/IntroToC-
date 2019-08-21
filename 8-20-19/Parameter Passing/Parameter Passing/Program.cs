using System;
using System.IO;
public struct IntHolder
{
    public int i;
}
class Program
{
    static void Foo(IntHolder x)
    {
        x = new IntHolder();
    }
    static void Main(string[] args)
    {
        IntHolder y = new IntHolder();
        y.i = 5;
        Foo(y);
        Console.WriteLine(y);
        Console.ReadKey();
    }
}