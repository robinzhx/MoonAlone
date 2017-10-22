using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour {

	public Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent < Rigidbody>();
	}

	void onTriggerEnter(Collider other)
	{
		Debug.Log("hit1");
		if(other.gameObject.CompareTag("Pick Up"))
		{
			Debug.Log("hit");
			other.gameObject.SetActive(false);
		}
	}
}
