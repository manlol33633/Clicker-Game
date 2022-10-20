using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SanityBar : MonoBehaviour
{
    [SerializeField] private GameObject sanityBar;
    public static float sanityLevel;
    private float sanityPosition;
    private Vector2 scaleX;
    private Vector3 positionX;
    private float tempSanity;
    private float maxSanity;
    void Start()
    {
        sanityLevel = 100;
        tempSanity = sanityLevel;
        maxSanity = sanityBar.transform.localScale.x;
    }

    void Update()
    {
        if (sanityLevel < tempSanity) {
            positionX = new Vector3(sanityBar.transform.position.x - ((((100 - sanityLevel) / 2) / 100) * maxSanity), sanityBar.transform.position.y, sanityBar.transform.position.z);
            scaleX = new Vector2(sanityBar.transform.localScale.x - (sanityBar.transform.localScale.x * ((100 - sanityLevel) / 100)), sanityBar.transform.localScale.y);

            sanityBar.transform.position = positionX;
            sanityBar.transform.localScale = scaleX;

            tempSanity = sanityLevel;
            Debug.Log(positionX);
        }
    }
}
