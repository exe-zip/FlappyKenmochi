using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YubiCon : MonoBehaviour
{
    public GameObject GM;
    int move;

    void Start()
    {
        this.transform.position = new Vector3(10f, Random.Range(-2.5f, 2.5f), 0f);
        GM = GameObject.Find("GameManager");
        move = 0;
    }

    void Update()
    {
        if (this.transform.position.x > -10f)
        {
            this.transform.position += new Vector3(-0.05f, 0f, 0f);
            move++;
        }
        else
        {
            Destroy(this.gameObject);
        }
        if (move == 270 && GM.GetComponent<GameCon>().game_mode == 1)    
        {
            GM.GetComponent<PointWrite>().PointPlus();
        }
    }
}
