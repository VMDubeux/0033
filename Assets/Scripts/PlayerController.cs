using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private Variables
    private float _speed = 10.0f;
    private float _rotateSpeed = 15.0f;
    private float _horizontalOffset;
    private float _verticalOffset;

    void Start()
    {

    }

    void Update()
    {
        _horizontalOffset = Input.GetAxis("Horizontal");
        _verticalOffset = Input.GetAxis("Vertical");

        //Vehicle goes forward and backward
        transform.Translate(Vector3.forward * Time.deltaTime * _speed * _verticalOffset);

        if (_verticalOffset != 0)
        {
            //Vehicle turns right and left 
            transform.Rotate(Vector3.up, Time.deltaTime * _rotateSpeed * _horizontalOffset);
        }
    }
}
