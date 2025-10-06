using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exampleMakingSphere : MonoBehaviour
{
    //public planetmovement planet_movement;

    // Start is called before the first frame update
    void Start()
    {
        //planet_movement = GetComponent<planetmovement>();
        new Planet1();
        //public float velocity;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            new Planet1();
        }
        //planet_movement.velocity = new Vector3(0f,0f,0f);
    }
}


public class Planet1
{
    public Vector3 screenPosition;
    public Vector3 worldPosition;
    //constructor

    public Planet1()
    {
        screenPosition = Input.mousePosition;
        screenPosition.z = Camera.main.nearClipPlane + 50;
        worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);
        

        //Vector3 velocity;
        //public float velocity;
        GameObject newPlanet = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        //newPlanet.transform.position = new Vector3 (10f,10f,10f); //find where they clicked
        newPlanet.transform.position = worldPosition;
        newPlanet.transform.localScale = new Vector3 (3f,3f,3f); // do this randomly
        //when user clicks
        newPlanet.AddComponent<planetmovement>();
        //newPlanet.Planetmovement.Grav_constant = -10;
        //Grav_constant = newPlanet.GetComponent<Grav_constant>;
        //newPlanet.planetmovement.Grav_constant = -4000;
        //velocity = newPlanet.GetComponent<planet_velocity>;
        //velocity = new Vector3(1f,1f,1f);
        //velocity = newPlanet.FindWithTag("planet_velocity");
        //velocity = new Vector3(1f,1f,1f);
        //velocity = GameObject.FindWithTag("planet_velocity");
        //velocity = planet_movement.planet_velocity;

        //velocity = new Vector3(100f,100f,100f);
        //planet_movement.planet_velocity = velocity;
    }

}
