using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    [SerializeField] float steerSpeed = 150f;
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float slowSpeed = 10f;
    [SerializeField] float boostSpeed = 15f;

    void Update()
    {   
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        
        transform.Rotate( 0, 0, -steerAmount);
        transform.Translate( 0, moveAmount, 0);
    }
    void OnCollisionEnter2D(Collision2D other) 
    {
            moveSpeed = slowSpeed;
    }
    void OnTriggerEnter2D(Collider2D other) 
        {
            if(other.tag == "Boost")
            {
                moveSpeed = boostSpeed;
            }
        }
}
