using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraPriorityManager : MonoBehaviour
{
    [SerializeField]
    private CinemachineVirtualCamera _topDown;
    [SerializeField]
    private CinemachineVirtualCamera _isometricLeft;
    [SerializeField]
    private CinemachineVirtualCamera _behind;

    public void TopDownView()
    {
        _topDown.Priority = 11;
        _isometricLeft.Priority = 10;
        _behind.Priority = 10;
    }

    public void _isometricLeftView()
    {
        _topDown.Priority = 10;
        _isometricLeft.Priority = 11;
        _behind.Priority = 10;
    }

    public void BehindView()
    {
        _topDown.Priority = 10;
        _isometricLeft.Priority = 10;
        _behind.Priority = 11;
    }



}
