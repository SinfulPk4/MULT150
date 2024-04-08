using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{

	public Light lightSource;

	void Start()
	{
	
	}

	void Update()
	{
		if (Input.GetKeyUp(KeyCode.L))
		{
			GetComponent<UnityEngine.Light>().enabled = !GetComponent<UnityEngine.Light>().enabled;
		}
	}
}
