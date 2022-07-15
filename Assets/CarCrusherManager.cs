using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCrusherManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _crushedBollard;
    private GameObject InstantiatedObject;
    [SerializeField]
    private GameObject _obstacles;

    public void BollardChanger( Transform ObjectPos , GameObject Object)
    {
        Transform objectPos = ObjectPos;
        Object.transform.SetParent(transform);
        InstantiatedObject = GameObject.Instantiate(_crushedBollard, objectPos);
        InstantiatedObject.transform.SetParent(_obstacles.transform);
        Destroy(Object);
    }
}
