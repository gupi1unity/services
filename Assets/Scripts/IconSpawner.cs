using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconSpawner
{
    private IconsFactory _iconsFactory;
    private List<GameObject> _icons;
    private Timer _timer;

    public IconSpawner(IconsFactory iconsFactory, Timer timer)
    {
        _iconsFactory = iconsFactory;
        _timer = timer;

        _icons = new List<GameObject>();

        _timer.IntTime.Changed += OnTimerChanged;
    }

    public void SpawnIcons()
    {
        for (int i = 0; i < _timer.MaxTime; i++)
        {
            GameObject icon = _iconsFactory.CreateIcon();
            _icons.Add(icon);
        }
    }

    public void OnTimerChanged(int value)
    {
        if (value <= 0)
        {
            _timer.IntTime.Changed -= OnTimerChanged;
            return;
        }

        _icons[value-1].SetActive(false);
    }
}
