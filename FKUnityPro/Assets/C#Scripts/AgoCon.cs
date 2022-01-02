using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgoCon : MonoBehaviour
{
    public GameObject GM;
    float move, rotate, die_move;

    void Start()
    {
        GM = GameObject.Find("GameManager");
        FirstSet();
    }

    void Update()
    {
        if (GM.GetComponent<GameCon>().game_mode == 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                GM.GetComponent<GameCon>().game_mode = 1;
            }
            PreGame();
        }
        else if (GM.GetComponent<GameCon>().game_mode == 1) 
        {
            Jump();
            Fall();
        }
        else
        {
            Die();
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        GM.GetComponent<GameCon>().game_mode = 2;
    }

    public void FirstSet()
    {
        this.transform.position = new Vector3(-3f, 0f, 0f);
        move = 0.12f;
        die_move = 0.1f;
    }

    void PreGame()
    {
        this.transform.eulerAngles += new Vector3(0f, 0f, 3f);
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
        GM.GetComponent<GameCon>().game_mode = 2;
        if (this.transform.position.y > -10f)
        {
            if (this.transform.position.y > -6f)
            {
                this.transform.position += new Vector3(0.05f, die_move, 0f);
                transform.Rotate(0f, 0f, -20f);
                die_move -= 0.005f;
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }
}
