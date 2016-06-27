/*
  	PeriodicTable2.0 - Explore the periodic table in VR
	Copyright (C) 2016  Marty Markenson

	This program is free software: you can redistribute it and/or modify
	it under the terms of the GNU General Public License as published by
	the Free Software Foundation, either version 3 of the License, or
	(at your option) any later version.

	This program is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
	GNU General Public License for more details.

		You should have received a copy of the GNU General Public License
		along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class hoverSelect : MonoBehaviour {

	public GameObject atomicStructure;
	public static GameObject active;
	public string elementName;
	public GameObject Instructions;
	private TextMesh gameText;

	void Start() {
		gameText = Instructions.GetComponent<TextMesh> ();
	}
	
	public void nextStepsHover(bool gazedAt) {
		GetComponent<Renderer> ().material.color = gazedAt ? Color.green : Color.white;
	}

	public void hoverGreen(bool gazedAt) {
		GetComponent<Renderer> ().material.color = gazedAt ? Color.green : Color.white;
	}


	public void clickElement() {
		if (active != null) {
			active.SetActive (false);
		}
		active = atomicStructure;
		active.SetActive (true);
		gameText.text = elementName;
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
