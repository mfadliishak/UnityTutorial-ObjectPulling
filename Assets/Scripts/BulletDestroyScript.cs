using UnityEngine;
using System.Collections;

public class BulletDestroyScript : MonoBehaviour {
	
	void OnEnable()
	{
		Invoke ("Destroy", 2f);
	}

	void Destroy()
	{
		gameObject.SetActive (false);
	}

	void OnDisable()
	{
		// Cancelling any invoke(s) that queued up
		CancelInvoke ();
	}
}
