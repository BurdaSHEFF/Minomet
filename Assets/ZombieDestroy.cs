using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDestroy : MonoBehaviour
{
    private Vector3 startPoint;
    
    // Start is called before the first frame update
    void Start()
    {
        startPoint = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        gameObject.transform.position = startPoint;
    }
}
