using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipManager : MonoBehaviour
{

    public GameObject cube;
    public GameObject sphere;

    public float vecX;
    public float vecY;
    public float vecZ;


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

        Instantiate(cube, new Vector3(vecX, vecY, vecZ), Quaternion.identity);

    }

    public void spawnSphere()
    {

        Instantiate(sphere, new Vector3(vecX, vecY, vecZ), Quaternion.identity);

    }

}
