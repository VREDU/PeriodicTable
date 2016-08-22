using UnityEngine;
using System.Collections;

public class atomChanger : MonoBehaviour {
	atomQuantity atoms;
	// Use this for initialization
	void Start () {
		atoms = GetComponentInParent<atomQuantity>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void increament(){
		atoms.AddAtoms();
	}
}
