using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class movementScript : MonoBehaviour
{
    public Transform[] target;
    public float speed;

    public int current;
    public float Speedtest;
    public float Speedtest2;
    public float Speedtest3;

    

    //public float turnSpeed = .01f;
    //Quaternion rotGoal;
    //Vector3 direction;

    //public int[] left;
    //public int[] right;
    void Start()
    {
        
    }


    void Update()
    {
        


        if (current == Speedtest)
        {
            speed = 0.6f;
        }
               
        if (current == Speedtest2)
        {
            speed = 20f;
        }

        if (current == Speedtest3)
        {
            speed = 0f;
        }



        if (transform.position != target[current].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
        else current = (current + 1) % target.Length;

        
    }
    //void TurnLeft()
    //{
        //direction = transform.position + new Vector3(0, 0, 90);
        //rotGoal = Quaternion.LookRotation(direction);
        //transform.rotation = Quaternion.Slerp(transform.rotation, rotGoal, turnSpeed);
    //}

    //void TurnRight()
    //{
       // Vector3 rotationVector = new Vector3(0, 0, -90);
        //Quaternion rotation = Quaternion.Euler(rotationVector);
    //}
}
