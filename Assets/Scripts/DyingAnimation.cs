using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class DyingAnimation : MonoBehaviour
{
    private UnityEngine.Rendering.VolumeProfile profileChromaticAberration;
    private UnityEngine.Rendering.Universal.ChromaticAberration myChromaticAberration;
    private UnityEngine.Rendering.VolumeProfile profileBloom;
    private UnityEngine.Rendering.Universal.Bloom myBloom;
    private UnityEngine.Rendering.VolumeProfile profileVignette;
    private UnityEngine.Rendering.Universal.Vignette myVignette;
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

        profileVignette = GameObject.Find("Global Volume").GetComponent<UnityEngine.Rendering.Volume>().profile;
        profileBloom.TryGet(out myVignette); 
    }
    void Update() {
        if (SanityBar.sanityLevel <= 20 && SanityBar.sanityLevel > 0) {
            // Create a function that interpolates the bloom tint between red and white
            myBloom.tint.value = Color.red;
            myVignette.intensity.value = 0.5f;
        }

        if (SanityBar.sanityLevel == 0) {
            myChromaticAberration.intensity.Override(0);
            myBloom.tint.Override(Color.black);
            SceneManager.LoadScene("GameOver");
            Time.timeScale = 0;
        }
    }
}
