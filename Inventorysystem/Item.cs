using System;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace Rollspel
{
    public abstract class Item : IActiveObject
    {
        public int Count = 0;

        public char Symbol { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public string Name { get; set; }

        public virtual void Use()
        {
            Console.WriteLine("Use this item!");
        }

        public void Step()
        {

        }
        public void Reset()
        {

        }
    }
}