using System;
using System.Net.Quic;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;

namespace RPG_Inventory;

public class Inventory<T>: IEnumerable<T>
    where T: Item
{
    private List<T> _items = new List<T>();

    public double Capacity {get; private set;}

    public Inventory(double capacity)
    {
        Capacity = capacity;
    }

    public void Add(T item)
    {
        if (Capacity - item.Weight <= 0)
        {
            System.Console.WriteLine($"Noe enough capacity for {item.Title}.");
            return;
        }

        _items.Add(item);
        Capacity -= item.Weight;
    }

    public void Remove(T item)
    {
        if (!_items.Contains(item))
        {
            System.Console.WriteLine($"There is no {item.Title} in the inventory.");
            return;
        }

        _items.Remove(item);
        Capacity += item.Weight;
    }

    public void GetByName(string title)
    {
        var toSearch = title.ToLower();

        if (String.IsNullOrWhiteSpace(title))
        {
            System.Console.WriteLine("Title is needed.");
            return;
        }

        var result = _items.Where(i => i.Title != null && i.Title == toSearch).ToList();

        if (result.Count() == 0)
        {
            System.Console.WriteLine($"No title that contains {title}.");
            return;
        }

        foreach(var item in result)
            System.Console.WriteLine(item);
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (var item in _items)
            yield return item;
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
