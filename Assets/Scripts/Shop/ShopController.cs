using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopController : MonoBehaviour
{
	const float CHANGE_TIME = 1.0f;

	float t;
	bool isOpened = false;
	bool isChanged;

	[SerializeField]
	private GameObject shop;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space)) {
			t = 0;
			isChanged = false;
		}
		
		if (Input.GetKey (KeyCode.Space)) {
			if (t >= CHANGE_TIME) {
				if (!isChanged) {
					if (!isOpened)
						OpenShop ();
					else
						CloseShop ();
				}
				isChanged = true;
			} else {
				t += Time.deltaTime;
			}
		}
	}

	void OpenShop ()
	{
		GameManager.Instance.isShop = true;
		isOpened = true;
		shop.SetActive (true);
	}

	void CloseShop ()
	{
		GameManager.Instance.isShop = false;
		isOpened = false;
		shop.SetActive (false);

	}
}
