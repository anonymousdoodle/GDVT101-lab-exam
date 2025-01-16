// for when the car moves

using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    public float speed;

    public Rigidbody rigidb;

    void Start()
    {
        rigidb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        

        float speed = 5;
        float speedtime = speed * Time.deltaTime;


        if (Input.GetKey(KeyCode.UpArrow))
        {
            // none
        }


        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
       

        rigidb.AddForce(movement * speedtime);
    }
}
