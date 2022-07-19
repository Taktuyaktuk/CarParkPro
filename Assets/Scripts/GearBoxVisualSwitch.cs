using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearBoxVisualSwitch : MonoBehaviour
{
    public GameObject GearBoxUp;

    public void GearBoxDownImage()
    {
        GearBoxUp.SetActive(false);
    }
    
    public void GearBoxUpImage()
    {
        GearBoxUp.SetActive(true);
    }
}
