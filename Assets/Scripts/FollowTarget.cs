using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{

    public GameObject person;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - person.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = person.transform.position + offset;
    }
}
