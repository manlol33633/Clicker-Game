using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    private Rigidbody2D playerRB2D;
    private float playerAngle;
    private Vector2 mousePosition2D;
    private Quaternion playerRotation;
    private Vector3 mousePosition3D;
    void Start()
    {
        Cursor.visible = false;
        playerRB2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        mousePosition3D = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition2D = new Vector2(mousePosition3D.x, mousePosition3D.y);
        playerAngle = (180 / Mathf.PI) * Mathf.Atan(mousePosition2D.y / mousePosition2D.x);
        if (mousePosition2D.x < 0) {
            playerRotation = Quaternion.Euler(0, 0, playerAngle + 90);
        } else {
            playerRotation = Quaternion.Euler(0, 0, playerAngle - 90);
        }

        transform.rotation = Quaternion.Lerp(transform.rotation, playerRotation, rotationSpeed);
    }

    void FixedUpdate() {
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Homework") {
            if (SanityBar.sanityLevel != 0) {
                SanityBar.sanityLevel -= 5;
            }
        }
    }
}
