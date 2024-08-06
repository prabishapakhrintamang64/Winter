using System;
namespace Application
{
    public class Problem115
    {
        public static void solution()
        {
            Box<int> intBox = new Box<int>(123);
        Console.WriteLine("Integer in box: " + intBox.GetItem());

        Box<string> strBox = new Box<string>("Hello Generics");
        Console.WriteLine("String in box: " + strBox.GetItem());

        strBox.SetItem("Updated String");
        Console.WriteLine("Updated string in box: " + strBox.GetItem());
      }

    

public class Box<T>
{
    private T _item;

    public Box(T item)
    {
        _item = item;
    }

    public void SetItem(T item)
    {
        _item = item;
    }

    public T GetItem()
    {
        return _item;
    }
}
}
}

