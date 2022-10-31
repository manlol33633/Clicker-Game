using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class DyingAnimation : MonoBehaviour
{
    private UnityEngine.Rendering.VolumeProfile profileChromaticAberration;
    private UnityEngine.Rendering.VolumeProfile profileBloom;
    private UnityEngine.Rendering.Universal.ChromaticAberration myChromaticAberration;
    private UnityEngine.Rendering.Universal.Bloom myBloom;
    private float dyingLerpStart;
    private float dyingLerp;
    private Color tint;
    private float count = 0;
    private bool isUp;
    void Start() {
        profileChromaticAberration = GameObject.Find("Global Volume").GetComponent<UnityEngine.Rendering.Volume>().profile;
        profileChromaticAberration.TryGet(out myChromaticAberration);

        profileBloom = GameObject.Find("Global Volume").GetComponent<UnityEngine.Rendering.Volume>().profile;
        profileBloom.TryGet(out myBloom);
    }
    void Update() {
        if (SanityBar.sanityLevel <= 20 && SanityBar.sanityLevel > 0) {
            // Create a function that interpolates the bloom tint between red and white
            myBloom.tint.value = Color.red;
        }

        if (SanityBar.sanityLevel == 0) {
            myChromaticAberration.intensity.Override(0);
            myBloom.tint.Override(Color.black);
            Time.timeScale = 0;
        }
    }
}
