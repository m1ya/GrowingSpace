using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingletonMonoBehaviour<GameManager>
{
	public bool isShop;

	// Use this for initialization
	void Start ()
	{
		Status.Instance.Init ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
