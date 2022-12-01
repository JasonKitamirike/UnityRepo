using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePhysicsScript : MonoBehaviour
{
    float rotateSpeed = 3;
    Rigidbody ourRigidBody;
    Quaternion lastOrientation;

    

    // Start is called before the first frame update
    void Start()
    {
        ourRigidBody = GetComponent<Rigidbody>();

        lastOrientation = transform.rotation;
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {

        //if (Input.GetKey(KeyCode.Space))
        //{
        //   ourRigidBody.AddForce(Vector3.up);
        //}
        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //   transform.Rotate(Vector3.right, rotateSpeed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    transform.Rotate(Vector3.right, -rotateSpeed * Time.deltaTime);
        //}
        // if (Input.GetKey(KeyCode.LeftArrow))
        //{
        // transform.Rotate(Vector3.forward, rotateSpeed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //transform.Rotate(Vector3.forward, -rotateSpeed * Time.deltaTime);
        //}
        if (Input.GetKey(KeyCode.Space))
        {
            ourRigidBody.AddRelativeForce(force: Vector3.forward);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.RotateAroundLocal(Vector3.forward, rotateSpeed * Time.deltaTime );
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.RotateAroundLocal(Vector3.forward, -rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.RotateAroundLocal(Vector3.right, rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.RotateAroundLocal(Vector3.right, -rotateSpeed * Time.deltaTime);
        }


        if (spaceShipIsTooTilted())
            transform.rotation = lastOrientation;
        else
            lastOrientation = transform.rotation;

    }

    private bool spaceShipIsTooTilted()
    {
        return (Vector3.Dot(transform.up, Vector3.up) < 0.7071f);
    }
}
