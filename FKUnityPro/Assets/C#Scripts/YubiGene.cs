using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YubiGene : MonoBehaviour
{
    public GameObject Yubi;
    float deltime;

    void Start()
    {
        deltime = 0;
    }

    void Update()
    {
        deltime += Time.deltaTime;
        if (deltime > 1.5f)
        {
            Instantiate(Yubi);
            deltime = 0f;
        }
    }
}
