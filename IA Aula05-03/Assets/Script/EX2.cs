using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX2 : MonoBehaviour
{   
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3((-3), 1, -9), Time.deltaTime);
    }
}
