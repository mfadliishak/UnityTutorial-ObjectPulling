﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BulletFireScript : MonoBehaviour {

	public float fireTime = .05f;


	void Start () 
	{
		InvokeRepeating ("Fire", fireTime, fireTime);
	}

	void Fire () 
	{
		GameObject obj = ObjectPoolerScript.current.getPooledObject();

		if (obj == null)
			return;

		obj.transform.position = transform.position;
		obj.transform.rotation = transform.rotation;
		obj.SetActive(true);
	}
}
