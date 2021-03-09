using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX1 : MonoBehaviour
{
    
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(0,1,-8), Time.deltaTime);
    }
}
