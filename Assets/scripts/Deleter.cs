using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deleter : MonoBehaviour
{
    public movementScript movementScript;

    public int Number;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (movementScript.current == Number)
        {
            Destroy(gameObject);
        }
    }
}
