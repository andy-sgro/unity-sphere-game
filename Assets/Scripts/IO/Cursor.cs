using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Cursor
{
	public static float X
	{
		get
		{
			return Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
		}
	}

	public static float Y
	{
		get
		{
			return Camera.main.ScreenToWorldPoint(Input.mousePosition).y;
		}
	}

	public static float Angle
	{
		get
		{
			Vector3 screenCenter = new Vector3(Screen.width / 2, Screen.height / 2);
			return UberPhysics.GetAngle(screenCenter, Input.mousePosition);
		}
	}
}
