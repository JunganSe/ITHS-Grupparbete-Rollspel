using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public abstract class Item
{

    public string Name { get; set; }
    public int Count = 0;

    public Item()
    {

    }

    public virtual void Use()
    {
        Console.WriteLine("Use this item!");
    }


}