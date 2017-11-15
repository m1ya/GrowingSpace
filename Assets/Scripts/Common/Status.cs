using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : SingletonMonoBehaviour<Status>
{
	public float growingPoint;

	public float clickPower;
	public float timePower;

	public void Init ()
	{
		growingPoint = 0;
		clickPower = timePower = 1;
	}
}
