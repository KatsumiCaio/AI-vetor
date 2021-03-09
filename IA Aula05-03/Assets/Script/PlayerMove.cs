using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float velocity = 10;

    void Start()
    {
       
    }

   
    void Update()
    {
        Vector3 dir = new Vector3(
           Input.GetAxis("Horizontal"), 0,
           Input.GetAxis("Vertical")
           ) * velocity;

        transform.Translate(dir * Time.deltaTime, Space.World);
    }
}
