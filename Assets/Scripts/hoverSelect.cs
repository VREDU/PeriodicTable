using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class hoverSelect : MonoBehaviour {
	
	public void nextStepsHover(bool gazedAt) {
		GetComponent<Renderer> ().material.color = gazedAt ? Color.green : Color.white;
	}

	public void hoverGreen(bool gazedAt) {
		GetComponent<Renderer> ().material.color = gazedAt ? Color.green : Color.white;
	}

	public void loadHome(){
		SceneManager.LoadScene (0);
	}

	public void loadHydrogen(){
		SceneManager.LoadScene (1);
	}

	public void loadHydrogenDiatomic(){
		SceneManager.LoadScene (2);
	}

	public void loadHelium(){
		SceneManager.LoadScene (3);
	}

	public void loadLithium(){
		SceneManager.LoadScene (4);
	}

	public void loadBeryllium(){
		SceneManager.LoadScene (5);
	}

	public void loadCarbon(){
		SceneManager.LoadScene (6);
	}

	public void loadNitrogen(){
		SceneManager.LoadScene (7);
	}

	public void loadNitrogenDiatomic(){
		SceneManager.LoadScene (8);
	}

	public void loadOxygen(){
		SceneManager.LoadScene (9);
	}

	public void loadOxygenDiatomic(){
		SceneManager.LoadScene (10);
	}

	public void loadFluorine(){
		SceneManager.LoadScene (11);
	}

	public void loadFlourineDiatomic(){
		SceneManager.LoadScene (12);
	}

	public void loadNeon(){
		SceneManager.LoadScene (13);
	}
}
