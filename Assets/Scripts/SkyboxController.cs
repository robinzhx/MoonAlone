using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxController : MonoBehaviour {
    private float rot;

	// Use this for initialization
	void Start () {
        rot = RenderSettings.skybox.GetFloat("_Rotation");
    }
	
	// Update is called once per frame
	void Update () {
        rot -= 0.01f;
        if (rot < 0.0f) rot = 360.0f;
        RenderSettings.skybox.SetFloat("_Rotation", rot);
    }
}
