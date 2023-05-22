using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class VehicleController : MonoBehaviour
{
    public float VehicleSpeed = 20.0f;
        
    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * VehicleSpeed);
    }
}
