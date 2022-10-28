using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CloningScript : MonoBehaviour
{
    
    [SerializeField] private GameObject pencil;
    [SerializeField] private GameObject player;
    [SerializeField] private TMP_Text dots;
    private GameObject pencilClone;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            pencilClone = Instantiate(pencil, player.transform.position, player.transform.rotation);
        }
    }
}
