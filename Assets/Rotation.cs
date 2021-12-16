using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Rotation : MonoBehaviour
{
	public GameObject Minomet;
	public LinearMapping linearMapping;
	private float currentLinearMapping = float.NaN;
	private float previousLinearMapping = 0;
	public float angle = 0;

	void Awake()
	{
		if (linearMapping == null)
		{
			linearMapping = GetComponent<LinearMapping>();
		}
	}

	void Start()
    {
        
    }

	void Update()
	{
		if (currentLinearMapping != linearMapping.value)
		{
			currentLinearMapping = linearMapping.value;
			Minomet.transform.localEulerAngles = new Vector3(0, 85 + 90 * currentLinearMapping, 0);
		}
	}
}