using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float positionOffScreen = -1f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        float moveHorizontal = Input.GetAxis("Horizontal");

        if (moveHorizontal > 0)
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (moveHorizontal < 0)
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < positionOffScreen)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
