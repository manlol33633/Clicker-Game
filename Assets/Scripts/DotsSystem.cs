using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DotsSystem : MonoBehaviour
{
    [SerializeField] private TMP_Text dots;
    void Start()
    {
        
    }

    void Update()
    {
        dots.text = "Dots: " + PencilScript.credits;
    }
}
