using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class PlayerController2 : MonoBehaviour
{
    //Private Variables
    private readonly float _speed = 10.0f;
    private readonly float _rotateSpeed = 15.0f;
    [SerializeField] private float _horizontalOffset = 0.0f;
    [SerializeField] private float _verticalOffset = 0.0f;

    void Start()
    {

    }

    void FixedUpdate()
    {
        _horizontalOffset = Input.GetAxis("Horizontal_2");
        _verticalOffset = Input.GetAxis("Vertical_2");

        //Vehicle goes forward and backward
        transform.Translate(_speed * _verticalOffset * Time.fixedDeltaTime * Vector3.forward);

        if (_verticalOffset != 0)
        {
            //Vehicle turns right and left 
            transform.Rotate(Vector3.up, Time.fixedDeltaTime * _rotateSpeed * _horizontalOffset);
        }
    }
}
