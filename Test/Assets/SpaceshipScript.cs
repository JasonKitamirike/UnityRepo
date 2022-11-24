using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipScript : MonoBehaviour
{
    public GameObject MissileCloneTemplate;
    float rotateSpeed = 45;
    Vector3 velocity, acceleration;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(Vector3.right, rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(Vector3.right,- rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward, rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.forward, -rotateSpeed * Time.deltaTime);
        }


        if (Input.GetKey(KeyCode.Space))
        {
            acceleration = 5 * transform.forward;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            fireMissile();
        }

        velocity += acceleration * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;

    }

    private void fireMissile()
    {
        Instantiate(MissileCloneTemplate, transform.position,transform.rotation);
    }
}
