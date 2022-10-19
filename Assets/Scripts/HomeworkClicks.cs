using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeworkClicks : MonoBehaviour
{
    private float speed = 0.01f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Vector2.zero, speed);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            Destroy(gameObject);
        }
    }
}
