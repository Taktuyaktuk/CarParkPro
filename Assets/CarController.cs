using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public List<AxleInfo> axleInfos;
    public float MaxMotorTorque;
    public float MaxSteeringAngle;

    public float Acceleration;
    public float Brake;

    [SerializeField]
    private bool _drivingForward;

    private void Update()
    {
        _drivingForward = GameObject.Find("GearBoxManager").GetComponent<GearBoxManager>().DrivingForward;
    }

    public void AccelerationInput(float input) 
    {
        if (_drivingForward == true)
        {
            Acceleration = input;
        }
        if(_drivingForward == false)
        {
            Acceleration = -input;
        }
    }
    public void BrakeInput(float input) 
    { 
        Brake = input; 
    }



    public GameObject SteeringWheel;

    public void FixedUpdate()
    {
        //float motor = MaxMotorTorque * Input.GetAxis("Vertical");
        float motor = MaxMotorTorque * Acceleration;
        //float steering = MaxSteeringAngle * Input.GetAxis("Horizontal");
        float steering = MaxSteeringAngle * SteeringWheel.GetComponent<SteeringWheel>().OutPut();

        foreach (AxleInfo axleInfo in axleInfos)
        {
            if(axleInfo.steering)
            {
                axleInfo.leftWheel.steerAngle = steering;
                axleInfo.rightWheel.steerAngle = steering;
            }
            if(axleInfo.motor)
            {
                axleInfo.leftWheel.motorTorque = motor;
                axleInfo.rightWheel.motorTorque = motor;
            }
        }
    }
}
[System.Serializable]
public class AxleInfo
{
    public WheelCollider leftWheel;
    public WheelCollider rightWheel;
    public bool motor;
    public bool steering;
}
