using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Power : MonoBehaviour
{
	//public GameObject Minomet;
	public LinearMapping linearMapping;
	private float currentLinearMapping = float.NaN;
	//private float previousLinearMapping = 0;
	public float power;

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
			power = currentLinearMapping;
		}
	}
}