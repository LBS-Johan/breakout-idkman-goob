using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup : MonoBehaviour
{
    public BallPhysics ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.notify == 1)
        {
            transform.position = new Vector2(125f, 100f);
            ball.notify = 0;
        }
    }
}
