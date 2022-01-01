using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgoCon : MonoBehaviour
{
    float move, rotate, die_move;
    public bool damage;

    void Start()
    {
        FirstSet();
    }

    void Update()
    {
        if (damage)
        {
            Die();
        }
        else
        {
            Jump();
            Fall();
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        damage = true;
    }

    public void FirstSet()
    {
        this.transform.position = new Vector3(-3f, 0f, 0f);
        move = 0.12f;
        damage = false;
        die_move = 0.1f;
    }

    void Jump()
    {
        if (Input.GetMouseButtonDown(0))
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

    void Die()
    {
        if (this.transform.position.y > -10f)
        {
            this.transform.position += new Vector3(0.05f, die_move, 0f);
            transform.Rotate(0f, 0f, -20f);
            die_move -= 0.005f;
            Destroy(this.gameObject);
        }
    }
}
