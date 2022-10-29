using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Upgrades : MonoBehaviour
{
    [SerializeField] private GameObject btnFlank;
    [SerializeField] private TMP_Text flankCost;
    [SerializeField] private int purchaseIntermission;
    public static int dotsPerHomework;
    public static bool isFlank;
    private float intermissionValue;
    void Start()
    {
        dotsPerHomework = 1;
        isFlank = false;
        intermissionValue = 0;
    }

    void Update()
    {
        intermissionValue += 1 + Time.deltaTime;
    }

    public void OnFlankPress() {
        if (PencilScript.credits >= 100) {
            isFlank = true;
            btnFlank.SetActive(false);
            PencilScript.credits -= 100;
            flankCost.text = "Purchased";
        }
    }

    public void OnDotsIncreasePress() {
        if (PencilScript.credits >= 30) {
            dotsPerHomework += 1;
            PencilScript.credits -= 30;
        }
    }
}
