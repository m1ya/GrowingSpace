using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowByClick : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (!GameManager.Instance.isShop && Input.GetKeyDown (KeyCode.Space))
			Status.Instance.growingPoint += Status.Instance.clickPower;
	}
}
