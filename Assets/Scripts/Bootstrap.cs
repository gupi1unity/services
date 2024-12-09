using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    private DimondsHandler _dimondsHandler;
    private MoneyHandler _moneyHandler;
    private EnergyHandler _energyHandler;

    [SerializeField] private UIController _uiController;
    [SerializeField] private IconsFactory _iconsFactory;

    [SerializeField] private Timer _timer;

    private void Awake()
    {
        _dimondsHandler = new DimondsHandler(0);
        _moneyHandler = new MoneyHandler(0);
        _energyHandler = new EnergyHandler(0);

        _timer.Initialize();

        _uiController.Initialize(_dimondsHandler, _moneyHandler, _energyHandler, _timer);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _dimondsHandler.Add(5);
            _moneyHandler.Add(5);
            _energyHandler.Add(5);
        }
    }
}
