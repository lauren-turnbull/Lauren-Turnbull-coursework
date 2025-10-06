using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Color randomlySelectedColor = GetRandomColor();
        GetComponent<Renderer>().material.color = randomlySelectedColor;

    }
    
    Color GetRandomColor()
    {
        return new Color(
            r:UnityEngine.Random.Range(0f, 1f),
            g:UnityEngine.Random.Range(0f, 1f),
            b:UnityEngine.Random.Range(0f, 1f));
    }
}

