using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    private DimondsView _dimondsView;
    private MoneyView _moneyView;
    private EnergyView _energyView;

    [SerializeField] private TextMeshProUGUI _dimondsText;
    [SerializeField] private TextMeshProUGUI _moneyText;
    [SerializeField] private TextMeshProUGUI _energyText;

    private Timer _timer;
    [SerializeField] private Slider _slider;

    private IconSpawner _iconsSpawner;
    [SerializeField] private GameObject _iconPrefab;
    [SerializeField] private Transform _groupLayout;
    [SerializeField] private IconsFactory _iconsFactory;

    public void Initialize(DimondsHandler dimondsHandler, MoneyHandler moneyHandler, EnergyHandler energyHandler, Timer timer)
    {
        _dimondsView = new DimondsView(dimondsHandler, _dimondsText);
        _moneyView = new MoneyView(moneyHandler, _moneyText);
        _energyView = new EnergyView(energyHandler, _energyText);
        _timer = timer;

        _iconsFactory.Initialize(_iconPrefab,_groupLayout);
        _iconsSpawner = new IconSpawner(_iconsFactory, _timer);

        _slider.maxValue = _timer.MaxTime;
        _iconsSpawner.SpawnIcons();
    }

    private void Update()
    {
        _slider.value = _timer.TimeInTimer;
    }
}
