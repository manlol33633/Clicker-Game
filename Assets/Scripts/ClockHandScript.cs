using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockHandScript : MonoBehaviour
{
    [SerializeField] float rotationSpeed;
    private Vector3 endRotation;
    private Vector2 cursorPosition;
    void Start()
    {
        
    }

    void Update()
    {
        cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        endRotation = new Vector3(0, 0, transform.rotation.z + 30);
        transform.Rotate(endRotation * Time.deltaTime);
        transform.position = cursorPosition;
    }
}
