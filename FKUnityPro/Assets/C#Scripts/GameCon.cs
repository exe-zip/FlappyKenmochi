using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCon : MonoBehaviour
{
    public GameObject Ago;
    public int game_mode;

    void Start()
    {
        GameStart();
    }

    void Update()
    {
        
    }

    public void GameStart()
    {
        DestriyObjects();
        game_mode = 0;
        Instantiate(Ago);
        this.gameObject.GetComponent<PointWrite>().point = 0;
    }

    void DestriyObjects()
    {
        GameObject[] destroy_list = GameObject.FindGameObjectsWithTag("Destroy");
        foreach (GameObject objects in destroy_list)
        {
            Destroy(objects);
        }
    }
}
