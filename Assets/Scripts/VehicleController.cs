using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class VehicleController : MonoBehaviour
{
    private const float _vehicleSpeed = 10.0f;
        
    private void FixedUpdate()
    {
        transform.Translate(Time.fixedDeltaTime * _vehicleSpeed * Vector3.forward);
    }
}
