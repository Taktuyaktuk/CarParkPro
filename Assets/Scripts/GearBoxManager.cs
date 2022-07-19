using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GearBoxManager : MonoBehaviour
{
    [SerializeField]
    private Image _gearBoxImage;
    [SerializeField]
    private Sprite _gearBoxForward;
    [SerializeField]
    private Sprite _gearBoxBackward;
    
    public bool DrivingForward = true;

    public void GearChanger()
    {
        if (DrivingForward == false)
        {
            DrivingForward = true;
            _gearBoxImage.sprite = _gearBoxForward;
        }
        else
        {
            DrivingForward = false;
            _gearBoxImage.sprite = _gearBoxBackward;
        }
    }
}
