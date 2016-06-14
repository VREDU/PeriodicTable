using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class hoverSelect : MonoBehaviour {
	
	public void nextStepsHover(bool gazedAt) {
		GetComponent<Renderer> ().material.color = gazedAt ? Color.green : Color.white;
	}

	public void loadHydrogen(){
		SceneManager.LoadScene (3);
	}

	public void loadHelium(){
		SceneManager.LoadScene (4);
	}

	public void loadNitrogen(){
		SceneManager.LoadScene (5);
	}

	public void loadOxygen(){
		SceneManager.LoadScene (6);
	}

	public void loadFluorine(){
		SceneManager.LoadScene (7);
	}

	public void loadNeon(){
		SceneManager.LoadScene (8);
	}
}
