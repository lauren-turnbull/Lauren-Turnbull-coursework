using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newplanet : MonoBehaviour
{

    #region member variables

    public GameObject[] Planets
    {
        get { return planets; }
        set { planets = value; }
    }
    [SerializeField]
    private GameObject[] planets;

    #endregion

    private Camera cam;
    private Vector3 startPoint;
    private Vector3 endPoint;
    private Vector3 screenStartPoint;
    private Vector3 screenEndPoint;
    public float multiplier;
    public Vector3 startVelocity;
    private scoreScript ScoreScript;


    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            OnMouseDown();
        }
        
        if (Input.GetButtonUp("Fire1"))
        {
            OnMouseUp();
        }
    }

    private void OnMouseDown()
    {
        screenStartPoint = Input.mousePosition;
        screenStartPoint.z = cam.nearClipPlane + 50;
        startPoint = cam.ScreenToWorldPoint(screenStartPoint);
    }

    private void OnMouseUp()
    {
        screenEndPoint = Input.mousePosition;
        screenEndPoint.z = cam.nearClipPlane + 50;
        endPoint = cam.ScreenToWorldPoint(screenEndPoint);

        startVelocity = startPoint - endPoint;
        startVelocity =  startVelocity * multiplier;

        GameObject planet = planets[Random.Range(0, planets.Length)];

        Vector3 spawnPosition = endPoint;
        Quaternion spawnRotation = Quaternion.identity;

        Instantiate(planet, spawnPosition, spawnRotation);

        ScoreScript = this.GetComponent<scoreScript>();
        ScoreScript.updateScore(1);
    }
}
