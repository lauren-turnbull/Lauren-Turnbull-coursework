using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetmovement : MonoBehaviour
{
    public Vector3 planet_velocity;
    public float grav_constant;
    public bool valid;
    public float distance;

    // Start is called before the first frame update
    void Start()
    {
        grav_constant = -4000;
        valid = true;

        planet_velocity = GameObject.Find("GameController").GetComponent<newplanet>().startVelocity;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 pos = transform.position;
        float acceleration_scalar;
        Vector3 acceleration;
        
        distance = Mathf.Sqrt(Mathf.Pow(pos.x,2) + Mathf.Pow(pos.y,2) + Mathf.Pow(pos.z,2));
            
        acceleration_scalar = grav_constant / Mathf.Pow(distance, 2);
        acceleration.x = acceleration_scalar * pos.x / distance;
        acceleration.y = acceleration_scalar * pos.y / distance;
        acceleration.z = acceleration_scalar * pos.z / distance;
        planet_velocity.x += acceleration.x * Time.deltaTime;
        planet_velocity.y += acceleration.y * Time.deltaTime;
        planet_velocity.z += acceleration.z * Time.deltaTime;

        pos.x += planet_velocity.x * Time.deltaTime;
        pos.y += planet_velocity.y * Time.deltaTime;
        pos.z += planet_velocity.z * Time.deltaTime;

        transform.position = pos;
    }
}