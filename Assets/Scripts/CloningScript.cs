using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CloningScript : MonoBehaviour
{
    [SerializeField] private GameObject pencil;
    [SerializeField] private GameObject pencil180;
    [SerializeField] private GameObject player;
    [SerializeField] private TMP_Text dots;
    private GameObject homeworkClone;
    private GameObject pencilClone;
    private GameObject pencilClone180;
    private Quaternion pencilRotation;
    void Start()
    {

    }

    void Update()
    {
        pencilRotation = Quaternion.Euler(0, 0, player.transform.rotation.eulerAngles.z + 180);
        if (Upgrades.isFlank && Input.GetMouseButtonDown(0)) {
            pencilClone = Instantiate(pencil, player.transform.position, player.transform.rotation);
            pencilClone180 = Instantiate(pencil180, player.transform.position, pencilRotation);

        }
        if (!Upgrades.isFlank && Input.GetMouseButtonDown(0)) {
            pencilClone = Instantiate(pencil, player.transform.position, player.transform.rotation);
        }
    }
}