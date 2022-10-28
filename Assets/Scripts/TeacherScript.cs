using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeacherScript : MonoBehaviour
{
    [SerializeField] private GameObject homework;
    [SerializeField] private float cloningIntermission;
    private float intermissionValue;
    private GameObject homeworkClone;
    private float teacherAngle;
    void Start()
    {
        intermissionValue = 0;
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
        intermissionValue = intermissionValue + 1f * Time.deltaTime;
        if (intermissionValue >= cloningIntermission) {
            homeworkClone = Instantiate(homework, transform.position, transform.rotation);
            intermissionValue = 0;
        }
    }
}
