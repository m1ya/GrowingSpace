using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowByTime : MonoBehaviour
{

	float t;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (t >= 1) {
			t = 0;
			Status.Instance.growingPoint += Status.Instance.timePower;
		}
			
		t += Time.deltaTime;
	}
}
