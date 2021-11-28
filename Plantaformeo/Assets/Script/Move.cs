using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float Speed  = 2;
    public float jSpeed = 2;
    Rigidbody2D rb2d;

    public static int points;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2d.velocity = new Vector2(Speed, rb2d.velocity.y);
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2d.velocity = new Vector2(-Speed, rb2d.velocity.y);
        }
        else {
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
        }
        if (Input.GetKey("space") && Jump.isGround) {
            rb2d.velocity = new Vector2(rb2d.velocity.x,jSpeed);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fruit")) {
            Destroy(collision.gameObject);
            points += 1;
        }
    }

}
