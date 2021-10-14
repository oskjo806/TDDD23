using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Actions : MonoBehaviour
{
    public Slider shurikenSlider;
    public Slider grapHookSlider;
    private bool usedShuriken = false;
    private float startTime;
    private float deltaTime;

    private void Update()
    {
        if (usedShuriken)
        {
            deltaTime = Time.time - startTime;
            shurikenSlider.value = Mathf.Lerp(0, 1, deltaTime * 10f);
            if (shurikenSlider.value == 1)
            {
                shurikenSlider.value = 0;
                usedShuriken = false;
            }

        }
    }
    public void UseShuriken()
    {
        startTime = Time.time;
        usedShuriken = true;
    }
    public void UseGrapHook()
    {
        Debug.Log("GrapHook Used");
    }
}
