using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GearBoxManager : MonoBehaviour
{

    public bool DrivingForward = true;

    public void ForwardGear()
    {
        DrivingForward = true;
    }

    public void BackwardGear()
    {
        DrivingForward = false;
    }
}
