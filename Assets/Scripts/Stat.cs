using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat<T> where T : IComparable
{
    public event Action<T> Changed;

    private T _value;

    public T Value 
    {
        get => _value;

        set
        {
            var oldValue = _value;

            _value = value;

            if (_value.CompareTo(oldValue) != 0)
            {
                _value = value;
                Changed?.Invoke(_value);
            }
        }
    }
    public Stat(T value)
    {
        Value = value;
    }

    public Stat()
    {
        Value = default(T);
    }

}
