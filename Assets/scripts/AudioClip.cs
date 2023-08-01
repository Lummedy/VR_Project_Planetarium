using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioClip : MonoBehaviour
{
    public movementScript movementScript;
    public int Number;
    bool AudioB;
    AudioSource Audio;
    // Start is called before the first frame update
    void Start()
    {
        Audio = GetComponent<AudioSource>();
        AudioB = true;
    }

    // Update is called once per frame
    void Update()
    {
       if (movementScript.current == Number && AudioB == true)
        {
            Audio.Play(0);
            Debug.Log("yes");
            AudioB = false;
        }
    }
}
