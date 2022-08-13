using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Rigidbody2D RB;
    float playerinput;
    public float speed;

    void Start()
    {
        RB = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        movement();
    }
    void movement()
    {
        playerinput = Input.GetAxis("Horizontal");
        RB.velocity = new Vector2(playerinput * speed, 0);
    }
}