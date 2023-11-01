using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{
    int i = 1;
    int j = 1;

    void Start()
    {

    }

    void Update()
    {
        if ((Input.GetMouseButtonUp(0))&&(i+j ==2)) Strike();
    }
    public void Strike() //アニメーション
    {
        if (i == 1)
        {
            transform.Translate(new Vector3(0.1f,0,-0.05f));
            transform.Rotate(0, -90, 0);
            transform.Rotate(-20, 0, 0);
            transform.Rotate(0, 0, 20);
        }
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z+3f);

        i++;

        if (i < 40)
        {
            Invoke("Strike", 0.015f*Time.deltaTime);
        }
        else
        {
            i = 2; //一時終了
            StrikeCooldown();
        }
    }

    private void StrikeCooldown()
    {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z-3f);

        j++;

        if (j < 40)
        {
            Invoke("StrikeCooldown", 0.02f*Time.deltaTime);
        }
        else
        {
            i = 1;
            j = 1; //終了
            transform.Rotate(0, 0, -20);
            transform.Rotate(20, 0, 0);
            transform.Rotate(0, 90, 0); 
            transform.Translate(new Vector3(-0.1f, 0, 0.05f));
        }
    }
}
