using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTrigger1 : MonoBehaviour {
    public GameObject planet;

    void OnTriggerEnter(Collider other)
    {
        planet.SetActive(true);
    }
}
