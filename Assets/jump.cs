using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour {

    private Vector3 position;
    private GameObject cameraRigGameObject;
    // Use this for initialization
    void Start() {
        position = new Vector3();
        cameraRigGameObject = GameObject.FindObjectOfType<SteamVR_ControllerManager>().gameObject;
        position = cameraRigGameObject.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        position.y = position.y + 1;
        cameraRigGameObject.transform.position.Set(position.x, position.y, position.z);
    }
}
