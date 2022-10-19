using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloningScript : MonoBehaviour
{
    [SerializeField] private GameObject homework;
    [SerializeField] private GameObject teacher;
    [SerializeField] private GameObject pencil;
    [SerializeField] private GameObject player;
    [SerializeField] private float cloningIntermission;
    private float intermissionValue;
    private GameObject homeworkClone;
    private GameObject pencilClone;
    void Start()
    {
        intermissionValue = 0;
    }

    void Update()
    {
        intermissionValue = intermissionValue + 1f * Time.deltaTime;
        if (intermissionValue >= cloningIntermission) {
            homeworkClone = Instantiate(homework, teacher.transform.position, teacher.transform.rotation);
            intermissionValue = 0;
        }
        if (Input.GetMouseButtonDown(0)) {
            pencilClone = Instantiate(pencil, player.transform.position, player.transform.rotation);
        }
    }
}
