using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotating2D : MonoBehaviour
{
    public Transform Target;


    // Update is called once per frame
    void Update()
    {
        Vector3 relativePos = Target.position + new Vector3(0, -90f, 0) - transform.position;
        transform.rotation = Quaternion.LookRotation(relativePos);


    }
}

