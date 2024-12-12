using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class textpoint : MonoBehaviour
{
    public TextMeshProUGUI scoreui;
    public BallPhysics ball;
    // Start is called before the first frame update
    void Start()
    {
        scoreui = GetComponent<TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreui.text = "Points: " + ball.point.ToString();
    }
}
