using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {

    private float speed;
    private Rigidbody rb;
    // Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("hit1");
        if (other.gameObject.CompareTag("Pick Up"))
        {
            Debug.Log("hit");
            other.gameObject.SetActive(false);
        }
    }
}
