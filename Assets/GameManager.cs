using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float time; //経過時間

    public static int op; //不吉度

    void Start()
    {
        
    }

    void Update()
    {
        time += Time.deltaTime;
    }
}
