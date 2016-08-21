using UnityEngine;
using System.Collections;

public class atomQuantity : MonoBehaviour {
	public GameObject atom;
	public Transform spawnPoint;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AddAtoms() {
		Instantiate (atom, spawnPoint.position, spawnPoint.rotation);
	}
}
