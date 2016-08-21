using UnityEngine;
using System.Collections;

public class idealGasManager : MonoBehaviour {
	public Transform boundary;
	private Vector3 scale;
	// Use this for initialization
	void Start () {
		scale = new Vector3 (.5f, .5f, .5f);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void increaseBoundary(){
		boundary.localScale += scale;
	}

	public void decreaseBoundary(){
		boundary.localScale -= scale;
	}
}
