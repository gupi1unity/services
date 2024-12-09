using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseWalletHandler
{
    public abstract string Name { get; }

    public Stat<int> Value { get; }

    public BaseWalletHandler(int value)
    {
        Value = new Stat<int>(value);
    }

    public virtual void Add(int value)
    {
        if (value < 0)
        {
            throw new System.Exception("Invalid value");
        }

        Value.Value += value;
    }

    public virtual void Remove(int value)
    {
        if (value < 0)
        {
            throw new System.Exception("Invalid value");
        }

        Value.Value -= value;
    }
}
