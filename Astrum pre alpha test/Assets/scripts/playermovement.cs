using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{

    public float rotationspeed = 0.5f;
    public float shipspeed = 1;
    public Rigidbody Rigid;


    // Update is called once per frame
    void Update()
    {

        keyboard_movement();
        controller_movement();

        if (Input.GetKey("escape"))
        {

            Application.Quit();

        }

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

    }

    void keyboard_movement()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            Rigid.AddForce(transform.forward * shipspeed * Time.deltaTime);
            //this.transform.position += transform.forward * shipspeed * Time.deltaTime;

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
