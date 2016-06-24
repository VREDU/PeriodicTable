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

public class atomManager : MonoBehaviour {
	//this class makes the random movement for background atoms and has variables to see if atom should form a compound

	public bool background, diatomic;
	public int atomicNumber;
	private bool compound;
	private int x, y;
	private Vector3 force;

	void Start () {
		compound = false;
		int x = -3;
		int y = 3;

		if (background) {
			gameObject.GetComponent<Rigidbody> ().AddForce (Random.Range (x,y) ,Random.Range (x,y),Random.Range (x,y), ForceMode.Impulse);
			gameObject.GetComponent<Rigidbody> ().AddTorque (Random.Range (x,y),Random.Range (x,y),Random.Range (x,y));
		}
	}
		

	public bool isCompound() {
		return compound;
	}

	public bool isDiatomic() {
		return diatomic;
	}

	public int getAtomicNumber() {
		return atomicNumber;
	}

	public void setCompound(bool isCompound) {
		compound = isCompound;
	}
}
