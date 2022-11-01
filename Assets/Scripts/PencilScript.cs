using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PencilScript : MonoBehaviour
{
    [SerializeField] private float pencilSpeed;
    private Rigidbody2D pencilRB2D;
    private Vector2 pencilVelocity;
    public static int credits = 0;
    void Start()
    {
        pencilRB2D = GetComponent<Rigidbody2D>();
        pencilVelocity = new Vector2(0, pencilSpeed);
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Homework") {
            Destroy(other.gameObject);
            credits += Upgrades.dotsPerHomework;
        }
        if (other.tag == "Barrier") {
            Destroy(gameObject);
        }
    }

    void FixedUpdate() {
        pencilRB2D.velocity = pencilSpeed * transform.up;
    }
}
