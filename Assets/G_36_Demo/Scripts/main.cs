using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    public ButtonScript button;
    public Reloaded reloaded;
    private MortarAction myMortar;
    private Squad_Leader_Mortar func;
    // Start is called before the first frame update
    void Start()
    {
        myMortar = GetComponent<MortarAction>();
    }

    // Update is called once per frame
    void Update()
    {
        if (button.isPressed && reloaded.isReloaded)
        {
            reloaded.isReloaded = false;
            myMortar.Fire();
        }
    }
}
