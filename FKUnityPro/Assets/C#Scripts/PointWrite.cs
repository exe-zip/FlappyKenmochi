using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointWrite : MonoBehaviour
{
    int point;
    public TextMeshProUGUI point_counter;
    public GameObject Ago;

    void Start()
    {
        point = 0;
    }

    void Update()
    {
        point_counter.text = $"{point}";
    }

    public void PointPlus()
    {
        if (!Ago.GetComponent<AgoCon>().damage)
        {
            point++;
        }
    }
}