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

public class boundaryManager : MonoBehaviour {

	//users score doesn't increase if an atom bounces off a wall then forms a compound
	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "shooter") {
			canvasManager.shotsLeft--;
			other.gameObject.GetComponent<shooterManager> ().setShooter (false);
			other.gameObject.tag = "Untagged";
		}
	}
}

