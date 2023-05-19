using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //Private Variable
    private Vector3 _offset = new Vector3(0, 7.75f, -10.25f);

    [Header("GameObject:")]
    public GameObject Player;
    
    void Start()
    {
        
    }

    void LateUpdate()
    {
        //Camera follows the player keeping the offset distance
        transform.position = Player.transform.position + _offset;
    }
}
