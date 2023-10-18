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
        if (i == 1) transform.Rotate(0, 0, -90);
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y-4f, transform.eulerAngles.z);

        i++;

        if (i < 40)
        {
            Invoke("Strike", 0.015f);
        }
        else
        {
            i = 2; //一時終了
            StrikeCooldown();
        }
    }
    private void StrikeCooldown()
    {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y+4f, transform.eulerAngles.z);

        j++;

        if (j < 40)
        {
            Invoke("StrikeCooldown", 0.03f);
        }
        else
        {
            i = 1;
            j = 1; //終了
            transform.localEulerAngles = new Vector3(0, 0, 0);
        }
    }
}
