using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashaBILITY : MonoBehaviour
{
    [SerializeField] int DashDistance = 10;
    [SerializeField] GameObject player;
    [SerializeField] Rigidbody rb;

    void Start()
    {
	rb = gameObject.GetComponent<Rigidbody>();
        InvokeRepeating("Dash", 5, 5);
    }
    
    void Dash()
    {
        rb.AddForce(player.transform.position-transform.position*DashDistance, ForceMode.Impulse);
    }
}
