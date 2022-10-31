using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SanityBar : MonoBehaviour
{
    [SerializeField] private Image sanityBar;
    [SerializeField] private Color color;
    public static float sanityLevel;
    private float sanityPosition;
    private Vector2 scaleX;
    private Vector3 positionX;
    private float tempSanity;
    private float maxSanity;
    private Color barColor;
    void Start()
    {
        sanityLevel = 100;
        tempSanity = sanityLevel;
        maxSanity = sanityBar.transform.localScale.x;
    }

    void Update()
    {
        barColor = new Color32(255, (byte)(255 * (sanityLevel / 100)), 0, 255);
        sanityBar.color = barColor;
        if (sanityLevel < tempSanity) {
            //positionX = new Vector3(sanityBar.transform.position.x - ((((100 - sanityLevel) / 2) / 100) * maxSanity), sanityBar.transform.position.y, sanityBar.transform.position.z);
            scaleX = new Vector2(maxSanity * (sanityLevel / 100), sanityBar.transform.localScale.y);

            //sanityBar.transform.position = positionX;
            sanityBar.transform.localScale = scaleX;

            tempSanity = sanityLevel;
        }
    }
}
