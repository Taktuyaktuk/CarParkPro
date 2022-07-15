using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnderCarChecker : MonoBehaviour
{
    [SerializeField]
    private CarCrusherManager _carCrusherManager;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Bollard"))
        {
            _carCrusherManager.BollardChanger(other.transform, other.gameObject);
        }
    }
}
