using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private Variables
    private const float _speed = 10.0f;
    private readonly float _rotateSpeed = 15.0f;
    [SerializeField] private float _horizontalOffset;
    [SerializeField] private float _verticalOffset;

    void Start()
    {

    }

    void FixedUpdate()
    {
        _horizontalOffset = Input.GetAxis("Horizontal");
        _verticalOffset = Input.GetAxis("Vertical");

        //Vehicle goes forward and backward
        transform.Translate(_speed * _verticalOffset * Time.fixedDeltaTime * Vector3.forward);

        if (_verticalOffset != 0)
        {
            //Vehicle turns right and left 
            transform.Rotate(Vector3.up, Time.fixedDeltaTime * _rotateSpeed * _horizontalOffset);
        }
    }
}
