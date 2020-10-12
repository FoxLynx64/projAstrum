using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidCombiner : MonoBehaviour
{
    public GameObject asteroid;
    //is a merge being called with another asteroid
    public bool callMerge = false;
    //a random number to help figure out which asteroids script has priority
    public int asteroidNumber;

    private float equatshort = (4 / 3) * Mathf.PI;
    private float equatshortback = Mathf.PI / (4 / 3);


    void Start()
    {
        //sets asteroid number to a random number between 0 and 10
        asteroidNumber = Random.Range(0, 10);

    }

    void OnTriggerEnter (Collider col)
    {
        //if collision is with an asteroid then do this
        if (col.gameObject.tag == "Asteroid")
        {
            //if the other asteroid has not called a merge and our asteroid number is bigger than the other asteroid do this
            if (col.gameObject.GetComponent<asteroidCombiner>().callMerge == false && asteroidNumber > col.gameObject.GetComponent<asteroidCombiner>().asteroidNumber)
            {


                callMerge = true;

                this.gameObject.GetComponent<Rigidbody>().velocity = (this.gameObject.GetComponent<Rigidbody>().velocity +
                    col.gameObject.GetComponent<Rigidbody>().velocity) / 1.75f;

                float thisMass = this.gameObject.GetComponent<Rigidbody>().mass;
                float otherMass = col.GetComponent<Rigidbody>().mass;
                float thisMassRad = thisMass / 2;
                float otherMassRad = otherMass / 2;
                float thisVolume = equatshort * (thisMassRad * thisMassRad * thisMassRad);
                float otherVolume = equatshort * (otherMassRad * otherMassRad * otherMassRad);
                float newVolume = thisVolume + otherVolume;
                float newMass = Mathf.Pow(newVolume / equatshortback, 1f/3f) * 2;
                Debug.Log(newMass);
                this.gameObject.GetComponent<Rigidbody>().mass = newMass;

                Destroy(col.gameObject);
                this.gameObject.transform.localScale = new Vector3(newMass, newMass, newMass);
                callMerge = false;


                if (this.gameObject.GetComponent<Rigidbody>().mass > 1000)
                {

                    callMerge = true;

                    //Instantiate(asteroid, this.gameObject.transform.position + new Vector3(80, 0, 0), Quaternion.identity);
                    //Instantiate(asteroid, this.gameObject.transform.position + new Vector3(80, 0, -80), Quaternion.identity);
                    //Instantiate(asteroid, this.gameObject.transform.position + new Vector3(80, -80, 0), Quaternion.identity);
                    //Instantiate(asteroid, this.gameObject.transform.position + new Vector3(80, 80, 0), Quaternion.identity);
                    //Instantiate(asteroid, this.gameObject.transform.position + new Vector3(0, 80, 0), Quaternion.identity);
                    //Instantiate(asteroid, this.gameObject.transform.position + new Vector3(0, 0, 80), Quaternion.identity);
                    //Instantiate(asteroid, this.gameObject.transform.position + new Vector3(0, 0, -80), Quaternion.identity);
                    //Instantiate(asteroid, this.gameObject.transform.position + new Vector3(0, -80, 0), Quaternion.identity);
                    //Instantiate(asteroid, this.gameObject.transform.position + new Vector3(-80, 0, 0), Quaternion.identity);
                    //Instantiate(asteroid, this.gameObject.transform.position + new Vector3(0, 80, 80), Quaternion.identity);
                    //Instantiate(asteroid, this.gameObject.transform.position + new Vector3(-80, 80, 0), Quaternion.identity);

                    Destroy (this.gameObject);

                }

            }
            //if the two asteroid numbers are equal to eachother do this
            else if (asteroidNumber == col.gameObject.GetComponent<asteroidCombiner>().asteroidNumber)
            {
                //while our asteroid number is equal to the other asteroids number loop through this
                while (asteroidNumber == col.gameObject.GetComponent<asteroidCombiner>().asteroidNumber)
                {
                    //set our asteroid number to another random number between 0 and 10
                    asteroidNumber = Random.Range(0, 10);

                }

                //if the other asteroid has not called a merge and our asteroid number is bigger than the other asteroid do this
                if (col.gameObject.GetComponent<asteroidCombiner>().callMerge == false && asteroidNumber > col.gameObject.GetComponent<asteroidCombiner>().asteroidNumber)
                {

                    callMerge = true;

                    this.gameObject.GetComponent<Rigidbody>().velocity = (this.gameObject.GetComponent<Rigidbody>().velocity + 
                        col.gameObject.GetComponent<Rigidbody>().velocity) / 1.75f;

                    float thisMass = this.gameObject.GetComponent<Rigidbody>().mass;
                    float otherMass = col.GetComponent<Rigidbody>().mass;
                    float thisVolume = (4 / 3) * Mathf.PI * Mathf.Pow((thisMass / 2), 3);
                    float otherVolume = (4 / 3) * Mathf.PI * Mathf.Pow((otherMass / 2), 3);
                    float newVolume = thisVolume + otherVolume;
                    this.gameObject.GetComponent<Rigidbody>().mass = Mathf.Pow(newVolume / Mathf.PI / (4 / 3), 1f/3f) * 2;

                    Destroy(col.gameObject);
                    this.gameObject.transform.localScale = new Vector3(this.gameObject.GetComponent<Rigidbody>().mass, this.gameObject.GetComponent<Rigidbody>().mass, this.gameObject.GetComponent<Rigidbody>().mass);
                    callMerge = false;

                }

            }

        }

        else if (col.gameObject.tag == "Star")
        {

            Destroy(this.gameObject);

        }

    }

}
