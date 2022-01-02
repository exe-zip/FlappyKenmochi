using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCon : MonoBehaviour
{
    public GameObject Ago;
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
