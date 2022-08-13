using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class paddle_script : MonoBehaviour
{
    private Rigidbody2D RB;
    float playerinput;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        RB = Getcomponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        movement();
    }

    void movement()
    {
        playerinput = Input.GetAxis("Horizontal");
        RB.velocity = new Vector2(playerinput * speed, 0);
    }
}
