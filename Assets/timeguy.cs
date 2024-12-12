using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeguy : MonoBehaviour
{
    public int goober = 0;
    public BallPhysics ball;
    Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = new Vector2(0, -1);
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.sigma == 1)
        {
            transform.position = new Vector3(-15.56f, -2.01f);
            ball.sigma = 2;
        }
        if (transform.position.y < -50 && ball.sigma == 2)
        {
            goober = 1;
            ball.sigma = 0;
        }
    }
}
