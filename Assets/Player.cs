using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    public float speed=2000;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown("w")) rb.AddForce(new Vector3(0,0,speed));
        else if (Input.GetKeyDown("s")) rb.AddForce(new Vector3(0, 0, -speed));
        else if (Input.GetKeyDown("a")) rb.AddForce(new Vector3(-speed, 0, 0));
        else if (Input.GetKeyDown("d")) rb.AddForce(new Vector3(speed, 0, 0));
    }
}
