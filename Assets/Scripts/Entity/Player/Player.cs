using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField]
    private float jumpPower;
    private int jumpCount = 2;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            jumpCount = 2;
        }
    }

    public void Jump()
    {
        if (jumpCount > 0)
        {
            jumpCount--;
            rb.velocity = Vector3.zero;
            rb.AddForce(Vector2.up * jumpPower);
        }
    }
}
