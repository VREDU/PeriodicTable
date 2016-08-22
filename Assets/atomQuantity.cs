using UnityEngine;
using System.Collections;

public class atomQuantity : MonoBehaviour {
	public GameObject atom;
	public Object[] atomArray;
	public Transform spawnPoint;
	public int i;
	// Use this for initialization
	void Start () {
		i = 5;
	}
	void Update () {
		//Debug.Log (i);
	}

	public void AddAtoms() {
		Debug.Log (i);
		if (i < 10) {
			i++;
			atomArray [i] = Instantiate (atom, spawnPoint.position, spawnPoint.rotation);
		}
	}

	public void destroyAtoms(){
		if (i >= 0) {
			Destroy (atomArray [i]);
			i--;
		}
	}
}
