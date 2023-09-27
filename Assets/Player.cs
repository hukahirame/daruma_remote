using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey("w")) transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        else if (Input.GetKey("s")) transform.position += new Vector3(0, 0, -speed * Time.deltaTime);
        else if (Input.GetKey("a")) transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        else if (Input.GetKey("d")) transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
    }
}
