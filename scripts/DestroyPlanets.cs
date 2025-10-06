using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlanets : MonoBehaviour
{
    public float distance;
    private scoreScript ScoreScript;
    //public ParticleSystem explosionParticle;


    void Start()
    {
        ScoreScript = GameObject.Find("GameController").GetComponent<scoreScript>();
    }

    void Update()
    {
        Vector3 pos = transform.position;
        distance = Mathf.Sqrt(Mathf.Pow(pos.x,2) + Mathf.Pow(pos.y,2) + Mathf.Pow(pos.z,2));
        
        if (distance < 5 || distance > 300)
        {
            Destroy(this.gameObject);

            //Instantiate(explosionParticle, transform.position,explosionParticle.transform.rotation);

            ScoreScript.updateScore(-1);
            ScoreScript.updateLives(-1);
        }
    }
}
