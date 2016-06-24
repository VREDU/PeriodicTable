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
using UnityEngine.UI;

public class elementManager : MonoBehaviour {
	public GameObject atomPrefab;
	public int compoundLimit;
	private GameObject atom;
	private int compoundsFormed;
	private Transform objectTransform;
	private Vector3 offset;

	void Start () {
		objectTransform = GetComponent<Transform> ();
		offset = new Vector3 (0, 0, -1); //spawns atom in front of element
		compoundsFormed = 0;
	}

	void Update() {
		if (compoundsFormed >= compoundLimit) {
			GetComponent<Renderer> ().material.color = Color.black;
		}
	}
		
	public void selectElement() {
		//cant select elements when the round is over
		if (canvasManager.playing == false) {
			canvasManager.playing = true;
		}

		if (compoundLimit > compoundsFormed && canvasManager.shotsLeft>=1) {
			GameObject.FindGameObjectWithTag ("gazeObjectHolder").GetComponent<gazeMovementManager> ().createGazeObject ();
			atom = Instantiate (atomPrefab, objectTransform.position + offset, objectTransform.rotation) as GameObject;
			atom.transform.parent = gameObject.transform;
		}
	}


	public void SetGazedAt(bool gazedAt) {
		if (compoundsFormed < compoundLimit) {
			GetComponent<Renderer> ().material.color = gazedAt ? Color.green : Color.white;
		}
	}

	public void incrementCompounds() {
		compoundsFormed = ++compoundsFormed;
	}
}
