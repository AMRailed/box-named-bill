using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 10;
    [SerializeField] float jumpHeight = 10;
    [SerializeField] Rigidbody rb;
    [SerializeField] Transform groundcheck;
    [SerializeField] LayerMask ground;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();  
    }

    
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        rb.velocity = new Vector3 (horizontalInput*speed*Time.deltaTime, rb.velocity.y, verticalInput*speed*Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpHeight, rb.velocity.z);
        }
    }

    bool IsGrounded()
    {
        return Physics.CheckSphere(groundcheck.position, 1f, ground);
    }
}
