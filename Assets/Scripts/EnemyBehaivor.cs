using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyBehaivor : MonoBehaviour
{
    [SerializeField] float Speed = 10f;
    [SerializeField] Rigidbody rb;
    [SerializeField] Transform Target;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce((Target.position-transform.position).normalized * (Speed*10) * Time.deltaTime);
    }
}
