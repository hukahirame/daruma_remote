using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float time; //�o�ߎ���

    public static int op; //�s�g�x

    void Start()
    {
        
    }

    void Update()
    {
        time += Time.deltaTime;
    }
}
