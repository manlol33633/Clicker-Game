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
    public static GameObject pencilClone180;
    void Start()
    {

    }

    void Update()
    {
        if (Upgrades.isFlank && Input.GetMouseButtonDown(0)) {
            pencilClone = Instantiate(pencil, player.transform.position, player.transform.rotation);
            pencilClone180 = Instantiate(pencil180, player.transform.position, player.transform.rotation);

        }
        if (!Upgrades.isFlank && Input.GetMouseButtonDown(0)) {
            pencilClone = Instantiate(pencil, player.transform.position, player.transform.rotation);
        }
    }
}