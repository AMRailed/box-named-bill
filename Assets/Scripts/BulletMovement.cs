using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{

    [SerializeField] float BulletSpeed = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(new Vector3(0, 90, 0));
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.forward * BulletSpeed;
    }
}
