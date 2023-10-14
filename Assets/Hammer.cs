using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{
    void Start()
    {
        Invoke("Strike", 2f);  
    }

    /*private void Update()
    {
        if(Input.GetKey("e"))
        {
            Strike();
        }
    }*/
    public void Strike() //アニメーション
    {
        transform.rotation = Quaternion.Euler(0, 0, 115);
        for (int i = 0; i < 20; i++)
        {
            transform.Rotate(0, 0, 2f * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0, 90, 115);
        }

    }
}
