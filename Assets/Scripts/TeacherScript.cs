using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeacherScript : MonoBehaviour
{
    private float teacherAngle;
    void Start()
    {
        
    }

    void Update()
    {
        if (transform.position.x < 0) {
            teacherAngle = (180/Mathf.PI) * Mathf.Atan(transform.position.y / transform.position.x);
            transform.rotation = Quaternion.Euler(0, 0, teacherAngle - 90);
        } else {
            teacherAngle = (180/Mathf.PI) * Mathf.Atan(transform.position.y / transform.position.x);
            transform.rotation = Quaternion.Euler(0, 0, teacherAngle + 90);
        }
        
    }
}
