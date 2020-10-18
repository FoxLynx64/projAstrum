using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{

    public ShipStats script;

    public GameObject camRig;

    private int amountBeforePenalty;
    public int warpPenalty;

    public float rotationspeed = 0.5f;
    public float shipspeed = 1;
    public float warpspeed = 1;
    public float Ssensitivity;

    public Rigidbody Rigid;


    void start()
    {

        Ssensitivity = camRig.GetComponent<CameraMovement>().Ssensitivity;

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        keyboard_movement();
        controller_movement();

    }

    void controller_movement()
    {

        if (Input.GetAxis("right trigger") > 0)
        {
            Rigid.AddForce(transform.forward * Input.GetAxisRaw("right trigger") * shipspeed * Time.deltaTime);
            //this.transform.position += transform.forward * Input.GetAxisRaw("right trigger") * shipspeed * Time.deltaTime;

        }

        if (Input.GetAxis("left joystick H") < -0.2 || Input.GetAxis("left joystick H") > 0.2)
        {

            this.transform.Rotate(new Vector3(0, Input.GetAxisRaw("left joystick H") * rotationspeed * Time.deltaTime, 0));

        }

        if (Input.GetAxis("left joystick V") < -0.2 || Input.GetAxis("left joystick V") > 0.2)
        {

            this.transform.Rotate(new Vector3(Input.GetAxisRaw("left joystick V") * rotationspeed * Time.deltaTime, 0, 0));

        }

        camRig.transform.Rotate(new Vector3(0, Input.GetAxis("right joystick") * Ssensitivity * Time.deltaTime, 0), Space.Self);

    }

    void keyboard_movement()
    {

        camRig.transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X") * Ssensitivity * Time.deltaTime, 0), Space.Self);

        if (Input.GetKey(KeyCode.Space))
        {
            Rigid.AddForce(transform.forward * shipspeed * Time.deltaTime);
            //this.transform.position += transform.forward * shipspeed * Time.deltaTime;

        }

        if (Input.GetButtonDown("Fire2") && script.energy > 0)
        {
            
            script.energy -= 1;

        }
        if (Input.GetButton("Fire2") && script.energy > 0)
        {

            this.transform.position += transform.forward * warpspeed * Time.deltaTime;
            Rigid.AddForce(transform.forward * shipspeed * Time.deltaTime);
            if (amountBeforePenalty > 0)
            {

                amountBeforePenalty -= 1;

            }
            else
            {

                amountBeforePenalty = warpPenalty;

                script.energy -= 1;

            }

        }
        if (Input.GetButtonUp("Fire2"))
        {

            amountBeforePenalty = warpPenalty;

        }


        if (Input.GetKey("w"))
        {

            this.transform.Rotate(new Vector3(-rotationspeed * Time.deltaTime, 0, 0));

        }

        if (Input.GetKey("s"))
        {

            this.transform.Rotate(new Vector3(rotationspeed * Time.deltaTime, 0, 0));

        }

        if (Input.GetKey("d"))
        {

            this.transform.Rotate(new Vector3(0, rotationspeed * Time.deltaTime, 0));

        }

        if (Input.GetKey("a"))
        {

            this.transform.Rotate(new Vector3(0, -rotationspeed * Time.deltaTime, 0));

        }

    }
}
