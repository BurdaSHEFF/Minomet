using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoScript : MonoBehaviour
{
    public Reloaded reloaded;
    private Vector3 startPoint;
    private Quaternion startRotation;
    private Vector3 startScale;

    // Start is called before the first frame update
    void Start()
    {
        startPoint = gameObject.transform.position;
        startRotation = gameObject.transform.rotation;
        //startScale = gameObject.transform.lossyScale;
        gameObject.transform.localScale = new Vector3(20, 20, 20);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (!reloaded.isReloaded)
        {
            reloaded.isReloaded = true;
            gameObject.transform.position = startPoint;
            Instantiate(gameObject, startPoint, startRotation);
            Destroy(gameObject);
        }
    }
}
