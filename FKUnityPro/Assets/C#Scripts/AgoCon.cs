using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgoCon : MonoBehaviour
{
    float move;

    void Start()
    {
        move = 0.11f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            move = 0.11f;
        }
        this.transform.position += new Vector3(0f, move, 0f);
        move -= 0.0058f;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("b");
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("a");
    }
}
