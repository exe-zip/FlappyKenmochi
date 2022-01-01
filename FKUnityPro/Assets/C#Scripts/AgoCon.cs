using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgoCon : MonoBehaviour
{
    float move, rotate;
    bool damage;

    void Start()
    {
        move = 0.12f;
        damage = false;
    }

    void Update()
    {
        Jump();
        Fall();
        Debug.Log(damage);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        damage = true;
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            move = 0.12f;
            rotate = 0f;
            this.transform.eulerAngles = new Vector3(0f, 0f, 20f);
        }
    }

    void Fall()
    {
        this.transform.position += new Vector3(0f, move, 0f);
        this.transform.eulerAngles += new Vector3(0f, 0f, rotate);
        move -= 0.0058f;
        rotate -= 0.04f;
    }
}
