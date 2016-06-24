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

public class rayCastManager : MonoBehaviour {
	public static Vector3 hitPoint, direction; //location of collision from the ray attached to main camera
	private int layerMask;

	void Start () {
		//rayCast will only hit with the Gaze Object layer
		layerMask = 1 << 12;
	}

	void Update () {
		Cursor.visible = false;
		RaycastHit hit;
		if (Physics.Raycast (transform.position, transform.forward, out hit, 200f, layerMask)) {
			hitPoint = hit.point;
			direction = transform.forward;
		}
	}
}
