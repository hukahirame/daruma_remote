using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    private Transform cam;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cam = GameObject.FindWithTag("MainCamera").transform;
    }

    void Update()
    {
        float x_rotation = Input.GetAxis("Mouse X");
        float y_rotation = Input.GetAxis("Mouse Y");
        transform.Rotate(0, x_rotation * 2.5f, 0);
        cam.Rotate(-y_rotation * 2.5f, 0, 0);

       // var v = Vector3.zero;
        if (Input.GetKey("w")) transform.Translate(0, 0, speed*Time.deltaTime);
        else if (Input.GetKey("s")) transform.Translate(0, 0, -speed*Time.deltaTime);
        else if (Input.GetKey("a")) transform.Translate(-speed*Time.deltaTime, 0, 0);
        else if (Input.GetKey("d")) transform.Translate(speed * Time.deltaTime, 0, 0);
        Debug.Log(rb.velocity);

    }
}
