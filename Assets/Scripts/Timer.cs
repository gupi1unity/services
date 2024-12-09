using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [field: SerializeField] public float MaxTime { get; private set; }
    [SerializeField] private TextMeshProUGUI _text;
    private bool _isRunnning = true;
    private float _time;

    public Stat<int> IntTime { get; private set; }

    public float TimeInTimer => _time;

    public void Initialize()
    {
        _time = MaxTime;
        IntTime = new Stat<int>(0);
    }

    private void Update()
    {
        if (_isRunnning == true && _time > 0)
        {
            _time -= Time.deltaTime;
            IntTime.Value = Convert.ToInt32(_time);

            float minutes = Mathf.FloorToInt(_time / 60);
            float seconds = Mathf.FloorToInt(_time % 60);

            _text.text = string.Format("{00:00}:{1:00}", minutes, seconds);
        }
    }

    public void OnButtonContinuePressed()
    {
        _isRunnning = true;
    }

    public void OnButtonStopPressed()
    {
        _isRunnning = false;
    }

    public void OnButtonResetPressed()
    {
        _time = MaxTime;
    }
}
