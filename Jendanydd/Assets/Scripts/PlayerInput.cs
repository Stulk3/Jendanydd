using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Vector2 turn;
    void Update()
    {
        turn.x = Input.GetAxis("Mouse X");    
        turn.y = Input.GetAxis("Mouse Y");   

        transform.rotation = Quaternion.Euler(-turn.y, turn.x, 0);  
    }
}
