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
        GameObject[] yubi_list = GameObject.FindGameObjectsWithTag("Yubi");
        foreach (GameObject yubis in yubi_list)
        {
            Destroy(yubis);
        }
        Instantiate(Ago);
    }
}
