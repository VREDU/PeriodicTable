using UnityEngine;
using System.Collections;

public class cameraManager : MonoBehaviour {
	//This class is to control the camera when making game footage
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(10*Vector3.up * Time.deltaTime);
	}
}
