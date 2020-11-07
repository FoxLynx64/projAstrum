using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipManager : MonoBehaviour
{

    public GameObject UIGuide;
    public GameObject cube;
    public GameObject sphere;

    private GameObject newGuide;
    private GameObject newCube;
    private GameObject newSphere;

    public float vecX;
    public float vecY;
    public float vecZ;


    void Start()
    {

        newGuide = Instantiate(UIGuide, new Vector3(0, 0, 0), Quaternion.identity);
        newGuide.transform.parent = this.gameObject.transform;

    }

    void Update()
    {

        newGuide.transform.position = new Vector3(vecX, vecY, vecZ);

    }

    public void vecXSet(string newX)
    {

        vecX = float.Parse(newX);

    }
    public void vecYSet(string newY)
    {

        vecY = float.Parse(newY);

    }

    public void vecZSet(string newZ)
    {

        vecZ = float.Parse(newZ);

    }

    public void spawnCube()
    {

        newCube = Instantiate(cube, new Vector3(vecX, vecY, vecZ), Quaternion.identity);
        newCube.transform.parent = this.gameObject.transform;

    }

    public void spawnSphere()
    {

        newSphere = Instantiate(sphere, new Vector3(vecX, vecY, vecZ), Quaternion.identity);
        newSphere.transform.parent = this.gameObject.transform;

    }

}
