using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pencil180 : MonoBehaviour
{
    [SerializeField] private float pencilSpeed;
    private float pencilAngle;
    private Rigidbody2D pencilRB2D;
    private Vector2 pencilVelocity;
    void Start()
    {
        pencilAngle = (180 / Mathf.PI) * Mathf.Atan(Input.mousePosition.y / Input.mousePosition.x) + 180;
        pencilRB2D = GetComponent<Rigidbody2D>();
        pencilVelocity = new Vector2(0, pencilSpeed);
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Homework") {
            Destroy(other.gameObject);
            PencilScript.credits += Upgrades.dotsPerHomework;
        }
        if (other.tag == "Barrier") {
            Destroy(gameObject);
        }
    }

    void FixedUpdate() {
        pencilRB2D.velocity = -pencilSpeed * transform.up;
    }
}
