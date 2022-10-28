using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrades : MonoBehaviour
{
    [SerializeField] private GameObject btnFlank;
    public static int dotsPerHomework;
    public static bool isFlank;
    void Start()
    {
        dotsPerHomework = 1;
        isFlank = false;
    }

    void Update()
    {
        
    }

    public void OnFlankPress() {
        if (PencilScript.credits >= 100) {
            isFlank = true;
            btnFlank.SetActive(false);
            PencilScript.credits -= 100;
        }
    }

    public void OnDotsIncreasePress() {
        if (PencilScript.credits >= 30) {
            dotsPerHomework += 1;
            PencilScript.credits -= 30;
        }
    }
}
