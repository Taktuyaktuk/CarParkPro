using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SteeringWheel : MonoBehaviour,IDragHandler,IPointerDownHandler,IPointerUpHandler
{

    private bool _wheelBeingHeld = false;
    public RectTransform Wheel;
    private float _wheelAngle = 0f;
    private float _lastWheelAngle = 0f;
    private Vector2 _center;
    public float MaxSteerAngle = 200;
    public float ReleaseSpeed = 300f;
    public float OutPut;



    void Update()
    {
        if(!_wheelBeingHeld && _wheelAngle != 0f)
        {
            float DeltaAngle = ReleaseSpeed * Time.deltaTime;
            if(Mathf.Abs(DeltaAngle) > Mathf.Abs(_wheelAngle))
            {
                _wheelAngle = 0f;
            }    
            else if(_wheelAngle > 0f)
            {
                _wheelAngle -= DeltaAngle;
            }
            else
            {
                _wheelAngle += DeltaAngle;
            }
        }
        Wheel.localEulerAngles = new Vector3(0, 0, -_wheelAngle);
        OutPut = _wheelAngle / MaxSteerAngle;
    }

    public void OnPointerDown (PointerEventData data)
    {
        _wheelBeingHeld = true;
        _center = RectTransformUtility.WorldToScreenPoint(data.pressEventCamera, Wheel.position);
        _lastWheelAngle = Vector2.Angle(Vector2.up, data.position - _center);
    }

    public void OnDrag(PointerEventData data)
    {
        float NewAngle = Vector2.Angle(Vector2.up, data.position - _center);
        if((data.position - _center).sqrMagnitude >=400)
        {
            if(data.position.x > _center.x)
            {
                _wheelAngle += NewAngle - _lastWheelAngle;
            }
            else
            {
                _wheelAngle -= NewAngle - _lastWheelAngle;
            }
        }
        _wheelAngle = Mathf.Clamp(_wheelAngle, -MaxSteerAngle, MaxSteerAngle);
        _lastWheelAngle = NewAngle;
    }

    public void OnPointerUp(PointerEventData data)
    {
        OnDrag(data);
        _wheelBeingHeld = false;
    }
}
