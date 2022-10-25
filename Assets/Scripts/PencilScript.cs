using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PencilScript : MonoBehaviour
{
    [SerializeField] private float pencilSpeed;
    [SerializeField] private TMP_Text dots;
    private float pencilAngle;
    private Rigidbody2D pencilRB2D;
    private Vector2 pencilVelocity;
    public static int credits;
    void Start()
    {
        pencilRB2D = GetComponent<Rigidbody2D>();
        pencilVelocity = new Vector2(0, pencilSpeed);
        credits = 0;
    }

    void Update()
    {
        pencilAngle = (180 / Mathf.PI) * Mathf.Atan(Input.mousePosition.y / Input.mousePosition.x);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Homework") {
            Destroy(other.gameObject);
            credits++;
            //dots.text = "Dots: " + credits;
        }
        if (other.tag == "Barrier") {
            Destroy(gameObject);
        }
    }

    void FixedUpdate() {
        pencilRB2D.velocity = pencilSpeed * transform.up;
    }
}
