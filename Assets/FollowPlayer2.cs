using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer2 : MonoBehaviour
{
    //Private Variable
    private Vector3 _offset1 = new Vector3(0, 7.75f, -10.25f);
    private Vector3 _offset2 = new Vector3(0, 4.25f, 1.0f);
    private float _counter = 0.0f;

    [Header("GameObject:")]
    public GameObject Player;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            _counter++;
            Debug.Log(_counter);

            if (_counter >= 2.0f)
            {
                _counter = 0.0f;
            }
        }
    }

    void LateUpdate()
    {
        switch (_counter)
        {
            case 0.0f:
                //Camera follows the player keeping the offset1 distance
                transform.position = Player.transform.position + _offset1;
                break;
            case 1.0f:
                //Camera follows the player keeping the offset1 distance
                transform.position = Player.transform.position + _offset2;
                break;
        }
    }
}
