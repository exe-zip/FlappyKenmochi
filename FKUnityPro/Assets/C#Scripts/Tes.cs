using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tes : MonoBehaviour
{
    float move;

    void Start()
    {
        move = 0.2f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            move = 0.2f;
        }
        this.transform.position += new Vector3(0f, move, 0f);
        move -= 0.01f;
    }
}