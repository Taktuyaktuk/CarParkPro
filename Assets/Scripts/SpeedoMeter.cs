using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedoMeter : MonoBehaviour
{

    [SerializeField]
    private CarController _carControler;
    [SerializeField]
    private Text _speedDisplay;
    [SerializeField]
    private string _speedoMeterText;

    private void Awake()
    {
        if(_speedoMeterText == "")
        {
            _speedoMeterText = "Km/H : ";
        }
    }
    void Update()
    {
        _speedDisplay.text = (_speedoMeterText + _carControler.ScaledSpeed.ToString("0"));
    }
}
