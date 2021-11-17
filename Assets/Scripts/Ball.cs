using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 0;
    public float startspeed = 50;

    void Start()
    {
        speed = startspeed;
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "RacketLeft")
        {
            float y = hitFactor(transform.position, col.transform.position, col.collider.bounds.size.y);

            Vector2 dir = new Vector2(1, y).normalized;

            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
        if(col.gameObject.name == "RacketRight")
        {
            float y = hitFactor(transform.position, col.transform.position, col.collider.bounds.size.y);

            Vector2 dir = new Vector2(-1, y).normalized;

            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
    }

    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketHeight)
    {
        speed += 2;
        return (ballPos.y - racketPos.y) / racketHeight;    
    }
}
