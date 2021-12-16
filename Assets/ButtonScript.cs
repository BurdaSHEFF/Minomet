using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class ButtonScript : MonoBehaviour
{
    public bool isPressed = false;
    public Reloaded reloaded;
    void Start()
    {
        ColorSelf(Color.red);
    }

    void Update()
    {
        if (reloaded.isReloaded)
        {
            ColorSelf(Color.green);
        }
        else
        {
            ColorSelf(Color.red);
        }
    }

    public void OnButtonDown(Hand fromHand)
    {
        //ColorSelf(Color.green);   
        isPressed = true;
        fromHand.TriggerHapticPulse(1000);
    }

    public void OnButtonUp(Hand fromHand)
    {
        isPressed = false;
        //ColorSelf(Color.red);
    }

    private void ColorSelf(Color newColor)
    {
        Renderer[] renderers = this.GetComponentsInChildren<Renderer>();
        for (int rendererIndex = 0; rendererIndex < renderers.Length; rendererIndex++)
        {
            renderers[rendererIndex].material.color = newColor;
        }
    }
}