using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallPhysics : MonoBehaviour
{
    public int point = 0;
    Rigidbody2D rigidbody;
    public int lives = 3;
    public int powerupseed = 0;
    public int notify = 0;
    public int sigma = 0;
    public timeguy time;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = new Vector2(0, -1);
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 8;
        rigidbody.velocity = rigidbody.velocity.normalized * speed;
        if (lives > 0)
        {

        }else
        {
            SceneManager.LoadScene("end");
        }
        if (point == 28)
        {
            SceneManager.LoadScene("win");
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            rigidbody.velocity = new Vector2(0, 0f);
            sigma = 1;
            transform.position = new Vector3(0, -1.5f);
            
        }
        if (time.goober == 1)
        {
            time.goober = 0;
            rigidbody.velocity = new Vector2(0, -1);

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "below")
        {
            lives -= 1;
        }else if (collision.gameObject.tag == "platform")
        {

        }else if (collision.gameObject.tag == "NoDestroy")
        {

        }
        else
        {
            Destroy(collision.gameObject);
            point += 1;
            System.Random guy = new System.Random();
            int sigma = guy.Next(1, 10);
            if (sigma == 1)
            {
                powerupseed += 3;
                notify = 1;
            }
        }
    }
}
