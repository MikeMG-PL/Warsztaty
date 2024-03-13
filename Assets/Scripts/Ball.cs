using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            rb.AddForce(new Vector3(collision.gameObject.GetComponent<Player>().Axis * 4, 0, 0), ForceMode.Impulse);
            collision.gameObject.GetComponent<Player>().IncrementScore();
        }
    }
}
