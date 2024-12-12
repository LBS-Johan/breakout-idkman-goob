using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformMove : MonoBehaviour
{
    Rigidbody2D rigidbody;
    public BallPhysics ball;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float Aspeed = -5 - ball.powerupseed;
        float Dspeed = 5 + ball.powerupseed;
        rigidbody.velocity = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.A))
        {
            rigidbody.velocity = new Vector2(-5, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rigidbody.velocity = new Vector2(5, 0);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }
}
