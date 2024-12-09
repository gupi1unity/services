using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Inventory
{
    public List<Item> _items = new();

    public int CurrentSize { get => _items.Sum(item => item.Count); }

    public int MaxSize { get; private set; }

    public Inventory(int maxSize)
    {
        MaxSize = maxSize;
    }

    public void Add(Item item)
    {
        if (CurrentSize + item.Count > MaxSize)
            return;

        _items.Add(item);
    }

    public List<Item> GetItemsBy(int id, int count)
    {
        List<Item> items = new List<Item>();

        for (int i = 0; i < count; i++)
        {
            Item item = _items.First(item => item.ID == id);
            _items.Remove(item);
            items.Add(item);
        }

        return items;
    }

    public void ShowAllItems()
    {
        foreach (Item item in _items)
        {
            Debug.Log(item.ID);
        }
    }
}

public class Item
{
    public int ID;
    public int Count;
}
