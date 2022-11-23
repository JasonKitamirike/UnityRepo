using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePhysicsScript : MonoBehaviour
{
    Rigidbody ourRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        ourRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            ourRigidBody.AddForce(Vector3.up);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            ourRigidBody.AddExplosionForce(100,
                transform.position + Vector3.down + Vector3.back,
                1);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            RotateRight();
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.back, Time.deltaTime);
        }
    }

    private void RotateRight()
    {
        transform.Rotate(Vector3.forward, Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("Ouch");
    }


}
