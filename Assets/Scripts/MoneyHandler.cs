using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyHandler : BaseWalletHandler
{
    public override string Name => "Money";

    public MoneyHandler(int value) : base(value)
    {

    }
}
