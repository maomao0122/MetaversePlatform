using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CollisionVocalization : MonoBehaviour
{
    public AudioSource audioSource;
    private Rigidbody myrigidbody;
    

    public void OnCollisionEnter(Collision collision)
    {
        if(myrigidbody.velocity.magnitude>10.0f){
            audioSource.volume = 1.0f;
        }
        else{
            audioSource.volume = myrigidbody.velocity.magnitude / 10.0f;
        }
        Debug.Log("OnCollision velicity:" + myrigidbody.velocity.magnitude);
        audioSource.Play();

    }

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        myrigidbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
