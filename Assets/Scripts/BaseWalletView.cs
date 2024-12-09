using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class BaseWalletView 
{
    private BaseWalletHandler _handler;
    private TextMeshProUGUI _text;

    public BaseWalletView(BaseWalletHandler handler, TextMeshProUGUI text)
    {
        _handler = handler;
        _text = text;

        _handler.Value.Changed += OnValueChanged;
    }

    public void OnValueChanged(int value)
    {
        _text.text = value.ToString();
    }
}
