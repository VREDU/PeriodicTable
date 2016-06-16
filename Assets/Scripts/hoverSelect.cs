using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class hoverSelect : MonoBehaviour {
	
	public void nextStepsHover(bool gazedAt) {
		GetComponent<Renderer> ().material.color = gazedAt ? Color.green : Color.white;
	}

	public void loadHydrogen(){
		SceneManager.LoadScene (2);
	}

	public void loadBeryllium(){
		SceneManager.LoadScene (9);
	}

	public void loadHelium(){
		SceneManager.LoadScene (3);
	}

	public void loadNitrogen(){
		SceneManager.LoadScene (4);
	}

	public void loadOxygen(){
		SceneManager.LoadScene (5);
	}

	public void loadFluorine(){
		SceneManager.LoadScene (6);
	}

	public void loadNeon(){
		SceneManager.LoadScene (7);
	}

	public void loadLithium(){
		SceneManager.LoadScene (8);
	}

	public void loadCarbon(){
		SceneManager.LoadScene (10);
	}

	public void loadHome(){
		SceneManager.LoadScene (0);
	}

	public void loadHydrogenDiatomic(){
		SceneManager.LoadScene (1);
	}
}
