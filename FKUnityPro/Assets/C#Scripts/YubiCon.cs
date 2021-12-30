using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YubiCon : MonoBehaviour
{
    void Start()
    {
        this.transform.position = new Vector3(10f, Random.Range(-2.5f, 2.5f), 0f);
    }

    void Update()
    {
        if (this.transform.position.x > -10f)
        {
            this.transform.position += new Vector3(-0.05f, 0f, 0f);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
