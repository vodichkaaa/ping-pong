using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    private const int V = 10;
    [SerializeField] public TextMesh Text;
    [SerializeField] public GameObject ball;
    [SerializeField] public Ball speedController;
 
    public float x = 0;
    public int _points = 0;
    void OnTriggerEnter2D(Collider2D col)
    {
        ++_points;
        Text.text = "" + _points;

        speedController.speed = speedController.startspeed;
        var speedvc = speedController.GetComponent<Rigidbody2D>();
        speedvc.velocity = speedvc.velocity.normalized * speedController.startspeed;

        ball.transform.position = new Vector2(x, 0);       
    }

    void Update()
    {
        if (_points == 5 && gameObject.name == "LeftTrigger")
        {
            SceneManager.LoadScene("RightVictory");
        }
        if (_points == 5 && gameObject.name == "RightTrigger")
        {
            SceneManager.LoadScene("LeftVictory");
        }
    }
}
