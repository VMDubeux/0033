using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class PlayerController2 : MonoBehaviour
{
    //Private Variables
    private float _speed = 10.0f;
    private float _rotateSpeed = 15.0f;
    private float _horizontalOffset = 0.0f;
    private float _verticalOffset = 0.0f;

    void Start()
    {

    }

    void Update()
    {
        _horizontalOffset = Input.GetAxis("Horizontal_2");
        _verticalOffset = Input.GetAxis("Vertical_2");

        //Vehicle goes forward and backward
        transform.Translate(Vector3.forward * Time.deltaTime * _speed * _verticalOffset);

        if (_verticalOffset != 0)
        {
            //Vehicle turns right and left 
            transform.Rotate(Vector3.up, Time.deltaTime * _rotateSpeed * _horizontalOffset);
        }
    }
}
