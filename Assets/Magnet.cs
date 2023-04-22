using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Stone"))
        {
            var joint = GetComponent<FixedJoint2D>();
            joint.connectedBody = collision.GetComponent<Rigidbody2D>();
            joint.enabled = true;
        }
    }
}
