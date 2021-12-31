using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgoCon : MonoBehaviour
{
    float move;

    void Start()
    {
        move = 0.12f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            move = 0.12f;
        }
        this.transform.position += new Vector3(0f, move, 0f);
        move -= 0.0058f;
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("a");
    }
}
