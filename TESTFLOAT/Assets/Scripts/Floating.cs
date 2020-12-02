using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floating : MonoBehaviour
{

    
    public float speed = 1f;
    public float distance = 1f;
    public bool FreezeMe = false;
    

    void Update()
    {
        if (!FreezeMe)
        {

            Vector3 move = new Vector3(transform.position.x, Mathf.Sin(speed * Time.time) * distance, transform.position.z);
            transform.position = move;

        }
    }
}
