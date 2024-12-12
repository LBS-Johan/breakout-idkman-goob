using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class livetext : MonoBehaviour
{
    public TextMeshProUGUI uiText;
    public BallPhysics ball;
    // Start is called before the first frame update
    void Start()
    {
        uiText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        uiText.text = "Lives: " + ball.lives.ToString();
    }
}
